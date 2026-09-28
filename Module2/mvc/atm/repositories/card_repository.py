from repositories.database import get_supabase

class CardRepository:
    def __init__(self):
        self.db = get_supabase()

    def create(self, account_id, card_number, pin_hash):
        data = {"account_id": account_id, "card_number": card_number, "pin_hash": pin_hash, "is_active": True}
        result = self.db.table("atm_cards").insert(data).execute()
        return result.data[0]

    def find_by_number(self, card_number):
        result = self.db.table("atm_cards").select("*").eq("card_number", card_number).execute()
        if len(result.data) == 0:
            return None
        return result.data[0]

    def update_pin(self, card_id, pin_hash):
        self.db.table("atm_cards").update({"pin_hash": pin_hash}).eq("id", card_id).execute()
