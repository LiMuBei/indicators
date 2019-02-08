import React, { Component } from 'react';

export class FetchData extends Component {
  displayName = FetchData.name

  constructor(props) {
    super(props);
    this.state = { determinants: [], loading: true };

    fetch('api/Determinants')
      .then(response => response.json())
      .then(data => {
        this.setState({ determinants: data, loading: false });
      });
  }

  static renderForecastsTable(determinants) {
    return (
      <div>
      <table className='table'>
        <thead>
          <tr>
            <th>Name</th>
            <th>Year</th>
            <th>Country</th>
            <th>Technology</th>
            <th>Value</th>
          </tr>
        </thead>
        <tbody>
          {determinants.map((determinant, i) =>
            <tr key={i}>
              <td>{determinant.name}</td>
              <td>{determinant.year}</td>
              <td>{determinant.country}</td>
              <td>{determinant.technology}</td>
              <td>{determinant.value}</td>
            </tr>
          )}
        </tbody>
      </table>
      <p>Showing {determinants.length} entries</p>
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.determinants);

    return (
      <div>
        <h1>Determinants</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
