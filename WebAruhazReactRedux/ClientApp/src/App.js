import React from 'react';
import { Route, Router } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
// import test from './redux-items';
import ItemDashboardPage from './components/ItemDashboardPage';
import Register from './components/Register';
import CatPage from './components/CategoryPage';
import ItemPage from './components/ItemPage';
import {history} from './_helpers/history';
import Statistics from './components/Statistics';
import AddProduct from './components/AddProduct';


export default () => (
    <Router history={history}>
    <Layout>
        {/* <Route exact path='/404' component={test}/> */}
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/Register' component={Register} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
        <Route path='/ItemDashboardPage' component={ItemDashboardPage} />
        <Route path='/CatPage' component={CatPage} />
        <Route path='/ItemPage/:id?' component={ItemPage} />
        <Route path='/AddProduct' component={AddProduct} />
        <Route path='/Statistics' component={Statistics} />
    </Layout>
    </Router>
);

