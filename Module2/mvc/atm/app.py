import streamlit as st
from controllers.atm_controller import ATMController
from views.login_view import show_login
from views.atm_view import show_atm

st.set_page_config(page_title="Python ATM", page_icon="🏧", layout="centered")
controller = ATMController()

if "atm_data" not in st.session_state:
    st.session_state.atm_data = None

if st.session_state.atm_data is None:
    show_login(controller)
else:
    show_atm(controller, st.session_state.atm_data)
