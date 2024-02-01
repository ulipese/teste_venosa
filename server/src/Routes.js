import React from 'react';
import Colors from './Colors';
import Home from './Home';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

const AppRoutes = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />}></Route>
        <Route path="/colors" element={<Colors />}></Route>
      </Routes>
    </Router>
  );
};

export default AppRoutes;
