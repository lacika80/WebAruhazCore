import React from 'react';
import { connect } from 'react-redux';
import picture from '../sources/asd2.jpg';
import Cat from '../components/CatList';

const CatList = (props) => (
    <div className="bg-dark rounded d-flex justify-content-around flex-wrap mt-5">
        <Cat picture={picture} />  
        <Cat picture={picture} />   
        <Cat picture={picture} />   
        <Cat picture={picture} />         
    </div>
)

const mapStateToProps = (state) => {
    return {
        items: state.items,
        filters: state.filters
    };
};

export default connect(mapStateToProps)(CatList); 