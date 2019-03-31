import {userConstants} from '../_constants/user.constants';
import {userService} from '../_services/user.services';
import { history } from '../_helpers/history';
import {alertActions} from '../_actions/alert.actions';
import { Redirect } from 'react-router-dom';

export const userActions = {
    login,
    logout,
    register,
    //getOne
};

function login(username, password) {
    return dispatch => {
        //dispatch(request({ username }));  //kérés elküldésének jelzése az oldal felé... bezavarja az admin ellenörzést....

        //a service-ben történik meg aminek megkell
        userService.login(username, password)
            .then(
                user => { 
                    dispatch(success(user));
                    history.push('/');  //WTF? nem müxik...
                },
                error => {
                    dispatch(failure(error));
                    //dispatch(alertActions.error(error));
                }
            );
    };

    //reducernek menő dolgok.
    function request(user) { return { type: userConstants.LOGIN_REQUEST, user } }
    function success(user) { return { type: userConstants.LOGIN_SUCCESS, user } }
    function failure(error) { return { type: userConstants.LOGIN_FAILURE, error } }
}

function logout() {
    userService.logout();
    return { type: userConstants.LOGOUT };
}

function register(user) {
    return dispatch => {
        dispatch(request(user));

        userService.register(user)
            .then(
                () => { 
                    dispatch(success());
                    history.push('/');
                    //dispatch(alertActions.success('Registration successful'));
                },
                error => {
                    dispatch(failure(error));
                    //dispatch(alertActions.error(error));
                }
            );
    };

    function request(user) { return { type: userConstants.REGISTER_REQUEST, user } }
    function success(user) { return { type: userConstants.REGISTER_SUCCESS, user } }
    function failure(error) { return { type: userConstants.REGISTER_FAILURE, error } }
}