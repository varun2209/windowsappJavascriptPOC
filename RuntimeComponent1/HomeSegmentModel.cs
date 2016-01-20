using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
public sealed class AppCacheMt
{
    public int segments { get; set; }
    public int menu { get; set; }
    public int md5 { get; set; }
    public string stmsgv { get; set; }
    public string hpbr { get; set; }
    public int ct { get; set; }
    public int bts { get; set; }
}

public sealed class Session
{
    public string id { get; set; }
    public object expire { get; set; }
    public bool is_loggedin { get; set; }
    public AppCacheMt app_cache_mt { get; set; }
    public string YII_CSRF_TOKEN { get; set; }
    public object rpid { get; set; }
}

public sealed class ServerFlags
{
    public int webp_enabled { get; set; }
    public int gn_enabled { get; set; }
}

public sealed class GetStaticBlocks
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class Param
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params
{
    public Param param { get; set; }
}

public sealed class HomepageSlider
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params @params { get; set; }
}

public sealed class Param2
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params2
{
    public Param2 param { get; set; }
}

public sealed class SegmentpageBanner
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params2 @params { get; set; }
}

public sealed class MainMenu
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class HomeSegment
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class Brands
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class Param3
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params3
{
    public Param3 param { get; set; }
}

public sealed class GetRecentlyViewedProducts
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params3 @params { get; set; }
}

public sealed class Param4
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params4
{
    public Param4 param { get; set; }
}

public sealed class GetStaticContent
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params4 @params { get; set; }
}

public sealed class GetStaticMessage
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class CatalogFacetPriority
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class Param5
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params5
{
    public Param5 param { get; set; }
}

public sealed class Search
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params5 @params { get; set; }
}

public sealed class Param6
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params6
{
    public Param6 param { get; set; }
}

public sealed class SearchSuggest
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params6 @params { get; set; }
}

public sealed class Param7
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params7
{
    public Param7 param { get; set; }
}

public sealed class SearchAutosuggest
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params7 @params { get; set; }
}

public sealed class Param8
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params8
{
    public IEnumerable<Param8> param { get; set; }
}

public sealed class AddToShortlist
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params8 @params { get; set; }
}

public sealed class Param9
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params9
{
    public Param9 param { get; set; }
}

public sealed class GetShortlistForLoggedInUser
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params9 @params { get; set; }
}

public sealed class Param10
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params10
{
    public IEnumerable<Param10> param { get; set; }
}

public sealed class GetShortlistForGuestUser
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params10 @params { get; set; }
}

public sealed class Param11
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params11
{
    public IEnumerable<Param11> param { get; set; }
}

public sealed class RemoveFromShortlist
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params11 @params { get; set; }
}

public sealed class Param12
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params12
{
    public Param12 param { get; set; }
}

public sealed class RemoveAllShortlist
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params12 @params { get; set; }
}

public sealed class Param13
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params13
{
    public IEnumerable<Param13> param { get; set; }
}

public sealed class SyncShortlistOnLogin
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params13 @params { get; set; }
}

public sealed class Param14
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params14
{
    public IEnumerable<Param14> param { get; set; }
}

public sealed class ProductDetail
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params14 @params { get; set; }
}

public sealed class Param15
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params15
{
    public IEnumerable<Param15> param { get; set; }
}

public sealed class ProductPincodeCheck
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params15 @params { get; set; }
}

public sealed class Param16
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params16
{
    public IEnumerable<Param16> param { get; set; }
}

public sealed class AddToCart
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params16 @params { get; set; }
}

public sealed class Param17
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params17
{
    public IEnumerable<Param17> param { get; set; }
}

public sealed class RemoveFromCart
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params17 @params { get; set; }
}

public sealed class Param18
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params18
{
    public Param18 param { get; set; }
}

public sealed class CartData
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params18 @params { get; set; }
}

public sealed class Param19
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params19
{
    public IEnumerable<Param19> param { get; set; }
}

public sealed class UpdateItemQtyCart
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params19 @params { get; set; }
}

public sealed class Param20
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params20
{
    public IEnumerable<Param20> param { get; set; }
}

public sealed class ApplyVoucherCart
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params20 @params { get; set; }
}

public sealed class Param21
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params21
{
    public IEnumerable<Param21> param { get; set; }
}

public sealed class RemoveVoucherCart
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params21 @params { get; set; }
}

public sealed class Param22
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params22
{
    public Param22 param { get; set; }
}

public sealed class GetVoucherList
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params22 @params { get; set; }
}

public sealed class Param23
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params23
{
    public IEnumerable<Param23> param { get; set; }
}

public sealed class UserLogin
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params23 @params { get; set; }
}

public sealed class Param24
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params24
{
    public Param24 param { get; set; }
}

public sealed class UserLogout
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params24 @params { get; set; }
}

