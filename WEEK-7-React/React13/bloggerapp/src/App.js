// src/App.js
import React, { useState } from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';
import { books } from './data/booksData';

function App() {
  const [showCourse, setShowCourse] = useState(true);
  const [showBlog, setShowBlog] = useState(true);
  const [showBooks, setShowBooks] = useState(true);

  return (
    <div>
      {/* Toggle Buttons */}
      <div style={{ margin: '20px' }}>
        <button onClick={() => setShowCourse(!showCourse)}>Toggle Course</button>
        <button onClick={() => setShowBlog(!showBlog)}>Toggle Blog</button>
        <button onClick={() => setShowBooks(!showBooks)}>Toggle Book</button>
      </div>

      {/* Flex container for equal-height columns */}
      <div className="container">
        {showBooks && (
          <div className="st2">
            <h1>Book Details</h1>
            <BookDetails books={books} />
          </div>
        )}

        {showBlog && (
          <div className="mystyle1">
            <h1>Blog Details</h1>
            <BlogDetails />
          </div>
        )}

        {showCourse && (
          <div className="v1">
            <h1>Course Details</h1>
            <CourseDetails />
          </div>
        )}
      </div>
    </div>
  );
}

export default App;
