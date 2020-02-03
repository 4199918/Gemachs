import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GemachRoutingModule } from './gemach-routing.module';
import { GemachComponent } from './gemach.component';
import { Page500GemachComponent } from './page500-gemach/page500-gemach.component';
import { Page404GemachComponent } from './page404-gemach/page404-gemach.component';
import { ProductsGroupsListComponent } from './products-groups-list/products-groups-list.component';
import { ShowGemachDetailsComponent } from './show-gemach-details/show-gemach-details.component';
import { HomeGemachComponent } from './home-gemach/home-gemach.component';
import { SidebarGemachComponent } from './sidebar-gemach/sidebar-gemach.component';
import { HeaderGemachComponent } from './header-gemach/header-gemach.component';
import { LoginGemachComponent } from './login-gemach/login-gemach.component';
import { SignupGemachComponent } from './signup-gemach/signup-gemach.component';
import { GemachesService } from '../services/gemaches.service';


@NgModule({
  declarations: [
    GemachComponent,
    HeaderGemachComponent,
    SidebarGemachComponent,
    HomeGemachComponent,
    ShowGemachDetailsComponent,
    ProductsGroupsListComponent,
    Page404GemachComponent,
    Page500GemachComponent,
    LoginGemachComponent,
    SignupGemachComponent
  ],
  imports: [
    CommonModule,
    GemachRoutingModule
  ],
  providers: [GemachesService]
})
export class GemachModule { }
