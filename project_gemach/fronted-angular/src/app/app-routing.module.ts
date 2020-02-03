import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GemachesListComponent } from './gemaches-list/gemaches-list.component';
import { HomeComponent } from './home/home.component';
import { Page404Component } from './page404/page404.component';
import { Page500Component } from './page500/page500.component';
import { SupportCenterComponent } from './support-center/support-center.component';
import { AddGemachRequestComponent } from './add-gemach-request/add-gemach-request.component';


const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'gemaches-list', component: GemachesListComponent },
    { path: 'add-gemach-request', component: AddGemachRequestComponent },
    { path: 'support-center', component: SupportCenterComponent },
    { path: 'gemach', loadChildren: () => import(`./gemach/gemach.module`).then(m => m.GemachModule) },
    { path: 'page404', component: Page404Component },
    { path: 'page500', component: Page500Component },
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: '**', redirectTo: 'page404', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { enableTracing: false })],
  exports: [RouterModule]
})
export class AppRoutingModule { }