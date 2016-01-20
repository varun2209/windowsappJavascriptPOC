function ParseJsonAndSendObject(jsonResponse) {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "David";
    tempEmployee.lastName = "Chatue";
    return tempEmployee;
    //this.EmployeeObject = tempEmployee;
    //var obj = JSON.parse(jsonResponse);
    //sendToHost(JSON.stringify(obj), "HomeSegmentModel");
}

function ParseJsonAndSendObjectUsingJSGlobalObjectMethod(jsonResponse) {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "David";
    tempEmployee.lastName = "Chatue";
    sendToHost(JSON.stringify(tempEmployee), "Employee");
    //return tempEmployee;
    //this.EmployeeObject = tempEmployee;
    //var obj = JSON.parse(jsonResponse);
}

function CallNativeMethodFromJs() {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "David";
    tempEmployee.lastName = "Chatue";
    return tempEmployee.EmployeeName();
}

function CallNativeStaticMethodFromJs() {
    return  RuntimeComponent1.Employee.SayHello();
    }