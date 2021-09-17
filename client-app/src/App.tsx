import React, { Fragment, useEffect, useState } from 'react';
import { Container, Header, Grid } from 'semantic-ui-react';
import axios from 'axios';
import './App.css';

function App() {
  const [tickets, setTickets] = useState([])
  useEffect(() => {
    axios.get('https://localhost:44373/api/tickets').then(response => {
      console.log(response)
      setTickets(response.data);
    });
  }, []);

  return (
    <div>
      <Header as='h1' content='YuriSp Avia' icon='plane' className='main-page__header'/>
      <Container>
        <Header as='h2' content='Найдем лучшие туры'/>
        <Grid columns={4}>
          <Grid.Row></Grid.Row>
        </Grid>
      </Container>
    </div>
  );
}

export default App;
