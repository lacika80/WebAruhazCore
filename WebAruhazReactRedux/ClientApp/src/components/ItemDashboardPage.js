import React from 'react';
import ItemList from './ItemList';
import picture from '../sources/asd.jpg'

const ItemDashboardPage = () => (
    <div className="py-3" style={{}}>
        <div className="bg-dark sticky-top rounded col-2 mx-5 float-left">
            <div className="list-group">
                <button type="button" className="list-group-item list-group-item-action active">
                    gombsor
                </button>

                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>
                <button type="button" className="list-group-item list-group-item-action">Kategória: @i</button>

            </div>

        </div>

        <div className=" bg-dark rounded d-flex justify-content-around flex-wrap pb-5 pt-3 mb-5 mr-5" >

            <ItemList picture={picture} />
            <ItemList picture={picture} />
            <ItemList picture={picture} />
            <ItemList picture={picture} />
            <ItemList picture={picture} />
            <ItemList picture={picture} />
            <ItemList picture={picture} />
           
        </div>
    </div>
    // <div>
    //     <ItemList />
    // </div>
);

export default ItemDashboardPage;