import React, { Component } from 'react';
import {Button} from '@mui/material';

interface Blog {
    blogpostid: number;
    title: string;
    body:string;
    blogComment: BlogComment[]
}

interface BlogComment {
    commentid: number;
    comment: string;
}

export default function BlogContent({blogComment,blogpostid,body,title}:Blog){
        return(
            <>
            <h1>{title}</h1>
            <hr></hr>
            <p>{body}</p>
            <Button href="/"> BACK </Button>
            </>
        );
}
