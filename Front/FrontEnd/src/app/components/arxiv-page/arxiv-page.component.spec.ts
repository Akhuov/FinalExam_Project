import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArxivPageComponent } from './arxiv-page.component';

describe('ArxivPageComponent', () => {
  let component: ArxivPageComponent;
  let fixture: ComponentFixture<ArxivPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ArxivPageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ArxivPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
