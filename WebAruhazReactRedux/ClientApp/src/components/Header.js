import React, { Component } from 'react';
import LoginField from './LoginField';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';

import { userActions } from '../_actions/user.actions';
import { basketActions, addBasket } from '../_actions/basket.actions';

class Header extends Component {

    constructor(props) {
        super(props);
        this.state = {
            lb: false,
            username: '',
            password: '',
            submitted: false
        }
        this.handleChange = this.handleChange.bind(this);
    }

    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }


    render() {
        const { user } = this.props;
        const { dispatch } = this.props;
        //dispatch(basketActions.add(3, 2));
        //dispatch(basketActions.add(2, 1));
        const basket = JSON.parse(localStorage.getItem('basket'))
        return (
            <nav className="navbar-br navbar navbar-dark bg-dark navbar-width-60pc navbar-expand-lg" id="header">
                <div className="collapse navbar-collapse">
                    <div className="d-inline-flex justify-content-between w-100">
                        <div className="">
                            <div className="d-inline">
                                {/* <button type="button" className="btn btn-dark" onClick="MPage()">Main page</button> */}
                                <Link to="/" className="btn btn-dark">Main page</Link>
                                <button type="button" className="btn btn-dark" id="browsing" onClick="ItemList()">Contact</button>
                                {/* <button type="button" className="btn btn-dark" id="browsing" onClick="ItemList()">Böngészés</button> */}
                                <Link to="/ItemDashboardPage" className="btn btn-dark">Böngészés</Link>
                                {user ? user.isAdmin ? <p className="d-inline"><Link to="/AddProduct" className="btn btn-dark">AddProduct</Link></p> : "" : ""}
                                {user ? user.isAdmin ? <p className="d-inline"><Link to="/Statistics" className="btn btn-dark">Statistics</Link></p> : "" : ""}
                            </div>
                            <div className="d-inline float-right pl-3 ml-3">
                                <div className="form-inline">

                                    <input className="form-control mr-3 my-auto" type="text" placeholder="Search" />
                                    <button className="btn btn-outline-light my-auto">Search</button>
                                </div>
                            </div>

                        </div>

                        <div className="my-auto">
                            {user ? <div className="my-auto d-none d-xl-block"><h5 style={{ color: 'grey' }} className="d-inline my-auto">Welcome back {user.username}</h5></div> : ""}
                        </div>
                        <div id="rightSide" className="d-inline-flex justify-content-end">
                            {this.props.li ?  //bevan jelentkezve?
                                <div className="d-inline">
                                    <button type="button" className="btn btn-dark" id="browsing" onClick={() => { this.props.dispatch(userActions.logout()) }}>logout</button>
                                </div>

                                :

                                <div id="login" className="d-inline-flex">
                                    {this.state.lb ?  //login button vagy field van?
                                        <LoginField />

                                        :

                                        <div>

                                            <Link to="/Register" className="btn btn-dark">registration</Link>
                                            <p className="btn btn-dark my-auto disabled" id="perbutton">/</p>
                                            <button className="btn btn-dark" id="loginButton" onClick={() => {
                                                this.setState({
                                                    lb: !this.state.lb
                                                })
                                            }}>Login</button>
                                        </div>}

                                </div>}

                            <button type="button" className="btn btn-dark">Basket {basket ? "" : "(0)"}</button>
                        </div>
                    </div>
                </div>
            </nav>
        )
    }
}



function mapStateToProps(state) {
    const { user } = state.authentication
    return {
        li: state.authentication.loggedIn,
        user
    };
}
const connectedHeader = connect(mapStateToProps)(Header)

export { connectedHeader as LoginField }

export default connectedHeader;