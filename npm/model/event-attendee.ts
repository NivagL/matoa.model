/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { Event } from "./event";
import { Contact } from "./contact";

export class EventAttendee {
    eventId: number = -1;
    event: Event | null = null;
    contactId: number = -1;
    contact: Contact | null = null;
    invited: boolean = true;
    attended: boolean = false;
}
