import { ThemeOptions } from '@mui/material/styles';


export default interface BlogTheme extends ThemeOptions {
    status?: CustomStatus
    customShadows?: CustomShadows
    grid?: Grid
}

interface CustomStatus {
    danger?: string;
}

interface CustomShadows {
    z20?: string;
}

interface Grid {
    minHeight?: string;
    height:  string;
}
