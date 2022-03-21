import {Typography, Button, List} from "@mui/material"
import { Component } from "react"

export default class UserStories extends Component{

    render(){
    return(
        <>
        <Typography sx={{ mt: 4, mb: 2, color: (theme) => theme.palette.common.white }} variant="h6" component="div">       
        <List>
            1. Routing of pages<br></br>
            2. Lifecycle hooks explore and implement<br></br>
            3. State management<br></br>
            4. Redux<br></br>
            5. Webpack<br></br>
            6. Deployment AWS
            7. Cognito for authentication
        </List>
        <Button href="/"> BACK </Button>
        </Typography>
        </>
    );
    }
}