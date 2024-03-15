//Import necessary logos

import logo from './OIP.jpg';
import marlins from './MArlins.png';
import sharks from './shark.jpg';

//Create the function and allow it to be passed information.
function Header(props: any) {
  //Return the header with the logos and the title that has been passed in
  return (
    <header className="row header navbar-dark bg-primary">
      <div className="col-4">
        <img src={logo} alt="logo" width={150}></img>
        <img src={sharks} alt="sharks" width={150} height={150}></img>
      </div>
      <div className="col subtitle">
        <h1>{props.title}</h1>
        <br></br>
        <h2>The Bowling Finals</h2>
      </div>
      <div className="col-4">
        <img src={marlins} alt="marlins" width={150}></img>
        <img src={logo} alt="logo" width={150}></img>
      </div>
    </header>
  );
}

//Export the Header
export default Header;
