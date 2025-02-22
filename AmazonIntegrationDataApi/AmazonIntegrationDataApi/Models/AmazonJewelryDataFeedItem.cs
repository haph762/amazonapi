using Domain;

namespace AmazonIntegrationDataApi.Models
{
    public class AmazonJewelryDataFeedItem : IAmazonJewelryDataFeedItem
    {
        public Guid Id { get; set; }
        public  string? feed_product_type { get; set; }
        public  string? item_sku { get; set; }
        public  string? brand_name { get; set; }
        public  string? external_product_id { get; set; }
        public  string? external_product_id_type { get; set; }
        public  string? item_name { get; set; }
        public  string? item_length_numeric { get; set; }
        public  string? item_length_numeric_unit_of_measure { get; set; }
        public  string? main_image_url { get; set; }
        public  string? target_gender { get; set; }
        public  string? quantity { get; set; }
        public  string? standard_price { get; set; }
        public  string? item_type { get; set; }
        public  string? metal_type { get; set; }
        public  string? material_type1 { get; set; }
        public  string? material_type2 { get; set; }
        public  string? material_type3 { get; set; }
        public  string? department_name { get; set; }
        public  string? gem_type1 { get; set; }
        public  string? gem_type2 { get; set; }
        public  string? gem_type3 { get; set; }
        public  string? product_description { get; set; }
        public  string? generic_keywords { get; set; }
        public  string? bullet_point1 { get; set; }
        public  string? bullet_point2 { get; set; }
        public  string? bullet_point3 { get; set; }
        public  string? bullet_point4 { get; set; }
        public  string? bullet_point5 { get; set; }
        public  string? bullet_point6 { get; set; }
        public  string? bullet_point7 { get; set; }
        public  string? bullet_point8 { get; set; }
        public  string? bullet_point9 { get; set; }
        public  string? bullet_point10 { get; set; }
        public  string? supplier_declared_dg_hz_regulation1 { get; set; }
        public  string? supplier_declared_dg_hz_regulation2 { get; set; }
        public  string? supplier_declared_dg_hz_regulation3 { get; set; }
        public  string? supplier_declared_dg_hz_regulation4 { get; set; }
        public  string? supplier_declared_dg_hz_regulation5 { get; set; }
        public  string? color_name { get; set; }
        public  string? part_number { get; set; }
        public  string? item_type_name { get; set; }
        public  string? size_name { get; set; }
        public  string? lifecycle_supply_type { get; set; }
        public  string? country_of_origin { get; set; }
        public  string? cpsia_cautionary_statement1 { get; set; }
        public  string? cpsia_cautionary_statement2 { get; set; }
        public  string? cpsia_cautionary_statement3 { get; set; }
        public  string? cpsia_cautionary_statement4 { get; set; }
        public  string? supplier_declared_material_regulation1 { get; set; }
        public  string? supplier_declared_material_regulation2 { get; set; }
        public  string? supplier_declared_material_regulation3 { get; set; }
        public  string? map_price { get; set; }
        public  string? currency { get; set; }
        public  string? condition_type { get; set; }
        public  string? ring_size { get; set; }
        public  string? color_map { get; set; }
        public  string? age_range_description { get; set; }
        public  string? other_image_url1 { get; set; }
        public  string? other_image_url2 { get; set; }
        public  string? other_image_url3 { get; set; }
        public  string? other_image_url4 { get; set; }
        public  string? other_image_url5 { get; set; }
        public  string? other_image_url6 { get; set; }
        public  string? other_image_url7 { get; set; }
        public  string? other_image_url8 { get; set; }
        public  string? swatch_image_url { get; set; }
        public  string? pt8_image_url { get; set; }
        public  string? pt7_image_url { get; set; }
        public  string? pt5_image_url { get; set; }
        public  string? pt4_image_url { get; set; }
        public  string? pt3_image_url { get; set; }
        public  string? pt2_image_url { get; set; }
        public  string? pt6_image_url { get; set; }
        public  string? pt1_image_url { get; set; }
        public  string? relationship_type { get; set; }
        public  string? variation_theme { get; set; }
        public  string? package_level { get; set; }
        public  string? parent_sku { get; set; }
        public  string? package_contains_quantity { get; set; }
        public  string? package_contains_identifier { get; set; }
        public  string? parent_child { get; set; }
        public  string? update_delete { get; set; }
        public  string? certificate_number { get; set; }
        public  string? model { get; set; }
        public  string? grade_rating { get; set; }
        public  string? manufacturer { get; set; }
        public  string? certificate_type { get; set; }
        public  string? production_method { get; set; }
        public  string? closure_type { get; set; }
        public  string? model_name { get; set; }
        public  string? care_instructions { get; set; }
        public  string? stone_color1 { get; set; }
        public  string? stone_color2 { get; set; }
        public  string? stone_color3 { get; set; }
        public  string? style_name { get; set; }
        public  string? metals_metal_weight_unit_of_measure { get; set; }
        public  string? stones_color { get; set; }
        public  string? occasion_type1 { get; set; }
        public  string? occasion_type2 { get; set; }
        public  string? occasion_type3 { get; set; }
        public  string? occasion_type4 { get; set; }
        public  string? occasion_type5 { get; set; }
        public  string? clasp_type { get; set; }
        public  string? stones_id { get; set; }
        public  string? stones_creation_method { get; set; }
        public  string? athlete { get; set; }
        public  string? team_name { get; set; }
        public  string? stone_shape1 { get; set; }
        public  string? stone_shape2 { get; set; }
        public  string? stone_shape3 { get; set; }
        public  string? stone_clarity1 { get; set; }
        public  string? stone_clarity2 { get; set; }
        public  string? stone_clarity3 { get; set; }
        public  string? collection_name { get; set; }
        public  string? metals_metal_weight { get; set; }
        public  string? metals_metal_type { get; set; }
        public  string? stones_type { get; set; }
        public  string? stones_clarity { get; set; }
        public  string? stones_number_of_stones { get; set; }
        public  string? stones_treatment_method { get; set; }
        public  string? fur_description { get; set; }
        public  string? setting_type { get; set; }
        public  string? metals_id { get; set; }
        public  string? initial_character { get; set; }
        public  string? metals_metal_stamp { get; set; }
        public  string? stones_shape { get; set; }
        public  string? chain_length_unit { get; set; }
        public  string? stones_cut { get; set; }
        public  string? stone_cut1 { get; set; }
        public  string? stone_cut2 { get; set; }
        public  string? stone_cut3 { get; set; }
        public  string? league_name { get; set; }
        public  string? thesaurus_subject_keywords { get; set; }
        public  string? chain_length_derived { get; set; }
        public  string? chain_type { get; set; }
        public  string? item_booking_date { get; set; }
        public  string? style_keywords1 { get; set; }
        public  string? style_keywords2 { get; set; }
        public  string? style_keywords3 { get; set; }
        public  string? is_resizable { get; set; }
        public  string? back_finding { get; set; }
        public  string? stone_creation_method1 { get; set; }
        public  string? stone_creation_method2 { get; set; }
        public  string? stone_creation_method3 { get; set; }
        public  string? stone_treatment_method1 { get; set; }
        public  string? stone_treatment_method2 { get; set; }
        public  string? stone_treatment_method3 { get; set; }
        public  string? pattern_name { get; set; }
        public  string? embellishment_feature { get; set; }
        public  string? drop_length_unit { get; set; }
        public  string? drop_length { get; set; }
        public  string? band_thickness { get; set; }
        public  string? band_thickness_unit_of_measure { get; set; }
        public  string? theme { get; set; }
        public  string? is_autographed { get; set; }
        public  string? sport_type1 { get; set; }
        public  string? sport_type2 { get; set; }
        public  string? seasons1 { get; set; }
        public  string? seasons2 { get; set; }
        public  string? seasons3 { get; set; }
        public  string? seasons4 { get; set; }
        public  string? lifestyle { get; set; }
        public  string? fit_type1 { get; set; }
        public  string? fit_type2 { get; set; }
        public  string? fit_type3 { get; set; }
        public  string? fit_type4 { get; set; }
        public  string? fit_type5 { get; set; }
        public  string? weave_type { get; set; }
        public  string? special_size_type { get; set; }
        public  string? pearl_type { get; set; }
        public  string? legal_compliance_certification_certifying_authority_name { get; set; }
        public  string? pearl_uniformity { get; set; }
        public  string? pearl_shape { get; set; }
        public  string? pearl_surface_blemishes { get; set; }
        public  string? pearl_lustre { get; set; }
        public  string? legal_compliance_certification_geographic_jurisdiction { get; set; }
        public  string? flash_point_unit_of_measure { get; set; }
        public  string? pearl_stringing_method { get; set; }
        public  string? pearl_minimum_color { get; set; }
        public  string? inscription { get; set; }
        public  string? number_of_pearls { get; set; }
        public  string? index_suppressed { get; set; }
        public  string? number_of_stones { get; set; }
        public  string? ring_sizing_lower_range { get; set; }
        public  string? ring_sizing_upper_range { get; set; }
        public  string? duration_unit_of_measure { get; set; }
        public  string? subject_character { get; set; }
        public  string? duration { get; set; }
        public  string? sub_brand_name { get; set; }
        public  string? sleeve_type { get; set; }
        public  string? fabric_wash { get; set; }
        public  string? finish_type1 { get; set; }
        public  string? finish_type2 { get; set; }
        public  string? item_display_weight { get; set; }
        public  string? total_diamond_weight { get; set; }
        public  string? item_display_diameter { get; set; }
        public  string? stone_weight1 { get; set; }
        public  string? stone_weight2 { get; set; }
        public  string? stone_weight3 { get; set; }
        public  string? stone_weight_unit_of_measure1 { get; set; }
        public  string? stone_weight_unit_of_measure2 { get; set; }
        public  string? stone_weight_unit_of_measure3 { get; set; }
        public  string? total_gem_weight { get; set; }
        public  string? size_per_pearl { get; set; }
        public  string? unit_count { get; set; }
        public  string? item_display_diameter_unit_of_measure { get; set; }
        public  string? item_display_length { get; set; }
        public  string? item_display_length_unit_of_measure { get; set; }
        public  string? total_gem_weight_unit_of_measure { get; set; }
        public  string? item_display_weight_unit_of_measure { get; set; }
        public  string? total_diamond_weight_unit_of_measure { get; set; }
        public  string? unit_count_type { get; set; }
        public  string? item_width_unit_of_measure { get; set; }
        public  string? item_width { get; set; }
        public  string? item_height { get; set; }
        public  string? size_map { get; set; }
        public  string? item_height_unit_of_measure { get; set; }
        public  string? item_length_unit_of_measure { get; set; }
        public  string? item_length { get; set; }
        public  string? item_display_width { get; set; }
        public  string? website_shipping_weight { get; set; }
        public  string? website_shipping_weight_unit_of_measure { get; set; }
        public  string? stone_height1 { get; set; }
        public  string? stone_height2 { get; set; }
        public  string? stone_height3 { get; set; }
        public  string? stone_length1 { get; set; }
        public  string? stone_length2 { get; set; }
        public  string? stone_length3 { get; set; }
        public  string? stone_width1 { get; set; }
        public  string? stone_width2 { get; set; }
        public  string? stone_width3 { get; set; }
        public  string? stone_dimensions_unit_of_measure1 { get; set; }
        public  string? stone_dimensions_unit_of_measure2 { get; set; }
        public  string? stone_dimensions_unit_of_measure3 { get; set; }
        public  string? item_display_height_unit_of_measure { get; set; }
        public  string? item_display_width_unit_of_measure { get; set; }
        public  string? item_display_height { get; set; }
        public  string? stone_width_unit_of_measure1 { get; set; }
        public  string? stone_width_unit_of_measure2 { get; set; }
        public  string? stone_width_unit_of_measure3 { get; set; }
        public  string? stone_length_unit_of_measure1 { get; set; }
        public  string? stone_length_unit_of_measure2 { get; set; }
        public  string? stone_length_unit_of_measure3 { get; set; }
        public  string? total_metal_weight { get; set; }
        public  string? total_metal_weight_unit_of_measure { get; set; }
        public  string? item_shape { get; set; }
        public  string? package_length { get; set; }
        public  string? package_weight_unit_of_measure { get; set; }
        public  string? package_height { get; set; }
        public  string? fulfillment_center_id { get; set; }
        public  string? package_length_unit_of_measure { get; set; }
        public  string? package_height_unit_of_measure { get; set; }
        public  string? package_width { get; set; }
        public  string? package_width_unit_of_measure { get; set; }
        public  string? package_weight { get; set; }
        public  string? regulation_type1 { get; set; }
        public  string? regulation_type2 { get; set; }
        public  string? regulation_type3 { get; set; }
        public  string? regulation_type4 { get; set; }
        public  string? regulation_type5 { get; set; }
        public  string? regulatory_compliance_certification_value1 { get; set; }
        public  string? regulatory_compliance_certification_value2 { get; set; }
        public  string? regulatory_compliance_certification_value3 { get; set; }
        public  string? regulatory_compliance_certification_value4 { get; set; }
        public  string? regulatory_compliance_certification_value5 { get; set; }
        public  string? batteries_required { get; set; }
        public  string? are_batteries_included { get; set; }
        public  string? battery_cell_composition { get; set; }
        public  string? battery_type1 { get; set; }
        public  string? battery_type2 { get; set; }
        public  string? battery_type3 { get; set; }
        public  string? number_of_batteries1 { get; set; }
        public  string? number_of_batteries2 { get; set; }
        public  string? number_of_batteries3 { get; set; }
        public  string? battery_weight { get; set; }
        public  string? battery_weight_unit_of_measure { get; set; }
        public  string? number_of_lithium_metal_cells { get; set; }
        public  string? number_of_lithium_ion_cells { get; set; }
        public  string? lithium_battery_packaging { get; set; }
        public  string? lithium_battery_energy_content { get; set; }
        public  string? lithium_battery_energy_content_unit_of_measure { get; set; }
        public  string? lithium_battery_weight { get; set; }
        public  string? lithium_battery_weight_unit_of_measure { get; set; }
        public  string? hazmat_united_nations_regulatory_id { get; set; }
        public  string? safety_data_sheet_url { get; set; }
        public  string? item_weight { get; set; }
        public  string? item_weight_unit_of_measure { get; set; }
        public  string? item_volume { get; set; }
        public  string? item_volume_unit_of_measure { get; set; }
        public  string? warranty_type { get; set; }
        public  string? legal_compliance_certification_expiration_date { get; set; }
        public  string? legal_compliance_certification_regulatory_organization_name { get; set; }
        public  string? legal_compliance_certification_status { get; set; }
        public  string? flash_point { get; set; }
        public  string? warranty_description { get; set; }
        public  string? legal_compliance_certification_date_of_issue { get; set; }
        public  string? legal_compliance_certification_metadata { get; set; }
        public  string? legal_compliance_certification_value { get; set; }
        public  string? metal_stamp { get; set; }
        public  string? ghs_classification_class1 { get; set; }
        public  string? ghs_classification_class2 { get; set; }
        public  string? ghs_classification_class3 { get; set; }
        public  string? california_proposition_65_compliance_type { get; set; }
        public  string? california_proposition_65_chemical_names1 { get; set; }
        public  string? california_proposition_65_chemical_names2 { get; set; }
        public  string? california_proposition_65_chemical_names3 { get; set; }
        public  string? california_proposition_65_chemical_names4 { get; set; }
        public  string? california_proposition_65_chemical_names5 { get; set; }
        public  string? pesticide_marking_type1 { get; set; }
        public  string? pesticide_marking_type2 { get; set; }
        public  string? pesticide_marking_type3 { get; set; }
        public  string? pesticide_marking_registration_status1 { get; set; }
        public  string? pesticide_marking_registration_status2 { get; set; }
        public  string? pesticide_marking_registration_status3 { get; set; }
        public  string? pesticide_marking_certification_number1 { get; set; }
        public  string? pesticide_marking_certification_number2 { get; set; }
        public  string? pesticide_marking_certification_number3 { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_registration_status { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_point_of_contact_email { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_point_of_contact_phone_number { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_point_of_contact_name { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_identification_number { get; set; }
        public  string? fcc_radio_frequency_emission_compliance_point_of_contact_address { get; set; }
        public  string? fabric_type { get; set; }
        public  string? import_designation { get; set; }
        public  string? merchant_release_date { get; set; }
        public  string? list_price { get; set; }
        public  string? restock_date { get; set; }
        public  string? number_of_items { get; set; }
        public  string? fulfillment_latency { get; set; }
        public  string? offering_can_be_giftwrapped { get; set; }
        public  string? item_package_quantity { get; set; }
        public  string? offering_end_date { get; set; }
        public  string? max_order_quantity { get; set; }
        public  string? merchant_shipping_group_name { get; set; }
        public  string? offering_start_date { get; set; }
        public  string? product_tax_code { get; set; }
        public  string? offering_can_be_gift_messaged { get; set; }
        public  string? condition_note { get; set; }
        public  string? sale_price { get; set; }
        public  string? sale_from_date { get; set; }
        public  string? sale_end_date { get; set; }
        public  string? product_site_launch_date { get; set; }
        public  string? business_price { get; set; }
        public  string? quantity_price_type { get; set; }
        public  string? quantity_lower_bound1 { get; set; }
        public  string? quantity_price1 { get; set; }
        public  string? quantity_lower_bound2 { get; set; }
        public  string? quantity_price2 { get; set; }
        public  string? quantity_lower_bound3 { get; set; }
        public  string? quantity_price3 { get; set; }
        public  string? quantity_lower_bound4 { get; set; }
        public  string? quantity_price4 { get; set; }
        public  string? quantity_lower_bound5 { get; set; }
        public  string? quantity_price5 { get; set; }
        public  string? progressive_discount_type { get; set; }
        public  string? progressive_discount_lower_bound1 { get; set; }
        public  string? progressive_discount_value1 { get; set; }
        public  string? progressive_discount_lower_bound2 { get; set; }
        public  string? progressive_discount_value2 { get; set; }
        public  string? progressive_discount_lower_bound3 { get; set; }
        public  string? progressive_discount_value3 { get; set; }
        public  string? national_stock_number { get; set; }
        public  string? unspsc_code { get; set; }
        public  string? pricing_action { get; set; }
        public bool IsDeleted { get; set; }
    }
}