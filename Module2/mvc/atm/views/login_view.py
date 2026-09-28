import streamlit as st

def show_login(controller):
    st.title("ATM Kiosk")
    st.write("Insert your ATM card details to continue.")

    card_number = st.text_input("Card Number")
    pin = st.text_input("4-Digit PIN", type="password", max_chars=4)

    if st.button("Enter ATM", use_container_width=True):
        data = controller.login(card_number, pin)
        if data is None:
            st.error("Invalid card number or PIN.")
            return
        st.session_state.atm_data = data
        st.rerun()
