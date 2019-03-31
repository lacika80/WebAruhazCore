import { basketConstants } from '../_constants/basket.constants';
import { basketService } from '../_services/basket.services';

export const basketActions = {
    add,
    get,
    remove,
    edit,
};

function add(id, piece) {
    basketService.add({ id, piece });
    return { type: basketConstants.BASKET_ADD };
};

const get = () => {
    basketService.get();
    return { type: basketConstants.BASKET_GET };
}

const remove = (basket) => {
    basketService.remove(basket);
    return { type: basketConstants.BASKET_REMOVE };
}

const edit = (basket) => {
    basketService.edit(basket);
    return { type: basketConstants.BASKET_EDIT };
}


function success(basket) { return { type: basketConstants.BASKET_ADD_SUCCESS, basket } }
function failure(error) { return { type: basketConstants.BASKET_ADD_FAILURE, error } }