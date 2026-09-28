import bcrypt

class PinSecurity:
    @staticmethod
    def hash_pin(pin):
        pin_bytes = pin.encode("utf-8")
        hashed = bcrypt.hashpw(pin_bytes, bcrypt.gensalt())
        return hashed.decode("utf-8")

    @staticmethod
    def verify_pin(pin, pin_hash):
        return bcrypt.checkpw(pin.encode("utf-8"), pin_hash.encode("utf-8"))
