import { alertConstants } from '../_constants/alert.constants'

export const alertActions = {
    success,
    error,
    clear
};

const success = (message) => {
    return { type: alertConstants.SUCCESS, message };
}

const error = (message) => {
    return { type: alertConstants.ERROR, message };
}

const clear = (message) => {
    return { type: alertConstants.CLEAR, message };
}