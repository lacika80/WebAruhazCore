import React from 'react';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

import { userActions } from '../_actions/user.actions';


class LoginField extends React.Component {
    constructor(props) {
        super(props);
        this.props.dispatch(userActions.logout());

        //basic kezelők beállítása
        this.state = {
            email: '',
            password: '',
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }


    //ment minden karakter beütésnél... itt lehetne ellenőrizni
    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }


    //a submit rész
    handleSubmit(e) {
        e.preventDefault();

        const { email, password } = this.state;
        const { dispatch } = this.props;
        if (email && password) {
            dispatch(userActions.login(email, password));
        }
    }

    render() {
        const { email, password } = this.state;
        return (
            <div>
                <div className="d-inline-flex">
                    <Link to="/Register" className="btn btn-link text-secondary">registration</Link>
                    <p className="btn text-secondary my-auto" id="perbutton">/</p>
                    <button className="btn btn-link text-secondary" id="pwlink">Forgot your password?</button>
                    <form className="form-inline" name="form" onSubmit={this.handleSubmit}>


                        {/* <input type="text" name="username" value={username} onChange={this.handleChange} />
                    <input type="password" name="password" value={password} onChange={this.handleChange} /> */}

                        <div className="form-group">
                            <input type="text" className="form-control-sm p-2" id="email" name="email" value={email} onChange={this.handleChange} placeholder="email@example.com" />
                        </div>
                        <div className="form-group mx-sm-3">
                            <input type="password" className="form-control-sm" id="password" name="password" value={password} onChange={this.handleChange} placeholder="Password" />
                        </div>
                        <button className="btn btn-dark" id="loginButton">Login</button>
                    </form>
                </div>
            </div>

            /* <form className="form-inline" id="login-form" onSubmit={this.handleSubmit}>
                <button className="btn btn-link text-secondary" id="regbutton" onclick="Register()">registration</button>
                <p className="btn text-secondary my-auto" id="perbutton">/</p>
                <button className="btn btn-link text-secondary" id="pwlink">Forgot your password?</button>
                <div className="form-group">
                    <input type="text" className="form-control-sm p-2" id="email" value={username} onChange={this.handleChange} placeholder="email@example.com" />
                </div>
                <div className="form-group mx-sm-3">
                    <input type="password" className="form-control-sm" id="password" placeholder="Password" />
                </div>
                <button className="btn btn-dark" id="loginButton">Login</button>
            </form> */
        )
    }
}

function mapStateToProps(state) {
    return {
    };
}

const connectedLoginPage = connect(mapStateToProps)(LoginField);

export { connectedLoginPage as LoginField }

export default connectedLoginPage;