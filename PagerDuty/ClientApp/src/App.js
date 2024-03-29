import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Abilities } from './components/Abilities';
import { Users } from './components/Users';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/abilities' component={Abilities} />
                <Route path='/fetch-data' component={FetchData} />
                <Route path='/users' component={Users} />
            </Layout>
        );
    }
}