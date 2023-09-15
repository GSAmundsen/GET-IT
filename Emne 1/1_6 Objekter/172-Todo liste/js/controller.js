"use strict";

function completeTask(id){
    let timeStamp = Date().slice(0,24); //Gets the day, month, date, and time.
    for(let task of taskList){
        if(task.id == id && !task.isDone){
            task.doneDate = timeStamp;
            task.isDone = true;
            break;
        }
    }
    updateView()
}

function deleteTask(id){
    for(let task of taskList){
        if(task.id == id){
            taskList.splice(taskList.indexOf[task], 1);
            break;
        }
    }
    updateView()
}

function createTask(desc, assigned){
    if(desc == "" || assigned == "") return;
    taskList.push( {
        id: getNextIdValue(),
        description: desc,
        doneDate: "",
        responsible: assigned,
        isDone: false,
        inEditMode: false,
    })

    updateView()
}

function editTask(id){
    for(let task in taskList){
        if(task.id == id){
            task.inEditMode = true;
        }
    }
}




function getNextIdValue(){
    return taskIdCounter++;
}