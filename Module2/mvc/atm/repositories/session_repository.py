from repositories.database import get_supabase

class SessionRepository:
    def __init__(self):
        self.db = get_supabase()

    def create(self, card_id, login_status):
        data = {"card_id": card_id, "login_status": login_status}
        self.db.table("atm_sessions").insert(data).execute()
