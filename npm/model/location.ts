/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IHasImage } from "./i-has-image";
import { LocationType } from "./location-type";
import { Address } from "./address";

export class Location implements IHasImage {
    id: number = -1;
    name: string = "";
    description: string = "";
    locationTypeId: number = -1;
    locationType: LocationType = new LocationType();
    addressId: number = -1;
    address: Address | null = null;
    googleLink: string = "";
    imageId: string | null = null;
    imageUrl: string | null = null;
}
