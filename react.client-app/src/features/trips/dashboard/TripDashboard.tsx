import {Grid, List} from 'semantic-ui-react'
import Trip from '../../../app/models/trip'

interface Props {
    trips: Trip[];
}

export default function TripDashBoard({trips} : Props) {
    return (
        <Grid>
            <Grid.Column>
                <List>
                    {trips.map(trip =>(
                        <List.Item key={trip.id}>
                            {trip.from}
                        </List.Item>
                    ))}
                </List>
            </Grid.Column>
        </Grid>
    )
}