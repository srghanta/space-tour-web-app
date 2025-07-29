
import { Component, OnInit } from '@angular/core';
import { TourService, Tour } from '../services/tour.service';

@Component({
  selector: 'app-tour-list',
  template: `
    <div *ngFor="let tour of tours">
      <h2>{{ tour.name }}</h2>
      <p>{{ tour.description }}</p>
      <p>Price: {{ tour.price }}</p>
    </div>
  `
})
export class TourListComponent implements OnInit {
  tours: Tour[] = [];

  constructor(private tourService: TourService) {}

  ngOnInit(): void {
    this.tourService.getTours().subscribe(data => this.tours = data);
  }
}