public sealed class Param25
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params25
{
    public IEnumerable<Param25> param { get; set; }
}

public sealed class UserSignup
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params25 @params { get; set; }
}

public sealed class Param26
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params26
{
    public Param26 param { get; set; }
}

public sealed class UserForgotPassword
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params26 @params { get; set; }
}

public sealed class Param27
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params27
{
    public Param27 param { get; set; }
}

public sealed class UserDetails
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params27 @params { get; set; }
}

public sealed class UserAutoLogin
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
}

public sealed class Param28
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params28
{
    public IEnumerable<Param28> param { get; set; }
}

public sealed class CheckoutAsGuest
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params28 @params { get; set; }
}

public sealed class Param29
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params29
{
    public IEnumerable<Param29> param { get; set; }
}

public sealed class PincodeLookup
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params29 @params { get; set; }
}

public sealed class Param30
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params30
{
    public Param30 param { get; set; }
}

public sealed class CustomerExistingAddresses
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params30 @params { get; set; }
}

public sealed class Param31
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params31
{
    public IEnumerable<Param31> param { get; set; }
}

public sealed class AddShippingAddressCheckoutForGuestUser
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params31 @params { get; set; }
}

public sealed class Param32
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params32
{
    public IEnumerable<Param32> param { get; set; }
}

public sealed class AddShippingAddressCheckoutForExistingMember
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params32 @params { get; set; }
}

public sealed class Param33
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params33
{
    public IEnumerable<Param33> param { get; set; }
}

public sealed class SetAddressAsShippingAddressCheckoutForExistingMember
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params33 @params { get; set; }
}

public sealed class Param34
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params34
{
    public IEnumerable<Param34> param { get; set; }
}

public sealed class ApplyAllJabongCredits
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params34 @params { get; set; }
}

public sealed class Param35
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params35
{
    public IEnumerable<Param35> param { get; set; }
}

public sealed class ApplySomeAmountFromJabongCredits
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params35 @params { get; set; }
}

public sealed class Param36
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params36
{
    public IEnumerable<Param36> param { get; set; }
}

public sealed class GetCodCharges
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params36 @params { get; set; }
}

public sealed class Param37
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params37
{
    public IEnumerable<Param37> param { get; set; }
}

public sealed class CodPayment
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params37 @params { get; set; }
}

public sealed class Param38
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params38
{
    public Param38 param { get; set; }
}

public sealed class GetPaymentOptions
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params38 @params { get; set; }
}

public sealed class Param39
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params39
{
    public Param39 param { get; set; }
}

public sealed class GetShippingData
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params39 @params { get; set; }
}

public sealed class Param40
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params40
{
    public IEnumerable<Param40> param { get; set; }
}

public sealed class SetPgFormFieldData
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params40 @params { get; set; }
}

public sealed class Param41
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params41
{
    public Param41 param { get; set; }
}

public sealed class GetBankList
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params41 @params { get; set; }
}

public sealed class Param42
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params42
{
    public IEnumerable<Param42> param { get; set; }
}

public sealed class PgNetbanking
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params42 @params { get; set; }
}

public sealed class Param43
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params43
{
    public IEnumerable<Param43> param { get; set; }
}

public sealed class PgExpressCheckout
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params43 @params { get; set; }
}

public sealed class Param44
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params44
{
    public IEnumerable<Param44> param { get; set; }
}

public sealed class RedeemJabongCredits
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params44 @params { get; set; }
}

public sealed class Param45
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params45
{
    public IEnumerable<Param45> param { get; set; }
}

public sealed class AddGiftWrap
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params45 @params { get; set; }
}

public sealed class Param46
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params46
{
    public Param46 param { get; set; }
}

public sealed class RemoveGiftWrap
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params46 @params { get; set; }
}

public sealed class Param47
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params47
{
    public IEnumerable<Param47> param { get; set; }
}

public sealed class GetOrdersForTracking
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params47 @params { get; set; }
}

public sealed class Param48
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params48
{
    public IEnumerable<Param48> param { get; set; }
}

public sealed class GetOrderDetailsForTracking
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params48 @params { get; set; }
}

public sealed class Param49
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params49
{
    public IEnumerable<Param49> param { get; set; }
}

public sealed class ShopTheLook
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params49 @params { get; set; }
}

public sealed class Param50
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params50
{
    public IEnumerable<Param50> param { get; set; }
}

public sealed class AddToCartMulti
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params50 @params { get; set; }
}

public sealed class Param51
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params51
{
    public IEnumerable<Param51> param { get; set; }
}

public sealed class SaleOffers
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params51 @params { get; set; }
}

public sealed class Param52
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params52
{
    public IEnumerable<Param52> param { get; set; }
}

public sealed class SearchByImageCamApi
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params52 @params { get; set; }
}

