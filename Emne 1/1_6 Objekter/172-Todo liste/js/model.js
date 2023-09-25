let taskIdCounter = 1;

const people = [
    "Erik Hansen",
    "Ingrid Olsen",
    "Andreas Johansen",
    "Marianne Pedersen",
    "Ole Kristoffersen",
    "Sofie Larsen",
    "Per Andreassen",
    "Kari Berg",
    "Lars Olsen",
    "Mette Eriksen"
];

let filter = "";

let task = {
    id: 0,
    description: "Test",
    createdDate: null,
    lastEditDate: null,
    closedDate: null,
    responsible: people[5],
    isDone: false,
    inEditMode: false
}

let taskList = [task];

let newTaskDescription = "";

  
