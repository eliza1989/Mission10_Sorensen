// import Bowlers and other necessary elements

import { useEffect, useState } from 'react';
import { Bowlers } from './types/Bowlers';

//Create the Bowler list function
function BowlerList() {
  //Create the useState to allow the use of Bowlers
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);

  //Create the useEffect to fetch data from the API and set that as the bowler data or a default emply array
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5145/bowlers');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  //Retrun the data captured in a table with the corresponding labels and data that has been pulled from the api
  return (
    <>
      <div className="row">
        <h4 className="text-center">
          List of bowlers in the SQL Bowling Finals
        </h4>
        <h2>Sharks VS. Marlins</h2>
        <br></br>
        <br></br>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler First Name</th>
            <th>Bowler Middle Initial</th>
            <th>Bowler Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zipcode</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.teamID}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.teamName?.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

//Export the bowler list
export default BowlerList;
