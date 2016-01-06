function ParseJson() {
    var text = '{"employees":[' +
'{"firstName":"John","lastName":"Doe" },' +
'{"firstName":"Anna","lastName":"Smith" },' +
'{"firstName":"Peter","lastName":"Jones" }]}';
    obj = JSON.parse(text);

    var ex = new RuntimeComponent1.Class1();

    console.log("creating object.");
    var tempEmployee = new Object();
    console.log("created object.");
    tempEmployee.firstName = "Varun";
    tempEmployee.lastName = "Sharma";
    return tempEmployee;
    //sendToHost(JSON.stringify(tempEmployee), "Employee");
}

ParseJson();