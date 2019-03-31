import React from 'react';
import { Container } from 'reactstrap';
// import NavMenu from './NavMenu';
import Header from './Header';
import Footer from './Footer';

export default props => (
  <div>
    <Header />
    {/*<NavMenu />*/}
    {/* <Container> */}
      {props.children}
    {/* </Container> */}
    <Footer />
  </div>
);
