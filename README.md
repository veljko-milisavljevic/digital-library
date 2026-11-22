# Digitalna biblioteka (Digital Library)

A Windows desktop application for running a school library: members and books get QR codes, and loans and returns are recorded by scanning them with a webcam. Built in C# (.NET 6, Windows Forms) in 2022 for a high-school library.

The user interface and the user manual are in Serbian.

<!-- Screenshots: add images to docs/screenshots/ and link them here. -->

## Features

- **Books.** Add, search (by ID, title or author, or by scanning the book's QR code) and remove books. Every copy has its own ID (the inventory number), and the app tracks how many copies of a title exist and how many are available.
- **Members.** Students and teachers, with contact data. Students also have a grade and class. Members can be searched by ID or by scanning their membership card.
- **QR codes.** The app generates a QR code for every new member (the membership card) and can print QR labels for books. Codes are created with ZXing.Net and read from a webcam stream through AForge.NET.
- **Loans and returns.** A loan lasts 15 days. If the due date falls on a weekend, it moves to Monday. On return, the app shows how many days the loan is overdue.
- **E-mail notifications** (optional, via SMTP):
  - a welcome e-mail with the membership card when a student joins;
  - a confirmation for every new loan;
  - reminders for overdue loans, with a late fee of 10 RSD per day after 30 days.
- **Printable reports.** All members with active loans, students with overdue loans (1+, 14+ or 30+ days), and the full book list.
- **End of school year.** One action moves every student up a grade and removes students who have finished the 4th grade.
- **Backup.** On start-up, if the last backup is more than a day old, the app e-mails all data files to the library's address.

## Tech stack

| | |
|---|---|
| Language / runtime | C#, .NET 6 |
| UI | Windows Forms (`net6.0-windows`) |
| QR codes | [ZXing.Net](https://github.com/micjahn/ZXing.Net) 0.16.6 |
| Webcam | [AForge.NET](http://www.aforgenet.com/) `AForge.Video.DirectShow` 2.2.5 |
| E-mail | `System.Net.Mail` (SMTP, Gmail by default) |
| Storage | Pipe-separated text files (`|`) |

## Architecture

The solution `DigitalnaBiblioteka.sln` has two projects:

```
BibliotekaLibrary/   Class library (net6.0): domain model and data access, no UI
  Knjiga, Ucenik, Profesor, Zaduzenje   Book, student, teacher, loan
  IKorisnik                             Common interface for students and teachers
  IDataConnection                       Data-access interface (add/remove/search/loan…)
  TextConnector                         IDataConnection implementation on text files
  TextConnectorProcessor                Parsing and saving the text files
  GlobalConfig                          Chooses the data connection at start-up
  Email                                 SMTP notifications and backup
BibliotekaUI/        Windows Forms app (net6.0-windows): main window and one form per task
  DigitalnaBiblioteka   Main window, menus, reports
  Dodaj… / Ukloni…      Add / remove books and members
  Pretrazi…             Search books and members (keyboard or webcam QR)
  ZaduziKnjigu / RazduziKnjigu   Loan / return
  GenerisiQR            Print QR labels
```

The UI talks to the data only through `IDataConnection` (`GlobalConfig.Veze`). The text-file storage could be replaced with a database by adding another implementation, without changing the forms.

### Data files

All data lives in the folder set by `filePath` in `BibliotekaUI/App.config` (default `C:\DigitalnaBiblioteka`). Each file has one record per line, with fields separated by `|`:

| File | Fields |
|---|---|
| `Knjige.csv` | ID, title, author, copies, available |
| `Učenici.csv` | ID, first name, last name, parent's name, date of birth, address, phone, grade, class |
| `Profesori.csv` | ID, first name, last name, parent's name, date of birth, address, phone |
| `Zaduženja.csv` | member ID, book ID, loan date, due date |
| `Poslednji backup.csv` | day, month, year of the last backup |

Generated membership cards are saved to `Clanske karte/<member ID>.png`.

> **Sample data.** The data files in this repository contain made-up sample records (names, addresses and phone numbers are fictional), not data of real library members.

## Getting started

**Requirements:** Windows, [Visual Studio 2022](https://visualstudio.microsoft.com/) with the *.NET desktop development* workload (or the .NET 6 SDK), and a webcam for QR scanning.

> .NET 6 is out of support. The project still builds with the .NET 6 SDK. Retargeting to .NET 8 should only need the `TargetFramework` values changed, but this has not been tested.

1. Clone the repository to `C:\DigitalnaBiblioteka`. This path is hardcoded in `App.config` and in a few places in the code (membership cards, e-mail logo).
2. Open `DigitalnaBiblioteka.sln` and run `BibliotekaUI` (F5). NuGet packages are restored automatically.
3. *(Optional)* To enable e-mail, set these environment variables before starting the app:

   | Variable | Value |
   |---|---|
   | `BIBLIOTEKA_EMAIL` | The sender address, which also receives the backups |
   | `BIBLIOTEKA_EMAIL_PASSWORD` | Its SMTP password (for Gmail, an [app password](https://support.google.com/accounts/answer/185833)) |

   Without them, the app works normally and simply skips sending e-mails.

The user manual is in [`Uputstvo za korišćenje.docx`](Uputstvo%20za%20kori%C5%A1%C4%87enje.docx) (Serbian; the first chapters are complete, the rest are headings only).

## Known limitations

- Windows only (Windows Forms, DirectShow webcam access).
- The data folder `C:\DigitalnaBiblioteka` is hardcoded in several places.
- The text-file storage has no locking or validation. A `|` in any field breaks the record format (the manual warns about this).
- Member e-mail addresses are not entered: they are generated from the name (and, for students, the date of birth) on the school's domain.
- E-mail sending is fire-and-forget (`SendAsync`), and errors are not shown to the user.

## Author

**Veljko Milisavljević** · [GitHub](https://github.com/veljko-milisavljevic)
