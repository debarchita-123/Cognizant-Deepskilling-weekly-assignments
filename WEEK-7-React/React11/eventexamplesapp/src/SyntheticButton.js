import React from 'react';

function SyntheticButton() {
  const handlePress = (event) => {
    // 'event' is a SyntheticEvent object
    alert('I was clicked');
    console.log('Synthetic Event Object:', event);
    console.log('Event type:', event.type);
    console.log('Target:', event.target);
  };

  return (
    <div>
      <h2>Synthetic Event Example</h2>
      <button onClick={handlePress}>OnPress</button>
    </div>
  );
}

export default SyntheticButton;
