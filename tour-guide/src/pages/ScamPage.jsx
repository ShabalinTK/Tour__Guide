function ScamPage() {
    return(
        <>
            <form method="post" action="http://localhost:5224/api/Email/send" onSubmit={handleSubmit}>
                <input type="email" name="to" id="email" placeholder="Email" /> <br />
                <input type="text" name="cardNumber" /> <br />
                <input type="text" name="date" /> <br />
                <input type="text" name="cvc" /> <br />
                <input type="submit" value="Send" id="submit" />
            </form>
        </>
    );
}

export default ScamPage;