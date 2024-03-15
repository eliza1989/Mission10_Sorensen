//import necessary files and packages

import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Header from './Header';
import BowlerList from './BowlerList';

//create the app function that passes in the header title and displays the Bowler list
function App() {
  return (
    <div className="App">
      <Header title="SQL Lanes" />
      <br></br>
      <br></br>
      <BowlerList />
    </div>
  );
}

//Export the app
export default App;
