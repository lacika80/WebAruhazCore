import React from 'react';

const Footer = () => {
    return (
        <div className="alert alert-dark fixed-bottom col-11 mx-auto text-center">
            <footer>
                <p>{(new Date().getFullYear())} - My ASP.NET Application</p>
                <p id="footer-text"></p>
            </footer>
        </div>
    )
}

export default Footer;