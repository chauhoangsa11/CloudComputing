package com.example.demo.model;

//import com.fasterxml.jackson.annotation.JsonBackReference;

import com.fasterxml.jackson.annotation.JsonProperty;

import javax.persistence.Entity;


import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;



@Entity
public class student {



//    public int getMathScore() {
//        return mathScore;
//    }
//
//    public void setMathScore(int mathScore) {
//        this.mathScore = mathScore;
//    }
    @Id
  @GeneratedValue (strategy = GenerationType.IDENTITY)
    private  int id;

    private  String name;

    private int listenning;
//    @Id
//    @GeneratedValue( strategy = GenerationType.AUTO)

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getListenning() {
        return listenning;
    }

    public void setListenning(int listenning) {
        this.listenning = listenning;
    }

    public int getSpeaking() {
        return speaking;
    }

    public void setSpeaking(int speaking) {
        this.speaking = speaking;
    }

    public int getWriting() {
        return writing;
    }

    public void setWriting(int writing) {
        this.writing = writing;
    }

    public int getReading() {
        return reading;
    }

    public void setReading(int reading) {
        this.reading = reading;
    }

    private int speaking;

    private int writing;

    private int reading;

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    private int year;
    private  String address;


//    private int mathScore;
}
