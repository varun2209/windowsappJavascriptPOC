using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
    public sealed class CartModelTemp
    {
        public bool success { get; set; }
        public Meta meta { get; set; }
        private List<string> _message = new List<string>();
        public IList<string> message { get { return _message; } set { _message = (List<string>)value; } }
    }

    public sealed class Addinfo
    {
        public int corporate_currency_value { get; set; }
        public int default_shop_look_bundle_id { get; set; }
        public int discount_cap { get; set; }
        public dynamic is_gift_wrapped { get; set; }
        public bool is_shop_look_psku { get; set; }
        public int is_vat_charged { get; set; }
        public int mode_of_discount_amount { get; set; }
        public int mode_of_payment_amount { get; set; }
        public dynamic original_shipping_charge { get; set; }
        public int pack_qty { get; set; }
        public int payback_credits_value { get; set; }
        public int reward_points { get; set; }
        public int reward_rules_applied { get; set; }
        public int shop_look_bundle_id { get; set; }
        public int vat_amount { get; set; }
    }

    public sealed class CartChangeData
    {
        public dynamic price { get; set; }
        public int quantity { get; set; }
        public dynamic size { get; set; }
        public dynamic sku { get; set; }
    }

    public sealed class Color
    {
        public dynamic Blue { get; set; }
    }

    public sealed class ImageList
    {
        public dynamic prefixUrl { get; set; }
        public int imgCount { get; set; }
    }

    public sealed class CatalogConfig
    {
        public dynamic vat_company_contribution { get; set; }
    }

    public sealed class CatalogTaxClass
    {
        public dynamic tax_percent { get; set; }
    }

    public sealed class InfoCollection
    {
        public int corporate_currency_value { get; set; }
        public int default_shop_look_bundle_id { get; set; }
        public int discount_cap { get; set; }
        public dynamic is_gift_wrapped { get; set; }
        public bool is_shop_look_psku { get; set; }
        public int is_vat_charged { get; set; }
        public int mode_of_discount_amount { get; set; }
        public int mode_of_payment_amount { get; set; }
        public dynamic original_shipping_charge { get; set; }
        public int pack_qty { get; set; }
        public int payback_credits_value { get; set; }
        public int reward_points { get; set; }
        public int reward_rules_applied { get; set; }
        public int shop_look_bundle_id { get; set; }
        public int vat_amount { get; set; }
    }

    public sealed class SalesOrderItem
    {
        public int bundle_discount { get; set; }
        public int cart_rule_discount { get; set; }
        public dynamic cart_rule_display_names { get; set; }
        public CatalogConfig catalog_config { get; set; }
        public CatalogTaxClass catalog_tax_class { get; set; }
        public int coupon_money_value { get; set; }
        public dynamic fk_catalog_simple { get; set; }
        public dynamic fk_sku_bundle { get; set; }
        public int giftcard_credits_value { get; set; }
        public InfoCollection info_collection { get; set; }
        public dynamic name { get; set; }
        public dynamic original_unit_price { get; set; }
        public int paid_price { get; set; }
        public dynamic shipping_charge { get; set; }
        public dynamic sku { get; set; }
        public int store_credits_value { get; set; }
        public int tax_amount { get; set; }
        public dynamic tax_percent { get; set; }
        public dynamic unit_price { get; set; }
    }

    public sealed class Size
    {
        public dynamic label { get; set; }
        public dynamic value { get; set; }
    }

    public sealed class UniqueAttributes
    {
        public dynamic key { get; set; }
        public Size size { get; set; }
    }

    public sealed class Ad004ma82rbhindfas2234447
    {
        public Addinfo addinfo { get; set; }
        public dynamic brand { get; set; }
        private List<CartChangeData> _cart_change_data = new List<CartChangeData>();
        public IList<CartChangeData> cart_change_data { get { return _cart_change_data; } set { _cart_change_data = (List<CartChangeData>)value; } }
        public int cart_rule_discount { get; set; }
        private List<dynamic> _cart_rule_display_names = new List<dynamic>();
        public IList<dynamic> cart_rule_display_names { get { return _cart_rule_display_names; } set { _cart_rule_display_names = (List<dynamic>)value; } }
        public Color color { get; set; }
        public dynamic configId { get; set; }
        public dynamic configSku { get; set; }
        public dynamic delivery_date { get; set; }
        public dynamic delivery_time { get; set; }
        public dynamic image { get; set; }
        public ImageList image_list { get; set; }
        public bool is_any_gift_wrappable_item { get; set; }
        public bool is_item_voucher_applied { get; set; }
        public bool is_pickup { get; set; }
        public int item_index { get; set; }
        public dynamic max_saving_percentage { get; set; }
        public dynamic name { get; set; }
        public dynamic pack_qty { get; set; }
        public int quantity { get; set; }
        public SalesOrderItem salesOrderItem { get; set; }
        public object specialPrice { get; set; }
        public int stock { get; set; }
        public UniqueAttributes uniqueAttributes { get; set; }
        public dynamic link { get; set; }
    }

    public sealed class Ba305sh75ziiindfas428623
    {
        public Addinfo additional_info { get; set; }
        public dynamic brand { get; set; }
        private List<CartChangeData> _cart_change_data = new List<CartChangeData>();
        public IList<CartChangeData> cart_change_data { get { return _cart_change_data; } set { _cart_change_data = (List<CartChangeData>)value; } }
        public int cart_rule_discount { get; set; }
        private List<dynamic> _cart_rule_display_names = new List<dynamic>();
        public IList<dynamic> cart_rule_display_names { get { return _cart_rule_display_names; } set { _cart_rule_display_names = (List<dynamic>)value; } }
        public Color color { get; set; }
        public dynamic configId { get; set; }
        public dynamic configSku { get; set; }
        public dynamic delivery_date { get; set; }
        public dynamic delivery_time { get; set; }
        public dynamic image { get; set; }
        public ImageList image_list { get; set; }
        public bool is_any_gift_wrappable_item { get; set; }
        public bool is_item_voucher_applied { get; set; }
        public bool is_pickup { get; set; }
        public int item_index { get; set; }
        public dynamic max_saving_percentage { get; set; }
        public dynamic name { get; set; }
        public dynamic pack_qty { get; set; }
        public int quantity { get; set; }
        public SalesOrderItem salesOrderItem { get; set; }
        public object specialPrice { get; set; }
        public int stock { get; set; }
        public UniqueAttributes uniqueAttributes { get; set; }
        public dynamic supplier { get; set; }
        public dynamic link { get; set; }
    }

    public sealed class ItemList
    {
        public Ad004ma82rbhindfas2234447 ad004ma82rbhindfas_2234447 { get; set; }
        public Ba305sh75ziiindfas428623 ba305sh75ziiindfas_428623 { get; set; }

        //public ItemList() {
        //    ad004ma82rbhindfas_2234447 = new Ad004ma82rbhindfas2234447();
        //    ba305sh75ziiindfas_428623 = new Ba305sh75ziiindfas428623();
        //}
    }

    public sealed class NonBundle
    {
        public ItemList item_list { get; set; }

        //public NonBundle()
        //{
        //    item_list = new ItemList();
        //}
    }

    public sealed class CartItems
    {
        public NonBundle non_bundle { get; set; }
        public CartItems()
        {
            non_bundle = new NonBundle();
        }
    }

    public sealed class GiftWrapInfo
    {
        public dynamic gift_wrap_charges { get; set; }
        public bool isGiftWrapped { get; set; }
        public dynamic message { get; set; }

        public GiftWrapInfo() {
        }
    }

    public sealed class Row
    {
        public IList<string> row { get; set; }
        public dynamic rowHead { get; set; }
    }

    public sealed class Ba305sh75ziiindfas
    {
        public dynamic chart_image { get; set; }
        private List<string> _columnHeader = new List<string>();
        public IList<string> columnHeader { get { return _columnHeader; } set { _columnHeader = (List<string>)value; } }
        public bool is_column_header { get; set; }
        public bool is_row_header { get; set; }
        private List<Row> _row = new List<Row>();
        public IList<Row> row { get { return _row; } set { _row = (List<Row>)value; } }
    }

    public sealed class Ad004ma82rbhindfas
    {
        public dynamic chart_image { get; set; }
        private List<string> _columnHeader = new List<string>();
        public IList<string> columnHeader { get { return _columnHeader; } set { _columnHeader = (List<string>)value; } }
        public bool is_column_header { get; set; }
        public bool is_row_header { get; set; }
        private List<Row> _row = new List<Row>();
        public IList<Row> row { get { return _row; } set { _row = (List<Row>)value; } }
    }

    public sealed class SizeChart
    {
        public Ba305sh75ziiindfas ba305sh75ziiindfas { get; set; }
        public Ad004ma82rbhindfas ad004ma82rbhindfas { get; set; }
    }

    public sealed class Total
    {
        public dynamic bundle_discount { get; set; }
        public dynamic coupon_money_value { get; set; }
        public dynamic gift_wrap_charges { get; set; }
        public dynamic payback_credits_value { get; set; }
        public dynamic shipping_charge { get; set; }
        public dynamic special_shipping_service { get; set; }
        public dynamic special_shipping_service_charge { get; set; }
        public dynamic special_shipping_service_code { get; set; }
        public dynamic store_credits_value { get; set; }
        public dynamic sub_total { get; set; }

        //public Total()
        //{

        //}
    }

    public sealed class Meta
    {
        public dynamic alert_messages { get; set; }
        public int cartCount { get; set; }
        public CartItems cartItems { get; set; }
        public dynamic cartValue { get; set; }
        public dynamic coupon_code { get; set; }
        public GiftWrapInfo gift_wrap_info { get; set; }
        private List<SizeChart> _size_chart = new List<SizeChart>();
        public IList<SizeChart> size_chart { get { return _size_chart; } set { _size_chart = (List<SizeChart>)value; } }
        public Total total { get; set; }
        public int giftWrappableCount { get; set; }

        //public Meta()
        //{
        //    cartItems = new CartItems();
        //    gift_wrap_info = new GiftWrapInfo();
        //    total = new Total();
        //}
    }
}
