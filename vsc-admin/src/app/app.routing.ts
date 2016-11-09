import { Routes, RouterModule } from '@angular/router';
import { Pages } from './pages/pages.component';

export const routes: Routes = [
  { path: 'pages', name: 'Home', component: Pages},
  { path: '**', redirectTo: 'login', name: 'Login'}
];

export const routing = RouterModule.forRoot(routes, { useHash: true });
