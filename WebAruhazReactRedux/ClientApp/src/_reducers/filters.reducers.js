//filter reducer

const filtersReducerDefaultState = {
    text: '',
    sortBy: 'name',
    addDate: undefined,
};

export default (state = filtersReducerDefaultState, action) => {
    switch (action.type) {
        case 'SET_TEXT_FILTER':
            return {
            ...state,
            text: action.text
            };
        case 'SORT_BY_PRICE':
            return {
                ...state,
                sortBy: 'price'
            };
        case 'SORT_BY_NAME':
            return {
                ...state,
                sortBy: 'name'
            };
        default:
            return state;
    }
};