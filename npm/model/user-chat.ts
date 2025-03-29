/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { User } from "./user";
import { ChatThread } from "./chat-thread";

export class UserChat {
    userId: number = -1;
    user: User | null = null;
    chatThreadId: number = -1;
    chatThread: ChatThread | null = null;
    dateTime: Date | null = null;
    content: string = "";
}
