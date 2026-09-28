class Transaction:
    def __init__(self, transaction_id, transaction_type, amount, created_at):
        self.id = transaction_id
        self.transaction_type = transaction_type
        self.amount = float(amount)
        self.created_at = created_at

    def display(self):
        return self.transaction_type + " | PHP " + format(self.amount, ",.2f") + " | " + str(self.created_at)
