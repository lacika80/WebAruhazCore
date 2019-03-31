import React from 'react';
import {userActions} from '../_actions/user.actions'; 
import { connect } from 'react-redux'


class Register extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            user: {
                firstName: '',
                lastName: '',
                email: '',
                password: ''
            },
            reEmail: '',
            rePassword: ''
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e) {
        const { name, value } = e.target;
        if (name == "reEmail" || name == "rePassword") {
            this.setState({ [name]: value });
        }
        else {
            const { user } = this.state;
            this.setState({
                user: {
                    ...user,
                    [name]: value
                }


            })
        }
    }
    handleSubmit(e) {
        e.preventDefault();
        const {user, rePassword, reEmail} = this.state;
        if (user.password == rePassword && user.email == reEmail){
            if (user.firstName && user.lastName && user.password && user.email){
                const {dispatch} = this.props;
                dispatch(userActions.register(user));
            }
        }
        else{

        }
    }

    render() {
        const {user, rePassword, reEmail} = this.state;
        console.log(this.props.li)
        return (
            <div className="bg-light border border-dark rounded p-4">
                <form className="mx-5" onSubmit={this.handleSubmit}>
                    <label for="exampleInputEmail1">Name:</label>
                    <div className="form-row mb-5">
                        <div className="col mx-5">
                            <input type="text" className="form-control" id="fn" name="firstName" value={user.firstName} onChange={this.handleChange} placeholder="First name" />
                        </div>
                        <div className="col mx-5">
                            <input type="text" className="form-control" id="ln" name="lastName" value={user.lastName} onChange={this.handleChange} placeholder="Last name" />
                        </div>
                    </div>
                    <label for="exampleInputEmail1">Email address:</label>
                    <div className="form-row mb-5">
                        <div className="col mx-5">
                            <input type="text" className="form-control" name="email" value={user.email} onChange={this.handleChange} placeholder="E-mail" id="email" />
                        </div>
                        <div className="col mx-5">
                            <input type="text" className="form-control disabled" name="reEmail" value={reEmail} onChange={this.handleChange} placeholder="E-mail again" />
                        </div>
                    </div>
                    <label for="exampleInputEmail1">Password:</label>
                    <div className="form-row mb-5">
                        <div className="col mx-5">
                            <input type="text" className="form-control" name="password" value={user.password} onChange={this.handleChange} placeholder="Password" id="password" />
                            <small id="passwordHelpBlock" className="form-text text-muted ">
                                Your password must be 8-20 characters long, contain letters and numbers, special characters and must not contain spaces.
    </small>
                        </div>
                        <div className="col mx-5">
                            <input type="text" className="form-control disabled" name="rePassword" value={rePassword} onChange={this.handleChange} placeholder="Password again" />
                        </div>
                    </div>
                    <div className="form-row">
                        <div className="col mx-5">
                            {/* <input className="form-check-input px-5" type="checkbox" value="" id="chkbox" onclick="terms()" />
                            <label className="form-check-label" for="invalidCheck">
                                Agree to terms and conditions
    </label> */}
                        </div>
                        <div className="col mx-5">
                            <button className="btn btn-primary">Registration</button>
                        </div>
                    </div>
                </form>
            </div>
        )
    }
}

const mapStateToProps = (state) => {
    const { registering } = state.registration;
    return {
        registering,
        li: state.authentication.loggedIn
    };
}

const connectedRegisterPage = connect(mapStateToProps)(Register);
export {connectedRegisterPage as register};
export default connectedRegisterPage;