/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { User } from "./user";
import { Contact } from "./contact";

export class Registration {
    id: number = -1;
    created: Date = new Date();
    username: string = "";
    password: string = "";
    firstName: string = "";
    middleNames: string | null = null;
    lastName: string = "";
    dateOfBirth: Date | null = null;
    email: string = "";
    phone: string | null = null;
    imageId: string | null = null;
    imageUrl: string | null = null;
    geneology: string | null = null;
    userId: number | null = null;
    user: User | null = null;
    contactId: number | null = null;
    contact: Contact | null = null;
}
