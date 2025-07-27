import React from 'react';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <h1>Welcome to the Student Score Calculator</h1>
      <CalculateScore 
        name="John Doe" 
        school="Greenwood High School" 
        total={450} 
        goal={5} 
      />
    </div>
  );
}

export default App;
