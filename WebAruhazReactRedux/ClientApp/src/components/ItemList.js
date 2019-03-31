import React from 'react';
import { connect } from 'react-redux';

const ItemList = (props) => (
    <div className="card bg-light text-center mb-3" style={{width: '25rem'}}>
 <a href="#" className="btn text-secondary">
        <img className="card-img-top p-1" src={props.picture} alt="Card image cap" />
        <div className="card-body">
            <h5 className="card-title">@item.ProdName</h5>
            <div>
            <a href="#" className="btn btn-primary">
                @item.Brut.Length - 6) Ft
                </a>
            </div>
        </div>
        </a>
    </div>
)


const mapStateToProps = (state) => {
    return {
        items: state.items,
        filters: state.filters
    };
};

export default connect(mapStateToProps)(ItemList); 