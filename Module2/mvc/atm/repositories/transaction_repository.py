from repositories.database import get_supabase
from models.transaction import Transaction

class TransactionRepository:
    def __init__(self):
        self.db = get_supabase()

    def create(self, account_id, transaction_type, amount):
        data = {"account_id": account_id, "transaction_type": transaction_type, "amount": amount}
        self.db.table("transactions").insert(data).execute()

    def get_history(self, account_id):
        result = self.db.table("transactions").select("*").eq("account_id", account_id).order("created_at", desc=True).execute()
        transactions = []
        for row in result.data:
            item = Transaction(row["id"], row["transaction_type"], row["amount"], row["created_at"])
            transactions.append(item)
        return transactions
