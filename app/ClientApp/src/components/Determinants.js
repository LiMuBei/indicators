import React, { Component } from 'react';

export class Determinants extends Component {
  displayName = Determinants.name

  constructor(props) {
    super(props);
    this.state = { 
      determinants: [],
      countries: [],
      loading: true };

    fetch('api/Countries')
      .then(response => response.json())
      .then(data => {
        this.setState({ countries: data.map(c => c.code) });
      });
    
    fetch('api/Determinants')
      .then(response => response.json())
      .then(data => {
        this.setState({ determinants: data, loading: false });
      });
  }

  static addDeterminants(event) {
    alert(event.target.value);
    console.log(event);
    event.preventDefault();
  }

  static renderForecastsTable(determinants, countries) {
    return (
      <div>
      <form onSubmit={Determinants.addDeterminants}>
      <table className='table'>
        <thead>
          <tr>
            <th>Name</th>
            <th>Year</th>
            <th>Country</th>
            <th>Technology</th>
            <th>Value</th>
            <th hidden="true">Add</th>
          </tr>
        </thead>
        <tbody>
          {determinants.map((determinant, i) =>
            <tr key={i}>
              <td>{determinant.name}</td>
              <td>{determinant.year}</td>
              <td>{determinant.country.code}</td>
              <td>{determinant.technology}</td>
              <td>{determinant.value}</td>
              <td hidden="true"></td>
            </tr>
          )}
          <tr key={determinants.length}>
          <td><input id="inputName"/></td>
          <td><input id="inputYear"/></td>
          <td>
            <select>
              {countries.map((country, i) =>
                <option value={country} key={i}>{country}</option>
              )}
            </select>
          </td>
          <td><input id="inputTechnology"/></td>
          <td><input id="inputValue"/></td>
          <td><input type="submit" className="btn btn-primary" onClick={Determinants.addDeterminants} value="+"/></td>
          </tr>
        </tbody>
      </table>
      </form>
      <p>Showing {determinants.length} entries</p>
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Determinants.renderForecastsTable(this.state.determinants, this.state.countries);

    return (
      <div>
        <h1>Determinants</h1>
        {contents}
      </div>
    );
  }
}
