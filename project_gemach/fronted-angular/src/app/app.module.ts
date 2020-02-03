import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';  
import { Ng2SearchPipeModule } from 'ng2-search-filter';

import { AppComponent } from './app.component';
import { GemachesListComponent } from './gemaches-list/gemaches-list.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { AddGemachRequestComponent } from './add-gemach-request/add-gemach-request.component';
import { Page404Component } from './page404/page404.component';
import { Page500Component } from './page500/page500.component';
import { SupportCenterComponent } from './support-center/support-center.component';
import { GemachesService } from './services/gemaches.service';

@NgModule({
  declarations: [
    AppComponent,
    GemachesListComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    AddGemachRequestComponent,
    Page404Component,
    Page500Component,
    SupportCenterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule,
    ReactiveFormsModule
  ],
  providers: [GemachesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
