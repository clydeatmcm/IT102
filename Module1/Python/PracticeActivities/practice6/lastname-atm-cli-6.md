# Practice Challenge 6: Modular ATM with Transaction Logging

## File Path

`Desktop\LASTNAME\oop\m1\practice6\lastname-atm-cli-6.py`

## Goal

Combine the concepts from Challenges 1–5 into one modular ATM program.

The program will use:

- Functions
- Parameters
- Arguments
- `return`
- `input()`
- `if/elif/else`
- Text file writing
- Text file reading
- `readlines()`
- `strip()`
- `count()`
- `find()`

This activity demonstrates how functions can be combined with text processing and file processing.

---

## Guide Code

```python
account_name = "Juan Dela Cruz"
balance = 10000.00


# TODO 1: Create welcome_user(name)


# TODO 2: Create check_balance(balance)


# TODO 3: Create deposit_money(current_balance, amount)


# TODO 4: Create save_transaction(name, transaction, amount)


# TODO 5: Create view_history()


# TODO 6: Create analyze_transactions()


welcome_user(account_name)

print()
print("===== ATM MENU =====")
print("1. Check Balance")
print("2. Deposit")
print("3. View History")
print("4. Analyze Transactions")

choice = input("Choose option: ")


# TODO 7: Check Balance
if choice == "1":

    # Call check_balance()


# TODO 8: Deposit
elif choice == "2":

    deposit = float(input("Enter deposit amount: "))

    if deposit > 0:

        # TODO 9: Update the balance using deposit_money()


        # TODO 10: Save the transaction


        print("Deposit successful.")
        print(f"New Balance: ₱{balance:.2f}")

    else:
        print("Invalid deposit amount.")


# TODO 11: View History
elif choice == "3":


# TODO 12: Analyze Transactions
elif choice == "4":


else:
    print("Invalid option.")
```

---

# Instructions

Do not try to complete all TODOs immediately.

Follow the steps in order.

---

## TODO 1 — Create `welcome_user()`

Create the following function:

```python
def welcome_user(name):

    print("==============================")
    print("  PYTHON CLI ATM")
    print(f"Welcome, {name}!")
    print("==============================")
```

### Expected Result

When the function is called:

```python
welcome_user(account_name)
```

The output should be:

```text
==============================
  PYTHON CLI ATM
Welcome, Juan Dela Cruz!
==============================
```

---

## TODO 2 — Create `check_balance()`

Create:

```python
def check_balance(balance):
```

Inside the function:

```python
print(f"Current Balance: ₱{balance:.2f}")
```

### Hint

The function receives the balance as a parameter.

You do not need to use `return` because the function only displays the balance.

---

## TODO 3 — Create `deposit_money()`

Create:

```python
def deposit_money(current_balance, amount):
    return current_balance + amount
```

### Flow

```text
Current Balance: ₱10,000
        +
Deposit: ₱1,000
        ↓
New Balance: ₱11,000
```

The function returns the new balance.

---

## TODO 4 — Create `save_transaction()`

Create:

```python
def save_transaction(name, transaction, amount):
```

Inside the function, perform the following steps.

### Step 1 — Open the File

```python
file = open("transactions.txt", "w")
```

### Step 2 — Write the Account Name

```python
file.write(f"Account: {name}\n")
```

### Step 3 — Write the Transaction

```python
file.write(f"Transaction: {transaction}\n")
```

### Step 4 — Write the Amount

```python
file.write(f"Amount: ₱{amount}\n")
```

### Step 5 — Close the File

```python
file.close()
```

---

## TODO 5 — Create `view_history()`

Create:

```python
def view_history():
```

Open the file:

```python
file = open("transactions.txt", "r")
```

Read all lines:

```python
lines = file.readlines()
```

Display each line:

```python
for line in lines:
    print(line.strip())
```

Close the file:

```python
file.close()
```

---

## TODO 6 — Create `analyze_transactions()`

Create:

```python
def analyze_transactions():
```

### Open the File

```python
file = open("transactions.txt", "r")
```

### Read the File

```python
content = file.read()
```

### Close the File

```python
file.close()
```

### Count Deposits

Use `count()`:

```python
deposit_count = content.count("Deposit")
```

### Find the First Deposit

Use `find()`:

```python
first_deposit = content.find("Deposit")
```

### Display the Results

```python
print(f"Total Deposits: {deposit_count}")
print(f"First Deposit Index: {first_deposit}")
```

---

## TODO 7 — Connect Check Balance

The menu already contains:

```python
if choice == "1":
```

Call the function:

```python
check_balance(balance)
```

### Expected Output

