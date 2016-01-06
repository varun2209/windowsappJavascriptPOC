function ParseJson() {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "Varun";
    tempEmployee.lastName = "Sharma";
    return JSON.constructor(tempEmployee);
    //sendToHost(JSON.stringify(tempEmployee), "Employee");
}

ParseJson();