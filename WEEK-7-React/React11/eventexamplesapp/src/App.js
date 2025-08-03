import React from 'react';
import Counter from './Counter';
import Welcome from './Welcome';
import SyntheticButton from './SyntheticButton';
import CurrencyConvertor from './CurrencyConvertor';

function App() {
  return (
    <div style={{ padding: '20px' }}>
      <h1>🎯 React Event Examples App</h1>
      <Counter />
      <Welcome />
      <SyntheticButton />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
