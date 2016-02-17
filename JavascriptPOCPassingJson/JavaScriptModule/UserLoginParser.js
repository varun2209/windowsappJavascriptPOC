//TODO need to create separate base parser file
// BaseParser class
var BaseParser = function (json) {
    this.jsonData = json;
};


//Override this Parser method into child parser class
BaseParser.prototype.doParse = function () {
    this.data = JSON.parse(this.jsonData).data;
};

//UserLoginParser Class
function UserLoginParser(json) {
    BaseParser.prototype.constructor.call(this, json);
}

// Extend BaseParser class with UserLoginParser
UserLoginParser.prototype = Object.create(BaseParser.prototype);

//Override parser method
UserLoginParser.prototype.doParse = function () {
    BaseParser.prototype.doParse.call(this);  // calls super doParse function
    var favList = new UserLoginList();
    if (typeof this.data != undefined && this.data != null) {
        for (var i = 0; i < this.data.length; ++i) {
            var obj = this.data[i];
            var fav = this.createUserLoginObject(obj);
            var filters = obj.filter_data;
            if (filters != undefined && filters != null) {
                for (var j = 0; j < filters.length; ++j) {
                    var filter = filters[j];
                    var filterObj = this.createFilterDataObject(filter);
                    fav.addFilterData(filterObj);
                }
            }
            favList.add(fav);
        }
    }
    return favList;
};

//UserLoginParser.prototype.createUserLoginObject = function (obj) {
//    var fav = new UserLogin();
//    fav.id = obj.id;
//    fav.label = obj.label;
//    fav.url = obj.url;
//    fav.description = obj.description;
//    fav.filterHash = obj.filter_hash;
//    fav.imageUrl = obj.image;
//    return fav;
//}

//UserLoginParser.prototype.createFilterDataObject = function (filter) {
//    var filterObj = new FilterData();
//    filterObj.key = filter.key;
//    filterObj.value = filter.value;
//    return filterObj;
//}

UserLoginParser.prototype.fillObject = function (jsonObj) {
    var fav = new UserLogin();
    for (var jsonProperty in jsonObj) {
        fav[jsonProperty] = jsonObj[jsonProperty];
    }
}

function parseUserLogin(json) {
    var UserLogin = new UserLoginParser(json);
    return UserLogin.doParse();
}