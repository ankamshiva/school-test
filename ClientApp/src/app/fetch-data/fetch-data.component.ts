import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public students: Student[];
  public teachers: Teacher[];
  public Grades = ["Grade1", "Grade2", "Grade3", "Grade4"];
  public Classes = ["Class1", "Class2", "Class3", "Class4"];
  public currentRecord = {
    id: 0,
    firstName: '',
    lastName: '',
    address: '',
    email: '',
    grade: '',
    class: '',
    teachingFrom: new Date().toISOString(),
    student: true
  };
  inAction = false;
  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
    this.getData();
  }

  saveClick() {
    console.log(this.currentRecord);
    if (this.currentRecord.student) {
      this.http.post<any>(this.baseUrl + 'students', this.currentRecord).subscribe(data => {
        this.getData();
        this.inAction = false;
      },
        error => {
          console.log("add student error", error);
        }
      );
    } else {
      this.http.post<any>(this.baseUrl + 'teachers', this.currentRecord).subscribe(data => {
        this.getData();
        this.inAction = false;
      },
        error => {
          console.log("add teacher error", error);
        }
      );
    }
  }

  public getData(): void {
    this.http.get<Student[]>(this.baseUrl + 'students').subscribe(result => {
      this.students = result;
    }, error => console.error(error));
    this.http.get<Teacher[]>(this.baseUrl + 'teachers').subscribe(result => {
      this.teachers = result;
    }, error => console.error(error));
  }
}

interface Student {
  firstName: string;
  lastName: string;
  address: string;
  email: string;
  grade: string;
  class: string;
}
interface Teacher {
  firstName: string;
  lastName: string;
  address: string;
  email: string;
  grade: string;
  class: string;
  teachingFrom: string;
}
