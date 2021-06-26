import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Article } from '../_models/Article';
import { ContentService } from '../_services/content.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {
  articles: Article[];
  page: number;
  constructor(private content: ContentService, 
              private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.page = this.activatedRoute.snapshot.params.page;
    //this.page = 1;
    this.loadContent(this.page);
  }

  loadContent(page: number){
    if (!page) {page = 0} 
    //console.log(page);
    this.content.getContent(page).subscribe((articles: Article[]) => {
         this.articles = articles;
         //var newIntroText = this.articles.introText.replace(/\\r\\n/gi, "</p><p>"); 
    }, error => {
      //this.alertify.error(error);
      console.log(error);
    });
  }

}
