import React, { Component } from 'react';

export class Users extends Component {
    static displayName = Users.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }

    componentDidMount() {
        this.populateUsers();
    }

    static renderUsersTable(forecasts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Users</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(user =>
                        <tr key={user.name}>
                            <td>{user.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Users.renderUsersTable(this.state.forecasts);

        return (
            <div>
                <h1 id="tabelLabel" >Abilities</h1>
                <p>This component shows users from PagerDuty.</p>
                {contents}
            </div>
        );
    }

    async populateUsers() {
        const response = await fetch('api/v1/users');
        const data = await response.json();
        this.setState({ forecasts: data, loading: false });
    }
}