public sealed class Param53
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params53
{
    public IEnumerable<Param53> param { get; set; }
}

public sealed class SearchByTokenCamApi
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params53 @params { get; set; }
}

public sealed class Param54
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params54
{
    public IEnumerable<Param54> param { get; set; }
}

public sealed class SearchByImageMashape
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params54 @params { get; set; }
}

public sealed class Param55
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params55
{
    public IEnumerable<Param55> param { get; set; }
}

public sealed class SearchByTokenMashape
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params55 @params { get; set; }
}

public sealed class Param56
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params56
{
    public IEnumerable<Param56> param { get; set; }
}

public sealed class MoveToShortlsit
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params56 @params { get; set; }
}

public sealed class Param57
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params57
{
    public IEnumerable<Param57> param { get; set; }
}

public sealed class GetSizeChart
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params57 @params { get; set; }
}

public sealed class Param58
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params58
{
    public Param58 param { get; set; }
}

public sealed class ReturnListing
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params58 @params { get; set; }
}

public sealed class Param59
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params59
{
    public IEnumerable<Param59> param { get; set; }
}

public sealed class ReturnDetail
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params59 @params { get; set; }
}

public sealed class Param60
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params60
{
    public IEnumerable<Param60> param { get; set; }
}

public sealed class ReturnInitiateStepOne
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params60 @params { get; set; }
}

public sealed class Param61
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params61
{
    public IEnumerable<Param61> param { get; set; }
}

public sealed class GetSecondaryReasons
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params61 @params { get; set; }
}

public sealed class Param62
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params62
{
    public IEnumerable<Param62> param { get; set; }
}

public sealed class ReturnInitiateStepTwo
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params62 @params { get; set; }
}

public sealed class Param63
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params63
{
    public IEnumerable<Param63> param { get; set; }
}

public sealed class PincodeServiceablityNewAddressOrderReturn
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params63 @params { get; set; }
}

public sealed class Param64
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params64
{
    public IEnumerable<Param64> param { get; set; }
}

public sealed class AddNewAddressOrderReturn
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params64 @params { get; set; }
}

public sealed class Param65
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params65
{
    public IEnumerable<Param65> param { get; set; }
}

public sealed class DropOffServiceablity
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params65 @params { get; set; }
}

public sealed class Param66
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params66
{
    public IEnumerable<Param66> param { get; set; }
}

public sealed class OrderReturnSummary
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params66 @params { get; set; }
}

public sealed class Param67
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params67
{
    public Param67 param { get; set; }
}

public sealed class OrderReturnThankYou
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params67 @params { get; set; }
}

public sealed class Param68
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params68
{
    public Param68 param { get; set; }
}

public sealed class GetWalletList
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params68 @params { get; set; }
}

public sealed class Param69
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params69
{
    public IEnumerable<Param69> param { get; set; }
}

public sealed class CaptureDeviceInfo
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params69 @params { get; set; }
}

public sealed class Param70
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params70
{
    public IEnumerable<Param70> param { get; set; }
}

public sealed class AppCallbackPaymentFailure
{
    public string name { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params70 @params { get; set; }
}

public sealed class Param71
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params71
{
    public Param71 param { get; set; }
}

public sealed class GetBanner
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params71 @params { get; set; }
}

public sealed class Param72
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params72
{
    public Param72 param { get; set; }
}

public sealed class GetSmsOptStatus
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params72 @params { get; set; }
}

public sealed class Param73
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params73
{
    public Param73 param { get; set; }
}

public sealed class RefreshApp
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params73 @params { get; set; }
}

public sealed class Param74
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params74
{
    public Param74 param { get; set; }
}

public sealed class GetUpdatedUserInfo
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params74 @params { get; set; }
}

public sealed class Param75
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params75
{
    public IEnumerable<Param75> param { get; set; }
}

public sealed class SaveFavshop
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params75 @params { get; set; }
}

public sealed class Param76
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params76
{
    public IEnumerable<Param76> param { get; set; }
}

public sealed class GetFavshopItems
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params76 @params { get; set; }
}

public sealed class Param77
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params77
{
    public IEnumerable<Param77> param { get; set; }
}

public sealed class DeleteFavshopItems
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params77 @params { get; set; }
}

public sealed class Param78
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params78
{
    public IEnumerable<Param78> param { get; set; }
}

public sealed class RenameFavshopItems
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params78 @params { get; set; }
}

public sealed class Param79
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params79
{
    public Param79 param { get; set; }
}

public sealed class CheckGoogleNowToken
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params79 @params { get; set; }
}

public sealed class Param80
{
    public string key { get; set; }
    public string key_value { get; set; }
    public string required { get; set; }
    public string guest_user { get; set; }
    public string loggedin_user { get; set; }
}

public sealed class Params80
{
    public IEnumerable<Param80> param { get; set; }
}

