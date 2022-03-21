import React, { Component } from 'react';
import ListItem from '@mui/material/ListItem';
import { List, Typography, Box, IconButton, ListItemButton, ListItemText, Button, Link } from '@mui/material';
import CommentIcon from '@mui/icons-material/Comment';
import BlogContent from '../BlogContent';
import UserStories from '../UserStories';

interface IProps {
}

interface IState {
    items?: Blog[];
    dataisLoaded: boolean;
    contentDataisLoaded: boolean;
    content: Blog;
}

interface Blog {
    blogpostid: number;
    title: string;
    body: string;
    blogComment: BlogComment[]
}

interface BlogComment {
    commentid: number;
    comment: string;
}

export class Home extends React.Component<IProps, IState> {

    constructor(props: IProps) {
        super(props);
        console.log(props);
        this.state = {
            items: [],
            dataisLoaded: false,
            contentDataisLoaded: false,
            content: { blogpostid: 0, blogComment: [], title: "", body: "" }
        };
    }

    componentDidMount() {
        fetch(
            "https://localhost:5001/v1/blogposts")

            .then((res) => res.json())
            .then((json) => {
                this.setState({
                    items: json,
                    dataisLoaded: true
                });
            })
    }

    getBlog = (id: number) => {
        fetch(
            `https://localhost:5001/v1/blogposts/${id}`)

            .then((res) => res.json())
            .then((json) => {
                this.setState({
                    content: json,
                    contentDataisLoaded: true
                });
            })
    }

    render() {
        const { contentDataisLoaded, dataisLoaded, items } = this.state;
        let blogs = items?.map((item) =>
            <>
                <ListItem
                    key={item.blogpostid}
                    secondaryAction={
                        <IconButton>
                            <Box sx={{ fontSize: (theme) => theme.typography.fontSize }}>{item.blogComment.length}</Box> <CommentIcon />
                        </IconButton>
                    }>
                    <Button onClick={() => this.getBlog(item.blogpostid)}>
                        <ListItemText sx={{color:(theme) => theme.palette.common.white}} primary={`${item.blogpostid}.  ${item.title}`} />
                    </Button>
                </ListItem>
            </>
        );
        if (!dataisLoaded) return <div>
            <h1> Pleses wait some time.... </h1> </div>;

        if (contentDataisLoaded) return <BlogContent body={this.state.content.body} blogComment={this.state.content.blogComment}
            blogpostid={this.state.content.blogpostid} title={this.state.content.title} />
        return (
            <>
                <Typography sx={{ mt: 4, mb: 2, color: (theme) => theme.palette.common.white }} variant="h6" component="div">
                    <h1> Food Blog </h1>
                    <List>{blogs}</List>                    
                </Typography>
            </>

        )
    }
}

export default Home;