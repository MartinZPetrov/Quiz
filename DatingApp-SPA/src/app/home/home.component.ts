import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from '../_services/data.service';
import { AlertifyService } from '../_services/alertify.service';
declare var $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  model: any = {};
  settings: any = {};
  questions: any = {};
  multipleQuestions: any = {};
  registerMode = false;
  toggleMode = true;
  index = 0;
  indexMultiple = 0;
  isVisibleNext = false;
  gameOver = false;

  constructor(private dataService: DataService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.getSettings();
    this.getQuestions();
    this.getMultipleQuestions();
  }

  getSettings() {
    // tslint:disable-next-line: no-shadowed-variable
    this.dataService.getSetting().subscribe(settings => {
      this.settings = settings[0];
    }, error => {
      console.log(error);
    });
  }

  getQuestions() {
    this.dataService.getQuestions().subscribe(questions => {
      this.questions = questions;
    }, error => {
      this.alertify.еrror(error);
    });
  }

  getMultipleQuestions() {
    this.dataService.getMultipleQuestions().subscribe(multipleQuestions => {
      this.multipleQuestions = multipleQuestions;
    }, error => {
      this.alertify.еrror(error);
    });
  }

  registerToggle() {
    this.registerMode = true;
  }

  yes() {
    this.isVisibleNext = true;
    if (this.questions[this.index].answer.answer === this.questions[this.index].answer.correctAnswer ) {
      this.alertify.success('Correct! The right answer: ' + this.questions[this.index].answer.correctAnswer);
    } else {
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + this.questions[this.index].answer.correctAnswer);
    }
  }

  no() {
    this.isVisibleNext = true;
    if (this.questions[this.index].answer.answer !== this.questions[this.index].answer.correctAnswer) {
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + this.questions[this.index].answer.correctAnswer);
    } else {
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + this.questions[this.index].answer.correctAnswer);
    }
  }
  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

  changeMode() {
    this.toggleMode = !this.toggleMode;
  }
  next() {
    this.isVisibleNext = false;
    this.index++;
    if (this.settings.binaryMode === false) {
      $('#buttons-multiple').show();
      this.indexMultiple++;
      if (this.multipleQuestions.length === this.indexMultiple) {
        this.gameOver = true;
      }
    } else {
      if (this.questions.length === this.index) {
        this.gameOver = true;
      }
    }
  }

  firstAnswer() {
    this.isVisibleNext = true;
    $('#buttons-multiple').hide();
    if (this.multipleQuestions[this.indexMultiple].multipleAnswers.firstAnswerCorrect) {
      this.alertify.success('Correct! The right answer: ' + this.multipleQuestions[this.indexMultiple].multipleAnswers.firstAnswer);
    } else {
      const error = this.checkForCorrectAnswer(this.indexMultiple);
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + error);
    }
  }

  secondAnswer() {
    this.isVisibleNext = true;
    $('#buttons-multiple').hide();
    if (this.multipleQuestions[this.indexMultiple].multipleAnswers.secondAnswerCorrect) {
      this.alertify.success('Correct! The right answer: ' + this.multipleQuestions[this.indexMultiple].multipleAnswers.secondAnswer);
    } else {
      const error = this.checkForCorrectAnswer(this.indexMultiple);
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + error);
    }
  }

  thirdAnswer() {
    this.isVisibleNext = true;
    $('#buttons-multiple').hide();
    if (this.multipleQuestions[this.indexMultiple].multipleAnswers.thirdAnswerCorrect) {
      this.alertify.success('Correct! The right answer: ' + this.multipleQuestions[this.indexMultiple].multipleAnswers.thirdAnswer);
    } else {
      const error = this.checkForCorrectAnswer(this.indexMultiple);
      this.alertify.еrror('Sorry, you are wrong! The right answer is: ' + error);
    }
  }

  checkForCorrectAnswer(multipleInd) {
    let correctAnswer;
    correctAnswer = this.multipleQuestions[multipleInd].multipleAnswers.firstAnswerCorrect === true;
    if (correctAnswer) {
      return this.multipleQuestions[multipleInd].multipleAnswers.firstAnswer;
    }

    correctAnswer = this.multipleQuestions[multipleInd].multipleAnswers.secondAnswerCorrect === true;
    if (correctAnswer) {
      return this.multipleQuestions[multipleInd].multipleAnswers.secondAnswer;
    }

    correctAnswer = this.multipleQuestions[multipleInd].multipleAnswers.thirdAnswerCorrect === true;
    if (correctAnswer) {
      return this.multipleQuestions[multipleInd].multipleAnswers.thirdAnswer;
    }
  }
}
