function ParseJsonAndSendObject(jsonResponse) {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "David";
    tempEmployee.lastName = "Cathue";
    return tempEmployee;
    //this.EmployeeObject = tempEmployee;
    //var obj = JSON.parse(jsonResponse);
    //sendToHost(JSON.stringify(obj), "HomeSegmentModel");
}

function ParseJsonAndSendObjectUsingJSGlobalObjectMethod(jsonResponse) {
    var tempEmployee = new RuntimeComponent1.Employee();
    tempEmployee.firstName = "David";
    tempEmployee.lastName = "Cathue";
    sendToHost(JSON.stringify(tempEmployee), "Employee");
    //return tempEmployee;
    //this.EmployeeObject = tempEmployee;
    //var obj = JSON.parse(jsonResponse);
}

function CallNativeMethodFromJs() {
    var Employee = new RuntimeComponent1.Employee();
    Employee.firstName = "Hugo";
    Employee.lastName = "Boss";
    ///return RuntimeComponent1.Employee.sayHello(Employee);
    return Employee.employeeName();
}

function CallNativeStaticMethodFromJs() {
    return RuntimeComponent1.Employee.sayHello();
}

function GenericParserAuth(jsonResponse) {
    var obj = JSON.parse(jsonResponse);
    var TempAuthModel = new RuntimeComponent1.LoginResponseModel();
    TempAuthModel = obj;
    var bridgeObj = new RuntimeComponent1.CmdBridge();
    //bridgeObj.assignTempObjResult(TempAuthModel);
    var temp = new RuntimeComponent1.LoginResponseModel();
    var AuthModel = ParseModel(obj, temp);
}

function ParseModel(jsonObj, modelObject) {
    for (var jsonProperty in jsonObj) {
        var jsonValue = jsonObj[jsonProperty];
        if(jsonValue instanceof Object){
            modelObject[jsonProperty] = ParseModel(jsonValue,modelObject[jsonProperty]);
        }
        else if (jsonValue instanceof Array) {

        }
        else {
            modelObject[jsonProperty] = jsonValue;
        }
        }
    return modelObject;
}