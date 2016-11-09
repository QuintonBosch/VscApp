import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import {Routes, RouterModule } from '@angular/router';
import {Jsonp,Headers,URLSearchParams,RequestOptions,RequestMethod,Request} from '@angular/http';
import {Observable} from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

export class AppUser {
  public UserName: string,
  public Password: string
}

@Injectable()
export class AuthenticationService {
	
	private _webApiUrl = 'http://10.0.1.4:9810/api/Login/';
	private _webApiUrl1 = 'http://localhost:58306//api/Login/';
	public drivers : any[];

	constructor(private http: Http){}

	logout() {
		localStorage.removeItem("user");
		this._router.navigate(['Login']);
	}

	login(user): Observable<{}> {
		let headers = new Headers({ 'Content-Type': 'application/json' });
		let body = JSON.stringify(user);
		let params = new URLSearchParams(); 
		params.set('username', user.UserName);
		params.set('password', user.Password);	
		
		return this.http.get(this._webApiUrl1, {search: params}).map((res: Response) => res.json());
		
	}
  
	private handleError(error: Response) {
		console.error(error);
		return Observable.throw(error.json().error || 'Server error');
	}

    checkCredentials( ){
		if (localStorage.getItem("user") === null){
			this._router.navigate(['Login']);
		}
    } 
}