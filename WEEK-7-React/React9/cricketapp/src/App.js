import React from 'react';
import ListOfPlayers from './ListOfPlayers';
import IndianPlayers from './IndianPlayers';

function App() {
  const flag = false; // toggle to false to show IndianPlayers

  return (
    <div className="App">
      <h1>🏏 Cricket App</h1>
      {flag ? <ListOfPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