public sealed class AddGoogleNowToken
{
    public string name { get; set; }
    public string cacheresponsetimeunit { get; set; }
    public string cacheresponsetime { get; set; }
    public string apiurl { get; set; }
    public string is_ssl { get; set; }
    public string method { get; set; }
    public Params80 @params { get; set; }
}

public sealed class Key
{
    public GetStaticBlocks get_static_blocks { get; set; }
    public HomepageSlider homepage_slider { get; set; }
    public SegmentpageBanner segmentpage_banner { get; set; }
    public MainMenu main_menu { get; set; }
    public HomeSegment home_segment { get; set; }
    public Brands brands { get; set; }
    public GetRecentlyViewedProducts get_recently_viewed_products { get; set; }
    public GetStaticContent get_static_content { get; set; }
    public GetStaticMessage get_static_message { get; set; }
    public CatalogFacetPriority catalog_facet_priority { get; set; }
    public Search search { get; set; }
    public SearchSuggest search_suggest { get; set; }
    public SearchAutosuggest search_autosuggest { get; set; }
    public AddToShortlist add_to_shortlist { get; set; }
    public GetShortlistForLoggedInUser get_shortlist_for_logged_in_user { get; set; }
    public GetShortlistForGuestUser get_shortlist_for_guest_user { get; set; }
    public RemoveFromShortlist remove_from_shortlist { get; set; }
    public RemoveAllShortlist remove_all_shortlist { get; set; }
    public SyncShortlistOnLogin sync_shortlist_on_login { get; set; }
    public ProductDetail product_detail { get; set; }
    public ProductPincodeCheck product_pincode_check { get; set; }
    public AddToCart add_to_cart { get; set; }
    public RemoveFromCart remove_from_cart { get; set; }
    public CartData cart_data { get; set; }
    public UpdateItemQtyCart update_item_qty_cart { get; set; }
    public ApplyVoucherCart apply_voucher_cart { get; set; }
    public RemoveVoucherCart remove_voucher_cart { get; set; }
    public GetVoucherList get_voucher_list { get; set; }
    public UserLogin user_login { get; set; }
    public UserLogout user_logout { get; set; }
    public UserSignup user_signup { get; set; }
    public UserForgotPassword user_forgot_password { get; set; }
    public UserDetails user_details { get; set; }
    public UserAutoLogin user_auto_login { get; set; }
    public CheckoutAsGuest checkout_as_guest { get; set; }
    public PincodeLookup pincode_lookup { get; set; }
    public CustomerExistingAddresses customer_existing_addresses { get; set; }
    public AddShippingAddressCheckoutForGuestUser add_shipping_address_checkout_for_guest_user { get; set; }
    public AddShippingAddressCheckoutForExistingMember add_shipping_address_checkout_for_existing_member { get; set; }
    public SetAddressAsShippingAddressCheckoutForExistingMember set_address_as_shipping_address_checkout_for_existing_member { get; set; }
    public ApplyAllJabongCredits apply_all_jabong_credits { get; set; }
    public ApplySomeAmountFromJabongCredits apply_some_amount_from_jabong_credits { get; set; }
    public GetCodCharges get_cod_charges { get; set; }
    public CodPayment cod_payment { get; set; }
    public GetPaymentOptions get_payment_options { get; set; }
    public GetShippingData get_shipping_data { get; set; }
    public SetPgFormFieldData set_pg_form_field_data { get; set; }
    public GetBankList get_bank_list { get; set; }
    public PgNetbanking pg_netbanking { get; set; }
    public PgExpressCheckout pg_express_checkout { get; set; }
    public RedeemJabongCredits redeem_jabong_credits { get; set; }
    public AddGiftWrap add_gift_wrap { get; set; }
    public RemoveGiftWrap remove_gift_wrap { get; set; }
    public GetOrdersForTracking get_orders_for_tracking { get; set; }
    public GetOrderDetailsForTracking get_order_details_for_tracking { get; set; }
    public ShopTheLook shop_the_look { get; set; }
    public AddToCartMulti add_to_cart_multi { get; set; }
    public SaleOffers sale_offers { get; set; }
    public SearchByImageCamApi search_by_image_cam_api { get; set; }
    public SearchByTokenCamApi search_by_token_cam_api { get; set; }
    public SearchByImageMashape search_by_image_mashape { get; set; }
    public SearchByTokenMashape search_by_token_mashape { get; set; }
    public MoveToShortlsit move_to_shortlsit { get; set; }
    public GetSizeChart get_size_chart { get; set; }
    public ReturnListing return_listing { get; set; }
    public ReturnDetail return_detail { get; set; }
    public ReturnInitiateStepOne return_initiate_step_one { get; set; }
    public GetSecondaryReasons get_secondary_reasons { get; set; }
    public ReturnInitiateStepTwo return_initiate_step_two { get; set; }
    public PincodeServiceablityNewAddressOrderReturn pincode_serviceablity_new_address_order_return { get; set; }
    public AddNewAddressOrderReturn add_new_address_order_return { get; set; }
    public DropOffServiceablity drop_off_serviceablity { get; set; }
    public OrderReturnSummary order_return_summary { get; set; }
    public OrderReturnThankYou order_return_thank_you { get; set; }
    public GetWalletList get_wallet_list { get; set; }
    public CaptureDeviceInfo capture_device_info { get; set; }
    public AppCallbackPaymentFailure app_callback_payment_failure { get; set; }
    public GetBanner get_banner { get; set; }
    public GetSmsOptStatus get_sms_opt_status { get; set; }
    public RefreshApp refresh_app { get; set; }
    public GetUpdatedUserInfo get_updated_user_info { get; set; }
    public SaveFavshop save_favshop { get; set; }
    public GetFavshopItems get_favshop_items { get; set; }
    public DeleteFavshopItems delete_favshop_items { get; set; }
    public RenameFavshopItems rename_favshop_items { get; set; }
    public CheckGoogleNowToken check_google_now_token { get; set; }
    public AddGoogleNowToken add_google_now_token { get; set; }
}

