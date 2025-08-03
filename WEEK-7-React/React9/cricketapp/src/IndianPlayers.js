
import React from 'react';

const IndianPlayers = () => {
  const T20Players = ['Player A', 'Player B', 'Player C', 'Player D', 'Player E'];
  const RanjiPlayers = ['Player F', 'Player G', 'Player H', 'Player I', 'Player J'];

  const mergedPlayers = [...T20Players, ...RanjiPlayers];

  const evenPlayers = mergedPlayers.filter((_, index) => index % 2 === 0);
  const oddPlayers = mergedPlayers.filter((_, index) => index % 2 !== 0);

  return (
    <div>
      <h2>Even Team Players:</h2>
      <ul>{evenPlayers.map((p, i) => <li key={i}>{p}</li>)}</ul>
      <h2>Odd Team Players:</h2>
      <ul>{oddPlayers.map((p, i) => <li key={i}>{p}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;
