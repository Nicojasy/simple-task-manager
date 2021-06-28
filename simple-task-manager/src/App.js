import './App.css';
import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import Tasks from './Pages/Tasks';
import ExpiringTasks from './Pages/ExpiringTasks';

function App() {
    return (
        <Router>
            <div>
                <h2>Welcome to TaskManager</h2>
                <nav className="navbar navbar-expand-lg navbar-light bg-light">
                    <ul className="navbar-nav mr-auto">
                        <li><Link to={'/tasks'} className="nav-link">Tasks</Link></li>
                        <li><Link to={'/expiring-tasks'} className="nav-link">Expiring tasks</Link></li>
                    </ul>
                </nav>
                <hr />
                <Switch>
                    <Route path='/tasks'>
                        <Tasks/>
                    </Route>
                    <Route path='/expiring-tasks'>
                        <ExpiringTasks/>
                    </Route>
                </Switch>
            </div>
        </Router>
    );
}

export default App;
