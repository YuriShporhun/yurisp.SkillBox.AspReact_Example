import React, { Fragment, useEffect, useState } from 'react';
import { Container, Header, Grid } from 'semantic-ui-react';
import axios from 'axios';
import Ticket from './models/trip';
import NavBar from './layout/NavBar';
import TicketDashboard from '../features/trips/dashboard/TripDashboard'

function App() {
  const [trips, setTrips] = useState<Ticket[]>([])

  useEffect(() => {
    axios.get<Ticket[]>('https://localhost:44373/api/tickets').then(response => {
      setTrips(response.data);
    });
  }, []);

  return (
    <Fragment>
      <header>
        <NavBar />
      </header>
      <main>
        <TicketDashboard trips={trips} />
      </main>
      <footer>

      </footer>
    </Fragment>
  );
}

export default App;
