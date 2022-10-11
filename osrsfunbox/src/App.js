import logo from './logo.svg';
import './App.css';

function App() {

  const url = "https://localhost:7033/api/osrs";
  
  const getData = async () => {
    const data = await fetch(url);
    const parsed = await data.json();

    console.log(parsed);
    return parsed;
  }

  const snapdragon = getData();

  console.log(snapdragon.Name)

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
