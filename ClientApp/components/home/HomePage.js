import React from 'react';
import {Link} from 'react-router-dom';

const HomePage = () => (
    <div className="jumbotron">
        <h1>Home title</h1>
        <p>React redux and react router in ES6</p>
        <Link to="about" className="btn btn-primary btn-lg">learn more</Link>
    </div>
);

export default HomePage;