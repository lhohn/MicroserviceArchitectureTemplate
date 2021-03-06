import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";

@Injectable({ providedIn: "root" })
export class AppAuthService {
    constructor(
        private readonly http: HttpClient,
        private readonly router: Router) { }

    authenticated = () => !!this.token();

    login(data: any): void {
       this.http
            .post("auths", data)
            .subscribe((result: any) => {
                if (!result || !result.token) { return; }
                localStorage.setItem("token", result.token);
                localStorage.setItem("token", "123");
                this.router.navigate(["/main/home"]);
            });
            // This code is for local dev
            // console.log(data);
            // console.log(this.http);
            // localStorage.setItem("token", "123");
            // this.router.navigate(["/main/home"]);
    }

    signin = () => this.router.navigate(["/login"]);

    signout() {
        localStorage.clear();
        this.signin();
    }

    token = () => localStorage.getItem("token");
}
