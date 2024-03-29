import { Photo } from "./photo"


export interface Member {
    id: number
    userName: string
    photoUrl: string
    age: number
    knownAs: string
    created: Date
    lastActive: Date
    genre: string
    introduction: string
    lookingFor: string
    interests: string
    city: string
    photos: Photo[]
    race: string
    isSterilized: boolean
  }
  
