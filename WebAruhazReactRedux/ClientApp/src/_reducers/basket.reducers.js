//reducer - feldolgozza az adatot, de nem változtatja meg csak visszaad 1 változott állást. majd más elvégzi a véglegesítést
const basketReducerDefaultState = [];
export default (state = basketReducerDefaultState, action) => {
    switch (action.type) {
        case 'BASKET_ADD':
            return {};
        case 'BASKET_GET':
            return {};
        case 'BASKET_REMOVE':
            return {}; //state.filter(({ id }) => id !== action.id)
        case 'BASKET_EDIT':
            return {};//state.map((basket) => {
        //     if (basket.id === action.id) {
        //         return {
        //             ...basket,
        //             ...action.updates
        //         };
        //     } else {
        //         return basket
        //     }
        // })
        default:
            return state;
    }
};
