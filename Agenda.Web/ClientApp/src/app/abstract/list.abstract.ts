import { Model } from '../Models/baseModel';
import { Seletor } from '../Seletores/baseSeletor';

export abstract class ListAbstract< E extends Model, T extends Seletor > {
  
  private _seletor: T;
  private _totalItems: number;

  private _list: E[];

  constructor( seletor: T) {
    this.Seletor = seletor;
    this._totalItems = 0;

  }

  get Seletor(): T {
    return this._seletor;
  }

  set Seletor(seletor: T) {
    this._seletor = seletor;
  }

  get TotalItens(): number {
    return this._totalItems;
  }

  get List(): E[] {
    return this._list;
  }

  set List(E) {
    this._list = E;
  }
}