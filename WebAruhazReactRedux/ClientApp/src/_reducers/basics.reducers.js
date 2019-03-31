const basicsReducerDefaultState = {
   
};

export default (state = basicsReducerDefaultState, action) => {
    switch (action.type) {
        case 'SET_ADMIN':
            return {
                ...state,
                text: action.text
            };
        case 'SET_LOGIN':
            return {
                ...state,
                text: action.text
            };
        case 'SET_LBUTTON':
            return {
                ...state,
                text: action.text
            };
        default:
            return state;
    }
};