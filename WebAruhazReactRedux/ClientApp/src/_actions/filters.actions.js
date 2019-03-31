// sort by name
export const sortByName = () => ({
    type: 'SORT_BY_NAME'
});

export const sortByPrice = () => ({
    type: 'SORT_BY_PRICE'
});

// SET_TEXT_FILTER
export const setTextFilter = (text = '') => ({
    type: 'SET_TEXT_FILTER',
    text
  });