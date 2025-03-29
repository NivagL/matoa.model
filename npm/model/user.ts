/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { Contact } from "./contact";
import { UserRole } from "./user-role";

export class User {
    id: number = -1;
    username: string = "";
    password: string = "";
    contactId: number | null = null;
    contact: Contact | null = null;
    userRoles: UserRole[] = [];
}
