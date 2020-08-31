let idCounter = 0;
let array = [];

let modal = document.getElementById('modal');
let btn = document.getElementById("addButton");
let span = document.getElementsByClassName("close")[0];
let acceptBtn = document.getElementById("acceptButton");
let inputHeader = document.getElementById('headerInput');
let inputText = document.getElementById('textInput');

btn.onclick = function() {
    modal.style.display = "block";
}
span.onclick = function() {
    modal.style.display = "none";
    document.getElementById('headerInput').value = "";
    document.getElementById('textInput').value = "";
}
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

acceptBtn.onclick = function() {
    let item = {
        header: document.getElementById('headerInput').value,
        text: document.getElementById('textInput').value,
        id: ++idCounter,
    }
    array.push(item);
    if (item.header !== "" && item.text !== "") {
        inputHeader.className = "headerInput"
        inputText.className = "textInput"
        addElement(item.header, item.text, item.id)
        modal.style.display = "none";
        document.getElementById('headerInput').value = "";
        document.getElementById('textInput').value = "";
    } else {
        inputHeader.className = "headerInputInvalid"
        inputText.className = "textInputInvalid"
    }
}

function addElement(header, text, id) {
    let newItem = document.createElement('div')
    let docHeader = document.getElementById('header')
    let parentDiv = docHeader.parentNode;
    newItem.className = "item";
    newItem.id = id;
    newItem.innerHTML = `<h3 id=\"header${id}\">${header}</h3><p id=\"text${id}\">${text}</p><button class=\"editButton\" id=\"editButton${id}\"><img class=\"editIcon\" src=\"icons/register.png\" alt=\"\"></button><button class=\"deleteButton\" id=\"deleteButton${id}\"><img class=\"deleteIcon\" src=\"icons/delete.png\" alt=\"\"></button>`;
    parentDiv.insertBefore(newItem, docHeader.nextSibling);
}

document.onclick = function(event) {
    let node = event.target.parentNode.className == "deleteButton" ? event.target.parentNode : event.target
    if (node.className == "deleteButton") {
        var id = node.id;
        id = id.replace("deleteButton", "");
        deleteElement(id);
    }
}

function deleteElement(id) {
    let deleteItem = document.getElementById(`${id}`);
    if (confirm("Удалить заметку?")) {
        deleteItem.remove();
    }
}

document.onclick = function(event) {
    let node = event.target.parentNode.className == "editButton" ? event.target.parentNode : event.target
    if (node.className == "editButton") {
        var id = node.id;
        id = id.replace("editButton", "");
        editElement(id);
    }
}

function editElement(id) {
    let newHeader = document.createElement('input');
    let oldHeader = document.getElementById(`header${id}`);
    newHeader.className = "headerInput";
    newHeader.id = `header${id}`;
    newHeader.value = array[id - 1].header;
    oldHeader.replaceWith(newHeader);
    let newText = document.createElement('input');
    let oldText = document.getElementById(`text${id}`);
    newText.className = "textInput";
    newText.id = `text${id}`;
    newText.value = array[id - 1].text;
    oldText.replaceWith(newText);
}