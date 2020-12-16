import { Component, ChangeDetectorRef, ViewEncapsulation, OnInit } from '@angular/core';
import { NavigationNode } from './components/app-layout/navigation-node';
import { Store, select } from '@ngrx/store';
import { AppState, selectRouteData, selectAllAccounts, selectRouteParams } from './store/reducers';
import { Observable, combineLatest } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'ffdc-app',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent implements OnInit {
  navbarMenuData: NavigationNode[] = [];
  showBanner = false;
  isHomePage$: Observable<boolean>;

  constructor(store: Store<AppState>, private router: Router, private cd: ChangeDetectorRef) {
    this.isHomePage$ = store.pipe(
      select(selectRouteData),
      map(data => (data ? data.viewId === 'home' : false))
    );

    combineLatest(
      store.pipe(select(selectAllAccounts)),
      store.pipe(select(selectRouteParams)),
      store.pipe(select(selectRouteData))
    ).subscribe(([accounts, routeParams, routeData]) => {
      if (routeData) {
        console.log("RouteData", routeData);
        if (routeData.viewId === 'accounts') {
          this.navbarMenuData = [
            {
              url: '/accounts',
              title: 'ACCOUNTS'
            }
          ];
        } else if (routeData.viewId === 'accountDetail') {
          const currentAccount = accounts.find(account => account.accountId === routeParams.accountId);
          this.navbarMenuData = [
            {
              url: '/accounts',
              title: 'ACCOUNTS',
              showOtherChildren: true,
              children: accounts.map(account => ({
                url: `/accounts/${account.accountId}`,
                title: `${account.nickname}`
              }))
            },
            {
              url: `/accounts/${routeParams.accountId}`,
              title: currentAccount ? currentAccount.nickname : ''
            }
          ];
        }
        this.cd.markForCheck();
      }
    });
  }
  ngOnInit(): void {
    this.loading();
  }

  loading(){
    setTimeout(() =>{ 
        this.showBanner = true; 
    }, 5000);
  }
}
