import React from 'react';

function BookDetails({ books }) {
  return (
    <>
      {books.map((book, index) => (
        <div key={index}>
          <h2>{book.name}</h2>
          <p>{book.price}</p>
        </div>
      ))}
    </>
  );
}

export default BookDetails;
