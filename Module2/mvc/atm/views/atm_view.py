import streamlit as st

def show_atm(controller, data):
    account = data["account"]
    customer = data["customer"]
    card = data["card"]

    st.title("ATM Kiosk")
    st.write("Welcome, " + customer.full_name)
    st.caption(account.account_type + " Account | " + account.account_number)

    menu_items = ["Balance", "Deposit", "Withdraw", "Change PIN", "History"]
    menu = st.radio("Select Transaction", menu_items, horizontal=True)

    if menu == "Balance":
        st.subheader("Balance Inquiry")
        st.metric("Available Balance", "PHP " + format(account.get_balance(), ",.2f"))

    elif menu == "Deposit":
        st.subheader("Deposit")
        amount = st.number_input("Deposit Amount", min_value=0.0, step=100.0)
        if st.button("Deposit Money"):
            if controller.deposit(account, amount):
                st.success("Deposit successful.")
                st.write("New Balance: PHP " + format(account.get_balance(), ",.2f"))
            else:
                st.error("Enter a valid amount.")

    elif menu == "Withdraw":
        st.subheader("Withdraw")
        amount = st.number_input("Withdrawal Amount", min_value=0.0, step=100.0)
        if st.button("Withdraw Money"):
            if controller.withdraw(account, amount):
                st.success("Please take your cash.")
                st.write("Remaining Balance: PHP " + format(account.get_balance(), ",.2f"))
            else:
                st.error("Invalid amount or insufficient balance.")

    elif menu == "Change PIN":
        st.subheader("Change PIN")
        old_pin = st.text_input("Current PIN", type="password", max_chars=4)
        new_pin = st.text_input("New 4-Digit PIN", type="password", max_chars=4)
        if st.button("Update PIN"):
            if controller.change_pin(card, old_pin, new_pin):
                st.success("PIN changed successfully.")
            else:
                st.error("PIN change failed.")

    elif menu == "History":
        st.subheader("Transaction History")
        history = controller.get_history(account)
        if len(history) == 0:
            st.info("No transactions yet.")
        else:
            for transaction in history:
                st.write(transaction.display())

    st.divider()
    if st.button("Logout"):
        st.session_state.atm_data = None
        st.rerun()
