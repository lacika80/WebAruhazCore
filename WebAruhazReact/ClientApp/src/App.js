import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { withCookies } from 'react-cookie';

class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path="/" render={() => (<Home cookies={this.props.cookies} />)} />
                {/*<Route exact path='/' component={Home} />*/}
                    <Route path='/counter' component={Counter} />
                    <Route path='/fetch-data' component={FetchData} />
                </Layout>
        );
    }
}
export default withCookies(App);

