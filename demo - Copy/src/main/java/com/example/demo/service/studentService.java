package com.example.demo.service;
import com.example.demo.model.student;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;



import java.util.concurrent.CopyOnWriteArrayList;

import com.example.demo.dao.studentDAO;

@Component
public class studentService {
    @Autowired
    private  studentDAO StudentDAO;

//    private  int countStudent=1;
//
//    private List<student> listStudents = new CopyOnWriteArrayList<>();

    public  student addStudent(student st)
    {
//        st.setId(countStudent);
//
//        listStudents.add(st);
//        countStudent++;
//        return  st;

       StudentDAO.save(st);
        return st;
    }

    public  List<student> getStudent(){
        return  StudentDAO.findAll();
    }

    public  student getStudentId(int idStudent)
    {
       // return  listStudents.stream().filter(c -> c.getId() == idStudent ).findFirst().get();
        return StudentDAO.findById(idStudent).get();
    }

    public  student updateStudent (int idStudent, student itemStudent)
    {
//        listStudents
//                .stream()
//                .forEach(c-> {
//                    if (c.getId() == idStudent) {
//                        c.setName(itemStudent.getName());
//
//                        c.setMathScore(itemStudent.getMathScore());
//                    }
//                });
//
//        return listStudents.stream().filter(c -> c.getId() == idStudent ).findFirst().get();

     return   StudentDAO.save(itemStudent);

    }

    public  void deleteStudent(int idStudent)
    {
//        listStudents.stream().forEach(c-> {
//            if (c.getId() == idStudent)
//            {
//                listStudents.remove(c);
//            }
//        });

//
        StudentDAO.deleteById(idStudent);
    }

}
