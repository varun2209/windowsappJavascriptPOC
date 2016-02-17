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

function GetAllKeysCollection(obj) {
    var keysCollection = Object.keys(obj);
    var tempHolder = [];
    if (keysCollection.length > 0) {
        for (var i = 0; i < keysCollection.length; i++) {
            var tempKeysCollection = [];
            if (obj[keysCollection[i]] instanceof Object)
                tempKeysCollection = GetAllKeysCollection(obj[keysCollection[i]]);
 
            if (typeof tempKeysCollection != "undefined" && tempKeysCollection.length > 0)
                tempHolder.push(tempKeysCollection);
        }
        if (tempHolder.length > 0)
            keysCollection.push(tempHolder);
        return keysCollection;
    }
    return;
}

function GenericParserAuth(jsonResponse) {
    var obj = JSON.parse(jsonResponse);
    //var arr = Object.keys(obj).map(function (k) { return k });
    var keysCollection = GetAllKeysCollection(obj);
    var TempAuthModel = new RuntimeComponent1.LoginResponseModel();
    //TempAuthModel = obj;
    var bridgeObj = new RuntimeComponent1.CmdBridge();
    //bridgeObj.assignTempObjResult(TempAuthModel);
    var temp = new RuntimeComponent1.LoginResponseModel();
    var AuthModel = ParseModel(obj, temp);
    AuthModel.assignTempObjResult();
}

function ParseModel(jsonObj, modelObject) {
    for (var jsonProperty in jsonObj) {
        var jsonValue = jsonObj[jsonProperty];
        if (jsonProperty == "size_chart") {
            var temp = "size_chart";
        }
        if (jsonValue instanceof Object) {
            if (modelObject[jsonProperty] != undefined) {
                modelObject[jsonProperty] = ParseModel(jsonValue, modelObject[jsonProperty]);
            }
            else if (modelObject[jsonProperty] == undefined) {
                if (jsonValue instanceof Array) {
                    for (var arrayItem in jsonValue) {
                        var arrayItemResult = "";
                        if (jsonValue[arrayItem] instanceof Object)
                            arrayItemResult = ParseModel(jsonValue[arrayItem], modelObject[jsonProperty.concat("type")]);
                        else
                            arrayItemResult = jsonValue[arrayItem];
                        modelObject["addTo".concat(jsonProperty)](arrayItemResult);
                    }
                }
                else
                    modelObject = ParseModel(jsonValue, modelObject);
            }
        }
        else if (jsonValue instanceof Array) {
            var temp = "Array found";
        }
        else {
            if (typeof modelObject[jsonProperty] != "undefined")
                modelObject[jsonProperty] = jsonValue;
        }
    }
    return modelObject;
}