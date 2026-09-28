import os
import streamlit as st
from dotenv import load_dotenv
from supabase import create_client

load_dotenv()

def get_supabase():
    url = os.getenv("SUPABASE_URL")
    key = os.getenv("SUPABASE_KEY")

    if not url or not key:
        try:
            url = st.secrets["SUPABASE_URL"]
            key = st.secrets["SUPABASE_KEY"]
        except Exception:
            pass

    if not url or not key:
        raise ValueError("Supabase URL and KEY are missing. Check .env or secrets.toml.")

    return create_client(url, key)
