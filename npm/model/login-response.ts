/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { User } from "./user";

export class LoginResponse {
    id: number = -1;
    userId: number = -1;
    user: User | null = null;
    loggedIn: Date | null = new Date();
    token: string = "";
    expires: Date | null = new Date();
    loggedOut: Date | null = new Date();
}
