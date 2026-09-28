from repositories.customer_repository import CustomerRepository
from repositories.account_repository import AccountRepository
from repositories.card_repository import CardRepository
from models.pin_security import PinSecurity

customers = CustomerRepository()
accounts = AccountRepository()
cards = CardRepository()

customer = customers.create("Clyde Balaman", "clydebalaman@example.com")
account = accounts.create(customer["id"], "10001", "Savings", 10000)
pin_hash = PinSecurity.hash_pin("1234")
card = cards.create(account["id"], "55550001", pin_hash)

print("Demo ATM data created.")
print("Customer: Clyde Balaman")
print("Card Number: 55550001")
print("PIN: 1234")
print("Account Number: 10001")
print("Starting Balance: PHP 10,000.00")
