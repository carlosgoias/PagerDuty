import React, { Component } from 'react';

export class Abilities extends Component {
    static displayName = Abilities.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }

    componentDidMount() {
        this.populateAbilities();
    }

    static renderAbilitiesTable(forecasts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Abilities</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(ability =>
                        <tr key={ability}>
                            <td>{ability}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Abilities.renderAbilitiesTable(this.state.forecasts);

        return (
            <div>
                <h1 id="tabelLabel" >Abilities</h1>
                <p>This component shows abilities from PagerDuty.</p>
                {contents}
            </div>
        );
    }

    async populateAbilities() {
        const response = await fetch('api/v1/abilities');
        const data = await response.json();
        this.setState({ forecasts: data, loading: false });
    }
}