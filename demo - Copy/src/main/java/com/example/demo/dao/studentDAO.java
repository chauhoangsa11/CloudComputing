package com.example.demo.dao;

import com.example.demo.model.student;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface studentDAO extends CrudRepository<student,Integer> {

    @Override
    List<student> findAll();


}
