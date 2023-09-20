"use strict";

function updateView(){
    document.getElementById("app").innerHTML = /*HTML*/`
    
    <table>
        <tr>
            <th>Id</th>
            <th>Task</th>
            <th>Created</th>
            <th>Last Edited</th>
            <th>Closed date</th>
            <th>Responsible</th>
            <th>Complete</th>
        </tr>
        ${generateRows()}
    </table>
    <br>
    <hr>
        <div>
        <label for="newTaskInputField">New task:</label>
        <input id="newTaskInputField" type="text"/><br>
        <label for="newTaskInputField">Assign to:</label>
        <select id="personnelList">${generatePersonnelList()}</select>
        <button onclick="
            createTask(
                document.getElementById('newTaskInputField').value, 
                document.getElementById('personnelList').value)">
                Add</button>
        </div>
        
    `
}

function generateRows(){
    let rows = "";
    for(let task of taskList){
    rows += `<tr>
                <td>${task.id}</td>
                <td>${task.inEditMode ? `<input type="text" value="${task.description}" id="descriptionInput${task.id}"/>` : task.description}</td>
                <td>${task.createdDate ?? ""}</td>
                <td>${task.lastEditDate ?? ""}</td>
                <td>${task.closedDate ?? ""}</td>
                <td>${task.inEditMode ? `<select id="selectPerson${task.id}">${generatePersonnelList(task.responsible)}</select>` : task.responsible}</td>
                <td><input type="checkbox" ${task.isDone ? "checked":""} oninput="completeTask(${task.id})" /></td>
                
                <td><button onclick="deleteTask(${task.id})">Delete</button>
                <td>${task.inEditMode ?  `<button onclick="updateTaskInfo(${task.id})">Save` :`<button onclick="editTask(${task.id})">Edit`} </button>
            </tr>`
    }
    return rows;
}

function updateTaskInfo(id){
    saveChanges(id, getValueFromId(`descriptionInput${id}`), getValueFromId(`selectPerson${id}`))
}

function getValueFromId(id){
    return document.getElementById(id).value
}

function generatePersonnelList(selectedPerson){
    let html = "";
    for(let p of people){
        if(p == selectedPerson)
            html += `<option selected>${p}</option>`
        else
            html += `<option>${p}</option>`
    }
    return html;
}

function getSelectedPerson(){
    
}



