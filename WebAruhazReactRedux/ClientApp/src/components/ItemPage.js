import React from 'react';
import { connect } from 'react-redux';
import picture from '../sources/asd2.jpg';

const ItemPage = (props) => (
    <div className="container-fluid bg-dark text-light text-center py-5 my-5">
        <div>
            <img src={picture} className="card-img rounded col-7" />
            <h2>Egy új dns lánc</h2>
            <p>hát öhm... <br /> erről sokat nem tok irni</p>
            <button className="btn btn-primary">Kosárba rakás - 1500M Ft.</button>
        </div>
    </div>
)


const mapStateToProps = (state) => {
    return {
        items: state.items,
        filters: state.filters
    };
};

export default connect(mapStateToProps)(ItemPage); 