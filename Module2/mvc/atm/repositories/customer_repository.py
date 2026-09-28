from repositories.database import get_supabase

class CustomerRepository:
    def __init__(self):
        self.db = get_supabase()

    def create(self, full_name, email):
        result = self.db.table("customers").insert({"full_name": full_name, "email": email}).execute()
        return result.data[0]

    def find_by_id(self, customer_id):
        result = self.db.table("customers").select("*").eq("id", customer_id).execute()
        if len(result.data) == 0:
            return None
        return result.data[0]
