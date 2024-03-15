//Create and export the interface of the Bowlers data that is being passed in allowing nulls

export interface Bowlers {
  bowlerID?: number;
  bowlerLastName?: string | null;
  bowlerFirstName?: string | null;
  bowlerMiddleInit?: string | null;
  bowlerAddress?: string | null;
  bowlerCity?: string | null;
  bowlerState?: string | null;
  bowlerZip?: string | null;
  bowlerPhoneNumber?: string | null;
  teamID?: number;
  teamName?: Teams | null;
}

//Create and export the Teams intervace with the necessry structure
export interface Teams {
  teamID: number;
  teamName: string;
  captainID: number;
}
