import axios from 'axios';
import { useState, useEffect } from 'react'
import { Header, List } from 'semantic-ui-react';
// import './App.css'

function App() {

  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activity')
      .then(response=>{
        setActivities(response.data);
      });

  }, []);

  return (
    <>
     <Header as='h2' icon='users' content='Reactivities'/>
     <List>
      {activities.map((item: any, index) => (
        <List.Item key={index}>{item.title}</List.Item>
      ))}
     </List>
    </>
  )
}

export default App
