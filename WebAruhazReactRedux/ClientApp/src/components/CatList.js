import React from 'react';
import { connect } from 'react-redux';

const ItemList = (props) => (
    <div className="card bg-dark text-light text-center col-3 rounded p-2 border-0 m-2">
        <a href="#" className="btn btn-block stretched-link text-light">
            <img src={props.picture} className="card-img rounded" />
            <div className="card-img-overlay">
            </div>
            <h3>asd</h3>
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