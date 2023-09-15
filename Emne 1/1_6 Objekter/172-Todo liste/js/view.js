"use strict";

function updateView(){
    document.getElementById("app").innerHTML = /*HTML*/`
    
    <table>
        <tr>
            <th>Id</th>
            <th>Tast</th>
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
                <td>${task.description}</td>
                <td>${task.doneDate ?? ""}</td>
                <td>${task.responsible}</td>
                <td><input type="checkbox" ${task.isDone ? "checked":""} oninput="completeTask(${task.id})" /></td>
                <td><button onclick="deleteTask(${task.id})">Delete</button>
                <td><button onclick="editTask(${task.id})">Edit</button>
            </tr>`
    }
    return rows;
}

function generatePersonnelList(){
    let html = "";
    for(let p of people){
        html += `<option>${p}</option>`
    }
    return html;
}

