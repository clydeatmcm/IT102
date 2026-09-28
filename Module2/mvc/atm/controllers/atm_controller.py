from models.account import Account
from models.atm_card import ATMCard
from models.customer import Customer
from models.pin_security import PinSecurity
from repositories.account_repository import AccountRepository
from repositories.card_repository import CardRepository
from repositories.customer_repository import CustomerRepository
from repositories.transaction_repository import TransactionRepository
from repositories.session_repository import SessionRepository

class ATMController:
    def __init__(self):
        self.accounts = AccountRepository()
        self.cards = CardRepository()
        self.customers = CustomerRepository()
        self.transactions = TransactionRepository()
        self.sessions = SessionRepository()

    def login(self, card_number, pin):
        card_data = self.cards.find_by_number(card_number)
        if card_data is None:
            return None
        if card_data["is_active"] is False:
            self.sessions.create(card_data["id"], "Blocked")
            return None
        if PinSecurity.verify_pin(pin, card_data["pin_hash"]) is False:
            self.sessions.create(card_data["id"], "Failed")
            return None

        account_data = self.accounts.find_by_id(card_data["account_id"])
        customer_data = self.customers.find_by_id(account_data["customer_id"])
        self.sessions.create(card_data["id"], "Success")

        account = Account(account_data["id"], account_data["customer_id"], account_data["account_number"], account_data["account_type"], account_data["balance"])
        customer = Customer(customer_data["id"], customer_data["full_name"], customer_data["email"])
        card = ATMCard(card_data["id"], card_data["account_id"], card_data["card_number"], card_data["is_active"])
        return {"account": account, "customer": customer, "card": card}

    def deposit(self, account, amount):
        if account.deposit(amount) is False:
            return False
        self.accounts.update_balance(account.id, account.get_balance())
        self.transactions.create(account.id, "Deposit", amount)
        return True

    def withdraw(self, account, amount):
        if account.withdraw(amount) is False:
            return False
        self.accounts.update_balance(account.id, account.get_balance())
        self.transactions.create(account.id, "Withdrawal", amount)
        return True

    def change_pin(self, card, old_pin, new_pin):
        card_data = self.cards.find_by_number(card.card_number)
        if PinSecurity.verify_pin(old_pin, card_data["pin_hash"]) is False:
            return False
        if len(new_pin) != 4:
            return False
        if new_pin.isdigit() is False:
            return False
        new_hash = PinSecurity.hash_pin(new_pin)
        self.cards.update_pin(card.id, new_hash)
        return True

    def get_history(self, account):
        return self.transactions.get_history(account.id)
