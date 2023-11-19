import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { ButtonModule } from 'primeng/button';
import { CheckboxModule } from 'primeng/checkbox';
import { InputTextModule } from 'primeng/inputtext';
import { PasswordModule } from 'primeng/password';
import { CardModule } from 'primeng/card';
import { DropdownModule } from 'primeng/dropdown';
import { MessagesModule } from 'primeng/messages';
import { CarouselModule } from 'primeng/carousel';
import { PanelMenuModule } from 'primeng/panelmenu';
import { TableModule } from 'primeng/table';
import { MessageService } from 'primeng/api';
import { PanelModule } from 'primeng/panel';

@NgModule({
  declarations: [],
  providers: [ MessageService ],
  imports: [

  ],
  exports: [
    PanelModule,
    ButtonModule,
    CardModule,
    TableModule,
    PasswordModule,
    CarouselModule,
    PanelMenuModule,
    CheckboxModule,
    MessagesModule,
    DropdownModule,
    InputTextModule,
    FormsModule,
    PasswordModule
  ]
})
export class PrimeNgModule { }
