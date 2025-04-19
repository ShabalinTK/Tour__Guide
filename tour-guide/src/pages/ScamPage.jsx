function ScamPage() {
    return(
        <>
            <form method="post" action="https://localhost:7199/api/Email/send">
                <input type="email" name="to" id="to" placeholder="Email" /> <br />
                <input type="submit" value="Send" id="submit" />
            </form>
        </>
    );
}

export default ScamPage;