# Mini ATM Kiosk - MVC + 5 Database Tables

This beginner project demonstrates **Python Basics + OOP + Modular Python + MVC + Streamlit + Supabase + CRUD**.

The redesigned database has exactly **5 tables**:

1. `customers` - customer profile
2. `accounts` - bank account and balance
3. `atm_cards` - ATM card and bcrypt PIN hash
4. `transactions` - deposit and withdrawal history
5. `atm_sessions` - successful/failed ATM login attempts

## 1. Beginner Database Rule

For this tutorial, start with this useful convention:

> An important piece of persistent data can have a Model class and a database table.

So this project maps:

| Model | Table |
|---|---|
| `Customer` | `customers` |
| `Account` | `accounts` |
| `ATMCard` | `atm_cards` |
| `Transaction` | `transactions` |
| `ATMSession` | `atm_sessions` |

Not every Python class needs a table. `ATMController`, repositories, views, and `PinSecurity` perform work but are not persistent business entities.

## 2. Project Structure

```text
mini_atm_mvc_5tables/
|-- app.py
|-- create_demo_account.py
|-- schema.sql
|-- requirements.txt
|-- .env.example
|-- models/
|   |-- customer.py
|   |-- account.py
|   |-- atm_card.py
|   |-- transaction.py
|   |-- atm_session.py
|   `-- pin_security.py
|-- repositories/
|   |-- database.py
|   |-- customer_repository.py
|   |-- account_repository.py
|   |-- card_repository.py
|   |-- transaction_repository.py
|   `-- session_repository.py
|-- controllers/
|   `-- atm_controller.py
|-- views/
|   |-- login_view.py
|   `-- atm_view.py
`-- .streamlit/
    `-- secrets.toml.example
```

## 3. Create Your Python Environment

Open Command Prompt or PowerShell inside the project folder.

Replace `balaman` with your own lastname.

```bash
python -m venv .balaman
```

Windows Command Prompt:

```bash
.balaman\Scripts\activate
```

PowerShell:

```powershell
.balaman\Scripts\Activate.ps1
```

You should now see your environment name near the command prompt.

Upgrade pip:

```bash
python -m pip install --upgrade pip
```

Install the packages:

```bash
python -m pip install -r requirements.txt
```

## 4. Test the WebSockets Fix

Run:

```bash
python -c "from websockets.asyncio.client import connect; print('WebSockets OK')"
```

Expected:

```text
WebSockets OK
```

Then test Supabase:

```bash
python -c "from supabase import create_client; print('Supabase OK')"
```

## 5. Create a Supabase Project

1. Create/open your Supabase project.
2. Open the **SQL Editor**.
3. Open this project's `schema.sql`.
4. Copy all SQL code.
5. Paste it into the Supabase SQL Editor.
6. Run the script.
7. Confirm these 5 tables exist: `customers`, `accounts`, `atm_cards`, `transactions`, `atm_sessions`.

## 6. Configure Supabase

### Option A - `.env`

Copy `.env.example` and rename the copy to `.env`.

```env
SUPABASE_URL=YOUR_SUPABASE_URL
SUPABASE_KEY=YOUR_SUPABASE_KEY
```

### Option B - Streamlit TOML

Copy `.streamlit/secrets.toml.example` and rename the copy to `.streamlit/secrets.toml`.

```toml
SUPABASE_URL = "YOUR_SUPABASE_URL"
SUPABASE_KEY = "YOUR_SUPABASE_KEY"
```

Do not upload your real `.env` or `secrets.toml` to a public repository.

## 7. Create Demo ATM Data

Run this only once on an empty database:

```bash
python create_demo_account.py
```

Expected demo credentials:

```text
Customer: Juan Dela Cruz
Card Number: 55550001
PIN: 1234
Account Number: 10001
Starting Balance: PHP 10,000.00
```

The database does not store `1234` directly. `bcrypt` stores a hash in `atm_cards.pin_hash`.

## 8. Run the ATM

```bash
python -m streamlit run app.py
```

Your browser should open the ATM.

Login with:

```text
Card Number: 55550001
PIN: 1234
```

## 9. Test the Features

### Balance
Expected starting balance: `PHP 10,000.00`.

### Deposit
Deposit `1000`.
Expected balance: `PHP 11,000.00`.

### Withdraw
Withdraw `500`.
Expected balance: `PHP 10,500.00`.

### History
You should see a Deposit and Withdrawal record.

### Change PIN
Change `1234` to another 4-digit PIN, logout, and login with the new PIN.

## 10. Follow One Login Through MVC

```text
User enters Card Number + PIN
        |
        v
views/login_view.py
        |
        v
controllers/atm_controller.py
        |
        +--> atm_cards table: find card
        +--> bcrypt: verify PIN
        +--> accounts table: find account
        +--> customers table: find owner
        +--> atm_sessions table: record login
        |
        v
View opens ATM menu
```

## 11. Follow One Deposit

```text
User clicks Deposit
        |
        v
View
        |
        v
Controller
        |
        v
Account.deposit()
        |
        +--> accounts table: UPDATE balance
        |
        +--> transactions table: CREATE record
        |
        v
View shows new balance
```

## 12. Where CRUD Appears

| CRUD | Example |
|---|---|
| CREATE | Customer, account, card, transaction, session |
| READ | Login, account lookup, history |
| UPDATE | Balance, PIN |
| DELETE | Not exposed in the ATM UI because real ATM users should not delete their bank records |

The repository pattern can still support Delete later for an administrator exercise.

## 13. Beginner Python Used

The project intentionally uses simple syntax:

```python
if amount > account.get_balance():
    return False
```

```python
result = controller.deposit(account, amount)
if result:
    st.success("Deposit successful.")
```

```python
menu_items = ["Balance", "Deposit", "Withdraw", "Change PIN", "History"]
```

```python
for transaction in history:
    st.write(transaction.display())
```

## 14. MVC Memory Guide

```text
MODEL
What data does the system know?
Customer, Account, ATMCard, Transaction, ATMSession

VIEW
What does the user see?
Streamlit screens

CONTROLLER
What should happen after a user action?
ATMController

REPOSITORY
How does Python communicate with Supabase?
Repository classes

app.py
Where does the program start?
```

## 15. Important Security Note

This is a classroom application, not a production banking system. It demonstrates bcrypt hashing and modular design, but real ATMs require much stronger controls such as hardware security modules, encrypted PIN handling, transaction atomicity, authorization, rate limiting, auditing, fraud controls, and secure banking networks.