public sealed class Configuration
{
    public string key { get; set; }
    public string value { get; set; }
}

public sealed class Occasion
{
    public string name { get; set; }
    public string icon_image { get; set; }
    public string color { get; set; }
}

public sealed class OccasionInfo
{
    public IEnumerable<Occasion> occasion { get; set; }
}

public sealed class Type
{
    public string name { get; set; }
    public string regex { get; set; }
    public string status { get; set; }
}

public sealed class CardInfo
{
    public IEnumerable<Type> type { get; set; }
}

public sealed class Config
{
    public IEnumerable<Configuration> configuration { get; set; }
    public OccasionInfo occasion_info { get; set; }
    public CardInfo card_info { get; set; }
}

public sealed class Md5
{
    public Key key { get; set; }
    public Config config { get; set; }
}

public sealed class ExtraMenuItem
{
    public string key { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public string icon_selected { get; set; }
    public string android_icon { get; set; }
    public string url { get; set; }
}

public sealed class Quicklink
{
    public string key { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public string icon_selected { get; set; }
    public string android_icon { get; set; }
}

public sealed class ShareFeedback
{
    public string key { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public string icon_selected { get; set; }
    public string android_icon { get; set; }
}

public sealed class HelpAndSupport
{
    public string key { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public string icon_selected { get; set; }
    public string android_icon { get; set; }
    public string url { get; set; }
}

public sealed class Icon
{
    public IEnumerable<ExtraMenuItem> extra_menu_item { get; set; }
    public IEnumerable<Quicklink> quicklink { get; set; }
    public IEnumerable<ShareFeedback> share_feedback { get; set; }
    public IEnumerable<HelpAndSupport> help_and_support { get; set; }
}

public sealed class Miscellaneou
{
    public string key { get; set; }
    public string value { get; set; }
}

public sealed class Attributes
{
    public string name { get; set; }
    public string icon { get; set; }
}

public sealed class Mastercard
{
    public Attributes __invalid_name { get; set; }
}

public sealed class Attributes2
{
    public string name { get; set; }
    public string icon { get; set; }
}

public sealed class Visa
{
    public Attributes2 __invalid_name { get; set; }
}

public sealed class Attributes3
{
    public string name { get; set; }
    public string icon { get; set; }
}

public sealed class Maestro
{
    public Attributes3 __invalid_name { get; set; }
}

public sealed class Attributes4
{
    public string name { get; set; }
    public string icon { get; set; }
}

public sealed class WesternUnion
{
    public Attributes4 __invalid_name { get; set; }
}

public sealed class Attributes5
{
    public string name { get; set; }
    public string icon { get; set; }
}



public sealed class Attributes6
{
    public string name { get; set; }
    public string icon { get; set; }
}

public sealed class Attributes7
{
    public string name { get; set; }
    public string icon { get; set; }
}


public sealed class Attributes8
{
    public string name { get; set; }
    public string icon { get; set; }
}


public sealed class Cardtype
{
   
