import React from 'react';

function App() {
  // Object for a single office
  const office = {
    name: 'SkyView Towers',
    rent: 75000,
    address: '123, Business Bay, Bengaluru'
  };

  // Array of office objects
  const officeSpaces = [
    { name: 'SkyView Towers', rent: 75000, address: '123, Business Bay, Bengaluru' },
    { name: 'GreenScape Plaza', rent: 50000, address: '9, IT Hub Road, Pune' },
    { name: 'TechZone Heights', rent: 95000, address: 'Plot 88, Cybercity, Hyderabad' },
    { name: 'Startup Nest', rent: 40000, address: 'Near Ring Road, Indore' }
  ];

  // JSX inline style logic
  const getRentStyle = (rent) => {
    return {
      color: rent < 60000 ? 'red' : 'green',
      fontWeight: 'bold'
    };
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>🏢 Office Space Rental App</h1>

      <img
        src="https://images.unsplash.com/photo-1528909514045-2fa4ac7a08ba" // Sample office image
        alt="Office Space"
        width="600"
        height="300"
        style={{ borderRadius: '8px', marginBottom: '20px' }}
      />

      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {office.name}</p>
      <p><strong>Address:</strong> {office.address}</p>
      <p><strong>Rent:</strong> <span style={getRentStyle(office.rent)}>₹{office.rent}</span></p>

      <h2>Available Office Spaces</h2>
      {officeSpaces.map((item, index) => (
        <div key={index} style={{ border: '1px solid #ccc', borderRadius: '5px', padding: '10px', margin: '10px 0' }}>
          <p><strong>Name:</strong> {item.name}</p>
          <p><strong>Address:</strong> {item.address}</p>
          <p><strong>Rent:</strong> <span style={getRentStyle(item.rent)}>₹{item.rent}</span></p>
        </div>
      ))}
    </div>
  );
}

export default App;
