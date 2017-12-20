import React from 'react';
import { Switch, Route } from 'react-router-dom';
import Home from './home/HomePage';
import AboutPage from './about/AboutPage';
import CoursesPage from './course/CoursesPage';

const Main = () => (
  <main>
    <Switch>
      <Route exact path="/" component={Home}/>
      <Route path="/about" component={AboutPage}/>
      <Route path="/courses" component={CoursesPage}/>
    </Switch>
  </main>
);

export default Main;
