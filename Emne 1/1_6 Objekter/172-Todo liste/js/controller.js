"use strict";
function getTimeStamp(){
    return Date().slice(0,24); //Gets the day, month, date, and time.
}
function completeTask(id){
    console.log(taskList[id])
    if(!taskList[id].isDone)
        taskList[id].closedDate = getTimeStamp();
        taskList[id].isDone = true;
    
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
    let task = {
        id: getNextIdValue(),
        description: desc,
        createdDate: getTimeStamp(),
        responsible: assigned,
        isDone: false,
        inEditMode: false,
    }
    
    taskList.push(task)

    updateView()
}

function editTask(id){
    taskList[id].inEditMode = true;
    updateView()
}

function saveChanges(id, newDescription, newPerson){
    taskList[id].description = newDescription;
    taskList[id].responsible = newPerson;
    taskList[id].inEditMode = false;
    taskList[id].lastEditDate = getTimeStamp()
    updateView()
}


function getNextIdValue(){
    return taskIdCounter++;
}