    public Visa visa { get; set; }
    public Maestro maestro { get; set; }
    public WesternUnion western_union { get; set; }
   }

public sealed class Menu
{
    public Cardtype cardtype { get; set; }
    public string feedback { get; set; }
    public string callus { get; set; }
}

public sealed class Segment
{
    public IEnumerable<string> men { get; set; }
    public IEnumerable<string> women { get; set; }
    public IEnumerable<string> kids { get; set; }
    public IEnumerable<string> home_fashion { get; set; }
}

public sealed class SortOrder
{
    public IEnumerable<string> home { get; set; }
    public Segment segment { get; set; }
}

public sealed class Banners
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class Offers
{
    public Banners banners { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
    public string key { get; set; }
}

public sealed class Segments
{
    public IEnumerable<Banner> banners { get; set; }
    public IEnumerable<object> title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner2
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class FeaturedStores
{
    public IEnumerable<Banner2> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner3
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class PremiumBrands
{
    public IEnumerable<Banner3> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner4
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class Discovery
{
    public IEnumerable<Banner4> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Home
{
    public Offers offers { get; set; }
    public Segments segments { get; set; }
    public FeaturedStores featured_stores { get; set; }
    public PremiumBrands premium_brands { get; set; }
    public Discovery discovery { get; set; }
}

public sealed class Banners2
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class Offers2
{
    public Banners2 banners { get; set; }
    public string view_type { get; set; }
}

public sealed class Subcategory
{
    public string link { get; set; }
    public string name { get; set; }
}

public sealed class Subcategories
{
    public IEnumerable<Subcategory> subcategory { get; set; }
}

public sealed class Category
{
    public string image { get; set; }
    public string link { get; set; }
    public string name { get; set; }
    public Subcategories subcategories { get; set; }
}

public sealed class Categories
{
    public IEnumerable<Category> category { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner5
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class NewArrivals
{
    public IEnumerable<Banner5> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner6
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class PremiumBrands2
{
    public IEnumerable<Banner6> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner7
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class Discovery2
{
    public IEnumerable<Banner7> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Banner8
{
    public string image { get; set; }
    public string link { get; set; }
    public string design { get; set; }
    public string name { get; set; }
}

public sealed class BestNewIn
{
    public IEnumerable<Banner8> banners { get; set; }
    public string title { get; set; }
    public string view_type { get; set; }
}

public sealed class Segment2
{
    public string banner_image { get; set; }
    public string image { get; set; }
    public string link { get; set; }
    public string name { get; set; }
    public string key { get; set; }
    public string icon { get; set; }
    public string android_icon { get; set; }
    public Offers2 offers { get; set; }
    public Categories categories { get; set; }
    public NewArrivals new_arrivals { get; set; }
    public PremiumBrands2 premium_brands { get; set; }
    public Discovery2 discovery { get; set; }
    public BestNewIn best_new_in { get; set; }
}

public sealed class Segments2
{
    public IEnumerable<Segment2> segment { get; set; }
}

public sealed class Sale
{
    public string image { get; set; }
    public string link { get; set; }
}

public sealed class StyleFeed
{
    public string image { get; set; }
    public string link { get; set; }
    public string name { get; set; }
}

public sealed class StyleFeeds
{
    public string enable { get; set; }
    public string pos { get; set; }
    public IEnumerable<StyleFeed> style_feed { get; set; }
}

public sealed class Brand
{
    public string image { get; set; }
    public string link { get; set; }
}

public sealed class Brands2
{
    public IEnumerable<Brand> brand { get; set; }
}

public sealed class Offer
{
    public string image { get; set; }
    public string link { get; set; }
}

public sealed class Offers3
{
    public Offer offer { get; set; }
}

public sealed class Banner9
{
    public string image { get; set; }
}

public sealed class Android
{
    public string supported_os { get; set; }
    public string enabled_tablet { get; set; }
    public string enabled_phone { get; set; }
}

public sealed class Ios
{
    public string enabled_tablet { get; set; }
    public string enabled_phone { get; set; }
}

public sealed class Windows
{
    public string enabled_tablet { get; set; }
    public string enabled_phone { get; set; }
}

public sealed class ImageSearch
{
    public IEnumerable<Banner9> banner { get; set; }
    public Android android { get; set; }
    public Ios ios { get; set; }
    public Windows windows { get; set; }
}

public sealed class Editorial
{
    public string image { get; set; }
    public string link { get; set; }
    public string heading { get; set; }
    public string sub_heading { get; set; }
}

public sealed class Designer
{
    public string name { get; set; }
    public string image { get; set; }
    public string link { get; set; }
}

public sealed class Link
{
    public IEnumerable<object> image { get; set; }
    public string url { get; set; }
    public string key { get; set; }
}

public sealed class Links
{
    public Link link { get; set; }
}

public sealed class Category2
{
    public string image { get; set; }
    public string link { get; set; }
    public string name { get; set; }
}

public sealed class Categories2
{
    public IEnumerable<Category2> category { get; set; }
    public string view_type { get; set; }
}

public sealed class Segment3
{
    public string banner_image { get; set; }
    public string link { get; set; }
    public string name { get; set; }
    public string key { get; set; }
    public Categories2 categories { get; set; }
}

public sealed class Windows2
{
    public IEnumerable<Editorial> editorial { get; set; }
    public IEnumerable<Designer> designers { get; set; }
    public Links links { get; set; }
    public Segment3 segment { get; set; }
}

public sealed class HomeSegment2
{
    public SortOrder sort_order { get; set; }
    public Home home { get; set; }
    public Segments2 segments { get; set; }
    public Sale sale { get; set; }
    public StyleFeeds style_feeds { get; set; }
    public Brands2 brands { get; set; }
    public Offers3 offers { get; set; }
    public ImageSearch image_search { get; set; }
    public Windows2 windows { get; set; }
}

public sealed class IpadL
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class IpadLR
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class IpadP
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class IpadPR
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class Iphone
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class IphoneR
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class IphoneRHD
{
    public string PDPKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string recentlyViewedKey { get; set; }
}

public sealed class Wvga
{
    public string productKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string thumbnailKey { get; set; }
    public string zoomKey { get; set; }
}

public sealed class Wxga
{
    public string productKey { get; set; }
    public string cartKey { get; set; }
    public string catalogKey { get; set; }
    public string moreColorsKey { get; set; }
    public string thumbnailKey { get; set; }
    public string zoomKey { get; set; }
}

public sealed class DeviceBaseImages
{
    public IpadL ipad_L { get; set; }
    public IpadLR ipad_LR { get; set; }
    public IpadP ipad_P { get; set; }
    public IpadPR ipad_PR { get; set; }
    public Iphone iphone { get; set; }
    public IphoneR iphone_R { get; set; }
    public IphoneRHD iphone_RHD { get; set; }
    public Wvga wvga { get; set; }
    public Wxga wxga { get; set; }
}

public sealed class LoginForm
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class RegistrationForm
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class CheckoutForm
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class NewsLetterForm
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class ForgotPasswordForm
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class Email
{
    public string title { get; set; }
    public LoginForm loginForm { get; set; }
    public RegistrationForm registrationForm { get; set; }
    public CheckoutForm checkoutForm { get; set; }
    public NewsLetterForm newsLetterForm { get; set; }
    public ForgotPasswordForm forgotPasswordForm { get; set; }
}

public sealed class LoginForm2
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
}

public sealed class RegistrationForm2
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
}

public sealed class CheckoutForm2
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
}

public sealed class Password
{
    public string title { get; set; }
    public LoginForm2 loginForm { get; set; }
    public RegistrationForm2 registrationForm { get; set; }
    public CheckoutForm2 checkoutForm { get; set; }
}

public sealed class Regex
{
    public string @default { get; set; }
}

public sealed class RegistrationForm3
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class Regex2
{
    public string @default { get; set; }
}

public sealed class ShippingAddressForm
{
    public string name_title { get; set; }
    public int max_char { get; set; }
    public Regex2 regex { get; set; }
    public string blank { get; set; }
    public string invalid_regex { get; set; }
    public string name_invalid_regex { get; set; }
}

public sealed class FirstName
{
    public string title { get; set; }
    public Regex regex { get; set; }
    public RegistrationForm3 registrationForm { get; set; }
    public ShippingAddressForm shippingAddressForm { get; set; }
}

public sealed class Regex3
{
    public string @default { get; set; }
}

public sealed class RegistrationForm4
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class ShippingAddressForm2
{
    public string blank { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class LastName
{
    public string title { get; set; }
    public Regex3 regex { get; set; }
    public RegistrationForm4 registrationForm { get; set; }
    public ShippingAddressForm2 shippingAddressForm { get; set; }
}

public sealed class RegistrationForm5
{
    public string blank { get; set; }
}

public sealed class ShippingAddressForm3
{
    public string blank { get; set; }
}

public sealed class Gender
{
    public string title { get; set; }
    public RegistrationForm5 registrationForm { get; set; }
    public ShippingAddressForm3 shippingAddressForm { get; set; }
}

public sealed class Regex4
{
    public string @default { get; set; }
}

public sealed class RegistrationForm6
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class ShippingAddressForm4
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class AddAddressForm
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string blank { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class Mobile
{
    public string title { get; set; }
    public Regex4 regex { get; set; }
    public RegistrationForm6 registrationForm { get; set; }
    public ShippingAddressForm4 shippingAddressForm { get; set; }
    public AddAddressForm addAddressForm { get; set; }
}

public sealed class Regex5
{
    public string @default { get; set; }
}

public sealed class RegistrationForm7
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class ShippingAddressForm5
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class AddAddressForm2
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
}

public sealed class Phone
{
    public string title { get; set; }
    public Regex5 regex { get; set; }
    public RegistrationForm7 registrationForm { get; set; }
    public ShippingAddressForm5 shippingAddressForm { get; set; }
    public AddAddressForm2 addAddressForm { get; set; }
}

public sealed class ShippingAddressForm6
{
    public string blank { get; set; }
}

public sealed class AddAddressForm3
{
    public string blank { get; set; }
}

public sealed class Address
{
    public string title { get; set; }
    public ShippingAddressForm6 shippingAddressForm { get; set; }
    public AddAddressForm3 addAddressForm { get; set; }
}

public sealed class Regex6
{
    public string @default { get; set; }
}

public sealed class ShippingAddressForm7
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
    public string blank { get; set; }
}

public sealed class AddAddressForm4
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
    public string blank { get; set; }
}

public sealed class PdpCodCheck
{
    public int min_char { get; set; }
    public int max_char { get; set; }
    public string invalid { get; set; }
    public string min_length { get; set; }
    public string max_length { get; set; }
    public string invalid_regex { get; set; }
    public string blank { get; set; }
}

public sealed class Pincode
{
    public string title { get; set; }
    public Regex6 regex { get; set; }
    public ShippingAddressForm7 shippingAddressForm { get; set; }
    public AddAddressForm4 addAddressForm { get; set; }
    public PdpCodCheck pdpCodCheck { get; set; }
}

public sealed class Netbanking
{
    public string blank { get; set; }
}

public sealed class CreditCard
{
    public string blank { get; set; }
    public string isNumeric { get; set; }
}

public sealed class DebitCard
{
    public string blank { get; set; }
    public string isNumeric { get; set; }
}

public sealed class BankName
{
    public string title { get; set; }
    public Netbanking netbanking { get; set; }
    public CreditCard creditCard { get; set; }
    public DebitCard debitCard { get; set; }
}

public sealed class Regex7
{
    public string mastercard { get; set; }
    public string visa { get; set; }
    public string dinersclub { get; set; }
    public string jcb { get; set; }
    public string americanexpress { get; set; }
    public string discover { get; set; }
}

public sealed class CreditCard2
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class DebitCard2
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class CardNumber
{
    public string title { get; set; }
    public Regex7 regex { get; set; }
    public CreditCard2 creditCard { get; set; }
    public DebitCard2 debitCard { get; set; }
}

public sealed class CreditCard3
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class DebitCard3
{
    public string blank { get; set; }
    public string invalid { get; set; }
}

public sealed class Cvv
{
    public string title { get; set; }
    public CreditCard3 creditCard { get; set; }
    public DebitCard3 debitCard { get; set; }
}

public sealed class CardExpiryDate
{
    public string blank { get; set; }
}

public sealed class GiftWrapForm
{
    public int max_char { get; set; }
    public string max_length { get; set; }
    public string blank { get; set; }
}

public sealed class Recipient
{
    public string title { get; set; }
    public GiftWrapForm giftWrapForm { get; set; }
}

public sealed class GiftWrapForm2
{
    public int max_char { get; set; }
    public string max_length { get; set; }
    public string blank { get; set; }
}

public sealed class Sender
{
    public string title { get; set; }
    public GiftWrapForm2 giftWrapForm { get; set; }
}

public sealed class GiftWrapForm3
{
    public int max_char { get; set; }
    public string max_length { get; set; }
}

public sealed class Message
{
    public string title { get; set; }
    public GiftWrapForm3 giftWrapForm { get; set; }
}

public sealed class Occasion2
{
    public string title { get; set; }
}

public sealed class SmsOpt
{
    public string message { get; set; }
}

public sealed class StaticMessage
{
    public Email email { get; set; }
    public Password password { get; set; }
    public FirstName first_name { get; set; }
    public LastName last_name { get; set; }
    public Gender gender { get; set; }
    public Mobile mobile { get; set; }
    public Phone phone { get; set; }
    public Address address { get; set; }
    public Pincode pincode { get; set; }
    public BankName bankName { get; set; }
    public CardNumber cardNumber { get; set; }
    public Cvv cvv { get; set; }
    public CardExpiryDate card_expiry_date { get; set; }
    public Recipient recipient { get; set; }
    public Sender sender { get; set; }
    public Message message { get; set; }
    public Occasion2 occasion { get; set; }
    public SmsOpt sms_opt { get; set; }
}

public sealed class Data
{
    //public Md5 md5 { get; set; }
    //public Menu menu { get; set; }
    public HomeSegment2 home_segment { get; set; }
    public IEnumerable<string> facet_priority { get; set; }
    public DeviceBaseImages device_base_images { get; set; }
    public StaticMessage staticMessage { get; set; }
}

public sealed class Metadata
{
    public string md5 { get; set; }
    public string base_url { get; set; }
    public string media_base_url { get; set; }
    public Data data { get; set; }
    public string action_name { get; set; }
    public bool device_coupons_generated { get; set; }
}

public sealed class HomeSegmentModel
{
    public bool success { get; set; }
    public IEnumerable<object> messages { get; set; }
    public Session session { get; set; }
    public ServerFlags server_flags { get; set; }
    public Metadata metadata { get; set; }
}

}
