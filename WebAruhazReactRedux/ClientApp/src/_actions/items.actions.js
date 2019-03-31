//add item - létrehozás sémája
export const addItem = (
    {
        description = '',
        name = '',
        price = 0,
        createdAt = 0
    } = {}
) => ({
    type: 'ADD_ITEM',
    item: {
        id: Math.floor(Math.random() * 100),
        name,
        description,
        price,
        createdAt
    }
});

//remove item
export const removeItem = ({ id } = {}) => ({
    type: 'REMOVE_ITEM',
    id
});

//edit item
export const editItem = (id, updates) => ({
    type: 'EDIT_ITEM',
    id,
    updates
});