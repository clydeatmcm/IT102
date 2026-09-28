from repositories.database import get_supabase

class AccountRepository:
    def __init__(self):
        self.db = get_supabase()

    def create(self, customer_id, account_number, account_type, balance):
        data = {"customer_id": customer_id, "account_number": account_number, "account_type": account_type, "balance": balance}
        result = self.db.table("accounts").insert(data).execute()
        return result.data[0]

    def find_by_id(self, account_id):
        result = self.db.table("accounts").select("*").eq("id", account_id).execute()
        if len(result.data) == 0:
            return None
        return result.data[0]

    def update_balance(self, account_id, balance):
        self.db.table("accounts").update({"balance": balance}).eq("id", account_id).execute()
