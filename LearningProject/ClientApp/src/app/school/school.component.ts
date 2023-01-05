import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html'
})
export class SchoolComponent {
  public outputs: School[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<School[]>(baseUrl + 'school').subscribe(result => {
      this.outputs = result;
    }, error => console.error(error));
  }
}

interface School {
  date: string;
  numberOfStudents: number;
  grade: number;
  teacher: string;
  class: string;
}
