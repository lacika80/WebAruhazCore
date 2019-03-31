import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            session: [],

            isLoading: false,
        };
    }

    componentDidMount() {
        this.setState({ isLoading: true });
        fetch('api/User/GetSession')
            .then(response => response.json())
            .then(data => this.setState({ session: data.session, isLoading: false  }));
    }

    render() {
        const { session } = this.state;
        return (
            <div>
                {session.map(hit =>
                    <p key={hit.objectID}>{hit.Name}>{hit.title}
                    </p>
                )}
            </div>
        );
    }
}

