import {Component, ViewEncapsulation} from '@angular/core';
import {FormGroup, AbstractControl, FormBuilder, Validators} from '@angular/forms';
import {AuthenticationService, AppUser} from '../../auth.service'
import {Observable} from 'rxjs/Rx';
import {Router} from '@angular/router';

@Component({
    selector: 'login',
    providers: [AuthenticationService],
    styles: [require('./login.scss')],
    template: require('./login.html')
})

export class Login {
			user: AppUser = {
			  UserName: '',
			  Password: ''
			};
	public IsValid:string;
	public errmessage:string;
    public errorMsg = '';
	public form:FormGroup;
	public email:AbstractControl;
	public password:AbstractControl;
	public submitted:boolean = false;

    constructor(
        private _service:AuthenticationService,fb:FormBuilder, private _router: Router) 
		{

			 this.form = fb.group({
				'email': ['', Validators.compose([Validators.required, Validators.minLength(4)])],
				'password': ['', Validators.compose([Validators.required, Validators.minLength(4)])]
			});	
			
			this.email = this.form.controls['email'];
			this.password = this.form.controls['password'];
			
	}
		
	
	public login()
	{
		this.user.UserName = this.form.controls.email.value;
		this.user.Password = this.form.controls.password.value;
		
		return this._service.login(this.user).subscribe(
			data => this.IsValid = JSON.stringify(data),
			error => console.log("Error"), 
			() => if(this.IsValid == 'true')
			{
				localStorage.setItem("user", this.user);
				this._router.navigate(['pages']); 
			}else{
				this.errmessage = 'Login failed';
			}
		);
	}
	
	public onSubmit(values:Object):void {
		this.submitted = true;
		if (this.form.valid) {
		  // your code goes here
		  // console.log(values);
		}
	}
}