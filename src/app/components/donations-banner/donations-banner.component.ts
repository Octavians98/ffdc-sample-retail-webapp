import { Component, Output, EventEmitter } from '@angular/core';
import { animate, query, style, transition, trigger } from '@angular/animations';
@Component({
  selector: 'ffdc-donations-banner',
  templateUrl: 'donations-banner.component.html',
  animations: [
    trigger('slideInOut', [
      transition(':enter', [
        style({ transform: 'translateY(-100%)' }),
        animate('280ms ease-in', style({ transform: 'translateY(0%)' }))
      ]),
      transition(':leave', [animate('200ms ease-in', style({ transform: 'translateY(-100%)' }))])
    ])
  ]
})
export class DonationsBannerComponent {
  donationsBanner = {
    enabled: true,
    content: {
      id: 123,
      title: 'Support Red Cross',
      dismissButtonText: 'No',
      actionButtonText: 'Yes',
      announcement: 'Last year you have donated 50$ Red Cross do you want to help this cause again this year?',
      icon: 'alarm_on'
    }
  };

  @Output() action = new EventEmitter<any>();

  onAction() {
    this.onDismiss();
    this.action.emit();
  }

  onDismiss() {
    this.donationsBanner.enabled = false;
  }

  constructor() {}
}
