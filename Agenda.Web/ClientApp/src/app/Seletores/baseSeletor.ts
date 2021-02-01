import { ObjectMapper } from "json-object-mapper";

export abstract class Seletor {
  public Id: number = 0;  
  
  abstract Create(input: any): any;  
  
  public toJSON(): string {
      return <string>ObjectMapper.serialize(this);
    }
}