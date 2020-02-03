import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GemachComponent } from './gemach.component';
import { HomeGemachComponent } from './home-gemach/home-gemach.component';
import { Page404GemachComponent } from './page404-gemach/page404-gemach.component';
import { ShowGemachDetailsComponent } from './show-gemach-details/show-gemach-details.component';
import { ProductsGroupsListComponent } from './products-groups-list/products-groups-list.component';
import { SignupGemachComponent } from './signup-gemach/signup-gemach.component';
import { LoginGemachComponent } from './login-gemach/login-gemach.component';
import { Page500GemachComponent } from './page500-gemach/page500-gemach.component';


const routes: Routes = [
  {
    path: ':gemachid', component: GemachComponent, children: [
      { path: 'home-gemach', component: HomeGemachComponent },
      { path: 'show-gemach-details', component: ShowGemachDetailsComponent },
      { path: 'products-groups-list', component: ProductsGroupsListComponent },
      { path: 'login', component: LoginGemachComponent },
      { path: 'signup', component: SignupGemachComponent },
      { path: 'page404-gemach', component: Page404GemachComponent },
      { path: 'page500-gemach', component: Page500GemachComponent },
      { path: '', redirectTo: 'home-gemach', pathMatch: 'full' },
      { path: '**', redirectTo: 'page404-gemach', pathMatch: 'full' }
    ]
  }
];



@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GemachRoutingModule { }