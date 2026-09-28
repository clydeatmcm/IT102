import os
import streamlit as st
from dotenv import load_dotenv
from supabase import create_client


def get_database():
    load_dotenv()

    url = os.getenv("SUPABASE_URL")
    key = os.getenv("SUPABASE_KEY")

    if not url or not key:
        try:
            url = st.secrets["SUPABASE_URL"]
            key = st.secrets["SUPABASE_KEY"]
        except Exception:
            return None

    return create_client(url, key)
