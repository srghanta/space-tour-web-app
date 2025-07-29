
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Tour {
  id: number;
  name: string;
  description: string;
  capacity: number;
  price: number;
  startDate: string;
}

@Injectable({ providedIn: 'root' })
export class TourService {
  private apiUrl = 'http://localhost:5000/api/tours';

  constructor(private http: HttpClient) {}

  getTours(): Observable<Tour[]> {
    return this.http.get<Tour[]>(this.apiUrl);
  }
}