```text
Choose option: 1
Current Balance: ₱10000.00
```

---

## TODO 8 — Deposit

The guide code already contains:

```python
deposit = float(input("Enter deposit amount: "))
```

It also checks whether the deposit is valid:

```python
if deposit > 0:
```

No changes are required for these lines.

---

## TODO 9 — Update the Balance

Inside the valid deposit condition, use:

```python
balance = deposit_money(balance, deposit)
```

The function:

```python
deposit_money(balance, deposit)
```

returns a new balance.

Store the returned value back into:

```python
balance
```

---

## TODO 10 — Save the Transaction

After updating the balance, save the transaction:

```python
save_transaction(account_name, "Deposit", deposit)
```

The three arguments are:

```text
account_name → name
"Deposit"    → transaction
deposit      → amount
```

---

## TODO 11 — View History

When the user chooses option 3, call:

```python
view_history()
```

### Expected Output

Assuming a deposit of ₱1,000 was previously saved:

```text
Choose option: 3
===== TRANSACTION HISTORY =====
Account: Juan Dela Cruz
Transaction: Deposit
Amount: ₱1000.0
```

---

## TODO 12 — Analyze Transactions

When the user chooses option 4, call:

```python
analyze_transactions()
```

### Expected Output

```text
Choose option: 4
===== TRANSACTION ANALYSIS =====
Total Deposits: 1
First Deposit Index: ...
```

The exact index depends on the contents of `transactions.txt`.

---

# Complete Expected Output

## Option 1 — Check Balance

```text
==============================
  PYTHON CLI ATM
Welcome, Juan Dela Cruz!
==============================

===== ATM MENU =====
1. Check Balance
2. Deposit
3. View History
4. Analyze Transactions
Choose option: 1
Current Balance: ₱10000.00
```

---

## Option 2 — Deposit

When the user enters `1000`:

```text
==============================
  PYTHON CLI ATM
Welcome, Juan Dela Cruz!
==============================

===== ATM MENU =====
1. Check Balance
2. Deposit
3. View History
4. Analyze Transactions
Choose option: 2
Enter deposit amount: 1000
Deposit successful.
New Balance: ₱11000.00
```

The `transactions.txt` file should contain:

```text
Account: Juan Dela Cruz
Transaction: Deposit
Amount: ₱1000.0
```

---

## Option 3 — View History

If the transaction file already contains the deposit:

```text
==============================
  PYTHON CLI ATM
Welcome, Juan Dela Cruz!
==============================

===== ATM MENU =====
1. Check Balance
2. Deposit
3. View History
4. Analyze Transactions
Choose option: 3
===== TRANSACTION HISTORY =====
Account: Juan Dela Cruz
Transaction: Deposit
Amount: ₱1000.0
```

---

## Option 4 — Analyze Transactions

```text
==============================
  PYTHON CLI ATM
Welcome, Juan Dela Cruz!
==============================

===== ATM MENU =====
1. Check Balance
2. Deposit
3. View History
4. Analyze Transactions
Choose option: 4
===== TRANSACTION ANALYSIS =====
Total Deposits: 1
First Deposit Index: ...
```

The exact index may vary depending on the contents of the text file.

---

# Requirements Summary

| TODO | Requirement |
|---:|---|
| 1 | Create `welcome_user(name)` |
| 2 | Create `check_balance(balance)` |
| 3 | Create `deposit_money(current_balance, amount)` |
| 4 | Create `save_transaction(name, transaction, amount)` |
| 5 | Create `view_history()` |
| 6 | Create `analyze_transactions()` |
| 7 | Connect Check Balance to the menu |
| 8 | Accept a deposit amount using `input()` |
| 9 | Update the balance using `deposit_money()` |
| 10 | Save the deposit transaction |
| 11 | Connect View History to the menu |
| 12 | Connect Transaction Analysis to the menu |

---

# File Processing Concepts Used

The completed program demonstrates:

| Function / Method | Purpose |
|---|---|
| `open()` | Open a text file |
| `write()` | Write transaction data |
| `read()` | Read the entire file |
| `readlines()` | Read the file line by line |
| `strip()` | Remove whitespace and newline characters |
| `count()` | Count occurrences of `"Deposit"` |
| `find()` | Find the position of the first `"Deposit"` |
| `close()` | Close the file |

---

# Important Note

The current guide uses:

```python
open("transactions.txt", "w")
```

The `"w"` mode **overwrites the existing contents of the file** each time a transaction is saved.

Therefore, the file will contain the **most recently saved transaction** rather than a cumulative transaction history.

This behavior is intentional for this practice challenge and allows the activity to focus on modular programming and basic text file processing.
