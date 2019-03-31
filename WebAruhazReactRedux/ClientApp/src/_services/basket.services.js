import React from 'react';
export const basketService = {
    add,
    get,
    remove,
    edit,
};

function add(basketitem) {
    const all = [];
    all.push(basketitem);

    const asd = JSON.parse(localStorage.getItem('basket'));
    for (let i = 0; i < asd.length; i++) {
        all.push(asd[i]);
    }

    localStorage.setItem('basket', JSON.stringify(all));
}

function remove(basket) {
    localStorage.setItem('basket', JSON.stringify(basket));
}

function edit(basket) {
    remove(basket);
}

function get() {
    return (
        JSON.parse(localStorage.getItem('basket'))
    )
}