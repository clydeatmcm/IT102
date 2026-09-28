class ATMSession:
    def __init__(self, session_id, card_id, login_status, created_at):
        self.id = session_id
        self.card_id = card_id
        self.login_status = login_status
        self.created_at = created_at
