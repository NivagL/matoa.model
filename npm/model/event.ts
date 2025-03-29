/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IHasImage } from "./i-has-image";
import { EventType } from "./event-type";
import { Contact } from "./contact";
import { Location } from "./location";

export class Event implements IHasImage {
    id: number = -1;
    name: string = "";
    description: string = "";
    eventTypeId: number | null = null;
    eventType: EventType | null = null;
    organiserId: number | null = null;
    organiser: Contact | null = null;
    locationId: number | null = null;
    location: Location | null = null;
    eventStart: Date | null = null;
    eventEnd: Date | null = null;
    imageId: string | null = null;
    imageUrl: string | null = null;
}
