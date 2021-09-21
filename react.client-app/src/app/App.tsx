import React, { Fragment, useEffect, useState } from 'react';
import { Container, Header, Grid } from 'semantic-ui-react';
import axios from 'axios';
import Ticket from './models/ticket';
import NavBar from './layout/NavBar';
import TicketDashboard from '../features/tickets/dashboard/TicketDashboard'

function App() {
  const [tickets, setTickets] = useState<Ticket[]>([])

  useEffect(() => {
    axios.get<Ticket[]>('https://localhost:44373/api/tickets').then(response => {
      setTickets(response.data);
    });
  }, []);

  return (
    <Fragment>
      <header>
        <NavBar />
      </header>
      <main>
        <TicketDashboard tickets={tickets} />
      </main>
    </Fragment>
  );
}

export default App;
