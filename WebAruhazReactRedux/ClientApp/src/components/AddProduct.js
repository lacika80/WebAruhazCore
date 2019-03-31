import React, { Component } from 'react';
import { connect } from 'react-redux';

class AddProduct extends Component {
  constructor(props) {
    super(props);
  }
  render() {
    return (
      <div className="rounded mt-5 mb-5 pb-5" style={{ backgroundColor: "rgba(120, 120, 120, 0.2)" }}>
        <form>
          <div className="d-fluid text-center mb-5">
            <h3 className="">termék neve</h3>
            <input type="text" className="col-3" id="prodName" />
          </div>
          <div className="row">
            <div className="col-8 text-center">
              <div className="d-inline-flex">
                <image alt="mainCatImage" className="m-5" style={{ width: "10rem", height: "10rem", backgroundColor: '#ffffff' }} />
                <select className="custom-select" size="10" style={{ width: "20rem" }} id="fő kat kiválasztó">
                  <option value='1'>asd1</option>
                  <option value='2'>asd2</option>
                  <option value='3'>asd3</option>
                  <option value='4'>asd4</option>
                  <option value='5'>asd5</option>
                  <option value='6'>asd6</option>
                </select>
                <div className="ml-5">
                  <div>
                    <input type="text" id="uj kat bevitele" />
                  </div>
                  <div>
                    <input type="image" className="mt-3" style={{ width: "10rem", height: "10rem" }} id="mainCatBevImage" />
                  </div>
                </div>
                <div>
                  <input type="button" id="catfelvétel" className="btn btn-primary ml-1 mt-5" value="Kategória felvétele" />
                </div>
              </div>
              <div className="block" style={{ position: 'absolute', bottom: "0px", width: "100%" }}>
                <input type="button" id="filterExpand" value="Filterek beállítása" className="btn btn-primary w-100" />
              </div>
            </div>
            <div className="col-3 text-center">
              <input type="text" style={{ minHeight: "30rem", width: "20rem" }}></input>
            </div>
          </div>
          <div className="d-flex justify-content-around">
            <div className="d-inline-flex">
              <div className="d-flex">
                <image alt="mainProductImage" className="mt-5" style={{ width: "16rem", height: "10rem", backgroundColor: '#ffffff' }} id="mainProductImage" />
              </div>
              <div>
                <div className="d-flex">
                  <image alt="ProdImage" className="mt-5 mx-5" style={{ width: "24rem", height: "15rem", backgroundColor: '#ffffff' }} id="ProdImage" />
                </div>
                <div className="d-flex">
                  <image alt="p1" className="m-5" style={{ width: "8rem", height: "5rem", backgroundColor: '#ffffff' }} id="p1" />
                  <image alt="p2" className="m-5" style={{ width: "8rem", height: "5rem", backgroundColor: '#ffffff' }} id="p2" />
                  <image alt="p3" className="m-5" style={{ width: "8rem", height: "5rem", backgroundColor: '#ffffff' }} id="p3" />
                </div>
              </div>

            </div>
            <div className="">
              <input type="file" />
              <input type="file" />
            </div>
          </div>
        </form>
      </div>
    )
  }

}

const mapStateToProps = (state) => {
  return {
  };
};

export default connect(mapStateToProps)(AddProduct); 