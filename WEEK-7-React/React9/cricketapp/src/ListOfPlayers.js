
import React from 'react';

const ListOfPlayers = () => {
  const players = [
    { name: 'Player 1', score: 85 },
    { name: 'Player 2', score: 60 },
    { name: 'Player 3', score: 45 },
    { name: 'Player 4', score: 78 },
    { name: 'Player 5', score: 52 },
    { name: 'Player 6', score: 88 },
    { name: 'Player 7', score: 33 },
    { name: 'Player 8', score: 91 },
    { name: 'Player 9', score: 44 },
    { name: 'Player 10', score: 76 },
    { name: 'Player 11', score: 69 },
  ];

  
  const playerList = players.map((player, index) => (
    <li key={index}>{player.name} - Score: {player.score}</li>
  ));

 
  const below70 = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>{playerList}</ul>
      <h2>Players with Score Below 70:</h2>
      <ul>
        {below70.map((p, i) => <li key={i}>{p.name} - Score: {p.score}</li>)}
      </ul>
    </div>
  );
};

export default ListOfPlayers;
