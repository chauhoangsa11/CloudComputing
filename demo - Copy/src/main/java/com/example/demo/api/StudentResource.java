package com.example.demo.api;
import  com.example.demo.model.student;


import  com.example.demo.service.studentService;

import java.awt.*;
import java.util.List;


import com.fasterxml.jackson.annotation.JsonBackReference;
import org.hibernate.query.criteria.internal.expression.function.AggregationFunction;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Sort;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import java.util.List;
@RestController
@RequestMapping(value="/student")
public class StudentResource {
    @Autowired
    private studentService StudentService;

    @RequestMapping(method = RequestMethod.POST, consumes = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    @PostMapping(consumes = {MediaType.APPLICATION_JSON_VALUE, MediaType.APPLICATION_XML_VALUE})
    public  student addStudent(@RequestBody student st)
    {

        return  StudentService.addStudent(st);
    }

    @RequestMapping(method = RequestMethod.GET)
    @GetMapping
    public List<student> getStudent()
    {
        return StudentService.getStudent();
    }

    @GetMapping(value = "/{studentId}")
    public  student getStudent(@PathVariable("studentId") int studentId)
    {
        return  StudentService.getStudentId(studentId);
    }

    @PutMapping(value = "/{studentId}")
    public  student updateStudent(@PathVariable("studentId") int studentId, @RequestBody student st)
    {
        return  StudentService.updateStudent(studentId, st);
    }

    @DeleteMapping(value = "/{studentId}")
    public  void deleteStudent(@PathVariable("studentId") int studentId)
    {
        StudentService.deleteStudent(studentId);
    }

//    @GetMapping(value = "/sortScore/")
//    public  List<student> orderScore()
//    {
//        return  StudentService.findAll(Sort.by(Sort.Direction.DESC, AggregationFunction.SUM(listenning,writing))
//    }


}
