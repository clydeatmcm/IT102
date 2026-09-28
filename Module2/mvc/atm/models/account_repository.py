from models.database import get_database


def find_account(account_number):
    db = get_database()
    if db is None:
        return None
    response = db.table("accounts").select("*").eq("account_number", account_number).execute()
    if len(response.data) == 0:
        return None
    return response.data[0]


def update_balance(account_id, balance):
    db = get_database()
    if db is None:
        return False
    db.table("accounts").update({"balance": balance}).eq("id", account_id).execute()
    return True


def update_pin(account_id, pin_hash):
    db = get_database()
    if db is None:
        return False
    db.table("accounts").update({"pin_hash": pin_hash}).eq("id", account_id).execute()
    return True
