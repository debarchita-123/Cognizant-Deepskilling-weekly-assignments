import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const converted = (parseFloat(rupees) / 88).toFixed(2); // Approx 1 EUR = 88 INR
    setEuro(converted);
  };

  return (
    <div>
      <h2>Currency Converter</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Rupees:
          <input
            type="number"
            value={rupees}
            onChange={(e) => setRupees(e.target.value)}
            required
          />
        </label>
        <button type="submit">Convert</button>
      </form>
      {euro && <p>Euro: €{euro}</p>}
    </div>
  );
}

export default CurrencyConvertor;
