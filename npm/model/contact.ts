/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IHasImage } from "./i-has-image";

export class Contact implements IHasImage {
    id: number = -1;
    title: string | null = null;
    firstName: string = "";
    middleNames: string | null = null;
    lastName: string = "";
    alternateName: string | null = null;
    dateOfBirth: Date | null = null;
    dateOfDeath: Date | null = null;
    email: string = "";
    phone: string | null = null;
    imageId: string | null = null;
    imageUrl: string | null = null;
    geneology: string | null = null;
}
