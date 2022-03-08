import { Container, Grid, Box } from "@mui/material";
import styles from './layout.module.css';

export class LayoutProps {
  children?: Object | undefined;
  title!: string;
  isEmptyBackground?: Boolean;
}

export default function Layout({ children, title }: LayoutProps) {
  return (
    <>
      <header className={styles.header}>
        <Box>{title}</Box>
      </header>
      <hr></hr>
      <Grid container>
        <Grid item md={8} lg={6} xl={6} >
          <Container className={styles.container}>
            <main className={styles.main}>{children}</main>
          </Container>
        </Grid>
          <Grid item md={4} lg={6} xl={6}>
            <Box sx={{padding: "20px"}}><img src="../blog.jpg" alt='food' width="487px" height="460.58px" /></Box>
          </Grid>
      </Grid>
      <footer className={styles.footer}>
        <a
          href="https://reactjs.org/"
          target="_blank"
          rel="noopener noreferrer"
        >
          Powered by{' '}
          <span className={styles.logo}>
            <img src="../logo512.png" alt="React" width={100} height={100} />
          </span>
        </a>
      </footer>
    </>
  )
}
