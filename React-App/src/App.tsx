import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Home from './Component/Home/index';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Layout from './Component/Layout/layout';
import globalTheme from './Theme/global.json';
import BlogTheme from './Theme/theme';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import BlogContent from './Component/BlogContent/index';
import UserStories from './Component/UserStories';

class App extends Component {
  theme: BlogTheme = Object.assign({}, globalTheme);
  defaultTheme = createTheme(this.theme);

  render(){
  return (
    <BrowserRouter>
          <Routes>
            <Route key="/" path="/" element={ <ThemeProvider theme={this.defaultTheme}><Layout children={<Home/> } title={'Food and Everything'}></Layout></ThemeProvider>} />
            <Route path='/UserStories' element={ <ThemeProvider theme={this.defaultTheme}><Layout children={<UserStories/> } title={'User Stories'}></Layout></ThemeProvider>}></Route>
          </Routes>
      </BrowserRouter>
  );
  }
}

export default App;
