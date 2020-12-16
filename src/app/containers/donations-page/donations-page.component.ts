import {
  Component,
  OnInit,
  ChangeDetectionStrategy,
  ViewEncapsulation,
  OnDestroy,
  ChangeDetectorRef
} from '@angular/core';
import { AccountEntity, AllAccountsOverview } from '../../store/models';
import { Store, select } from '@ngrx/store';
import { AppState, selectAccountTransactionsWithAccountInfo, selectAccountTransactionsWithAccountInfoForAccount, selectAllAccounts, selectAllAccountTransactions } from '../../store/reducers';
import { AccountActions } from '../../store/actions';
import { iif, ReplaySubject, Subject } from 'rxjs';
import { switchMap, takeUntil } from 'rxjs/operators';
import { AccountService } from '../../services/account.service';
import { AccountTransaction } from '../../store/models';
import { searchAllAccountTransactions,
  searchAccountTransactions,
  updateTransactionsSelectedDate, 
  updateAccountTransaction} from '../../store/actions/account-transaction.actions';
@Component({
  selector: 'ffdc-donations-page',
  templateUrl: './donations-page.component.html',
  styleUrls: ['./donations-page.component.scss'],
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
  host: {
    class: 'donations-page'
  }
})
export class DonationsPageComponent implements OnInit, OnDestroy {
  accountTransactions: AccountTransaction[] = [];
  accounts: AccountEntity[] = [];
  allAcountsOverview: AllAccountsOverview = { current: 0, available: 0 };
  selectedAccount: any;
  donationAmmount: number = 0;
  donated: boolean = false;
  donationAccount: AccountEntity | undefined;
  availableBalance = 0;
  private accountId$ = new ReplaySubject<string>(1);
  

  private destroyed$ = new Subject<any>();
  showAllAccount: boolean = true;

  constructor(private accountService: AccountService, private store: Store<AppState>, private cd: ChangeDetectorRef) {}

  ngOnInit() {
    this.store.dispatch(AccountActions.loadExtendedAndDetailedAccounts());
    this.store
      .pipe(
        select(selectAllAccounts),
        takeUntil(this.destroyed$)
      )
      .subscribe(accounts => {
        this.accounts = accounts;
       
        this.allAcountsOverview = this.accountService.getAllAcountOverview(accounts);
        this.availableBalance = this.allAcountsOverview.available;
        this.cd.markForCheck();
      });
  }

  ngOnDestroy() {
    console.log("this.accounts", this.accounts);
    this.destroyed$.next();
    this.destroyed$.complete();
  }

  setInterval() {
    console.log("donationAmmount", this.donationAmmount);
    console.log("selectedAccount", this.selectedAccount);
  }

  makeTransaction() {
    this.availableBalance = this.availableBalance - this.donationAmmount;
    console.log(this.availableBalance);
    const accountId = this.selectedAccount.accountId;
    const filter = {
      endDate: "2020-01-31",
      startDate: "2020-12-31"
    }
    const transactionId = "6987152201912160001"
    // console.log(accountId);
    // this.store
    //   .pipe(
    //     select(selectAllAccountTransactions),
    //     takeUntil(this.destroyed$)
    //   )
    //   .subscribe(accountTransactions => {
    //     this.accountTransactions = accountTransactions;
       
    //     this.cd.markForCheck();
    //   });

    // const getAllOrSingleAccountTransaction = iif(
    //   () => this.showAllAccount,
    //   this.store.pipe(select(selectAccountTransactionsWithAccountInfo)),
    //   this.accountId$.pipe(
    //     switchMap(accountId =>
    //       this.store.pipe(
    //         select(selectAccountTransactionsWithAccountInfoForAccount, { accountId })
    //       )
    //     )
    //   )
    // ).subscribe(transactions=>{
    //   console.log("transactions", transactions)
    // })
    //   console.log(getAllOrSingleAccountTransaction);
    // this.store.dispatch(searchAccountTransactions({accountId, filter})).subscribe(accountTransactions => {
    //   this.accountTransactions = accountTransactions;
    //   console.log(this.accountTransactions);
    //   this.cd.markForCheck();
    // });
    this.store.dispatch(updateAccountTransaction({accountId, transactionId}))
  }
  
}

