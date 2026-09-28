class Account:
    def __init__(self, account_id, customer_id, account_number, account_type, balance):
        self.id = account_id
        self.customer_id = customer_id
        self.account_number = account_number
        self.account_type = account_type
        self._balance = float(balance)

    def get_balance(self):
        return self._balance

    def deposit(self, amount):
        if amount <= 0:
            return False
        self._balance = self._balance + amount
        return True

    def withdraw(self, amount):
        if amount <= 0:
            return False
        if amount > self._balance:
            return False
        self._balance = self._balance - amount
        return True
