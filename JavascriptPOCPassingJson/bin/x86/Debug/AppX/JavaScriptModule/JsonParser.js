function ParseJson() {
    var text = '{"employees":[' +
'{"firstName":"John","lastName":"Doe" },' +
'{"firstName":"Anna","lastName":"Smith" },' +
'{"firstName":"Peter","lastName":"Jones" }]}';
    obj = JSON.parse(text);
    sendToHost(JSON.stringify(obj), "RootObject");
}

ParseJson();