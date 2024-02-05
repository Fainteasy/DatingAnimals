import { User } from "./user";

export class UserParams {
    genre: string;
    minAge = 1;
    maxAge = 15;
    pageNumber = 1;
    pageSize = 8;
    orderBy = 'lastActive';

    constructor(user: User){
        this.genre = user.genre === "Female" ? "Male" : "Female";
    }

}