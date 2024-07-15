import { enableProdMode, importProvidersFrom } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { provideRouter } from '@angular/router';

import { AppComponent } from './app/app.component';
import { environment } from './environments/environment';
import { routes } from './app/app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './app/services/auth.service';
import { AuthGuard } from './app/guards/auth.guard';

if (environment.production) {
  enableProdMode();
}

bootstrapApplication(AppComponent, {
  providers: [
    importProvidersFrom(HttpClientModule),
    provideRouter(routes),
    AuthService,
    AuthGuard
  ]
}).catch(err => console.error(err));
