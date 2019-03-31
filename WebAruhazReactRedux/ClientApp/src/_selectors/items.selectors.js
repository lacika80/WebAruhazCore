//get visible items
export default (items, { text, sortBy}) => {
    return items.filter((item) => {
        const textMatch = item.name.toLowerCase().includes(text.toLowerCase())
        return textMatch;
    }).sort((a, b) => {
        if (sortBy === 'name') {
            return a.name < b.name ? -1 : 1;
        } else if (sortBy === 'price') {
            return a.price < b.price ? -1 : 1;
        }
    });
};