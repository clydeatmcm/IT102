from models.database import get_database


def save_transaction(account_id, transaction_type, amount):
    db = get_database()
    if db is None:
        return False
    data = {
        "account_id": account_id,
        "transaction_type": transaction_type,
        "amount": amount
    }
    db.table("transactions").insert(data).execute()
    return True


def get_history(account_id):
    db = get_database()
    if db is None:
        return []
    response = db.table("transactions").select("*").eq("account_id", account_id).order("created_at", desc=True).execute()
    return response.data
