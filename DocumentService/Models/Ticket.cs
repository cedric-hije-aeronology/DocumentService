using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class Ticket
    {
        [JsonPropertyName("document_number")]
        public string DocumentNumber { get; set; }

        [JsonPropertyName("icw")]
        public string ICW { get; set; }

        [JsonPropertyName("gds_code")]
        public string GDSCode { get; set; }

        [JsonPropertyName("document_type")]
        public string DocumentType { get; set; }

        [JsonPropertyName("locator")]
        public string Locator { get; set; }
        
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        [JsonPropertyName("price_it")]
        public decimal? PriceIt { get; set; }

        [JsonPropertyName("conjunction")]
        public string Conjunction { get; set; }

        [JsonPropertyName("pax_type")]
        public string PaxType { get; set; }

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("passenger_name")]
        public string PassengerName { get; set; }

        [JsonPropertyName("issue_date")]
        public string IssueDate { get; set; }

        [JsonPropertyName("airline_references_text")]
        public string AirlineReferencesText { get; set; }

        [JsonPropertyName("frequent_flyer_no")]
        public string FrequentFlyerNo { get; set; }

        [JsonPropertyName("old_issue_date")]
        public string OldIssueDate { get; set; }

        [JsonPropertyName("change_fee_document_no")]
        public string ChangeFeeDocumentNo { get; set; }

        [JsonPropertyName("change_fee_issue_date")]
        public string ChangeFeeIssueDate { get; set; }

        [JsonPropertyName("segments")]
        public List<Segment> Segments { get; set; }

        [JsonPropertyName("fare_endorsement")]
        public string FareEndorsement { get; set; }

        [JsonPropertyName("penalty_rules")]
        public List<PenaltyRule> PenaltyRules { get; set; }

        [JsonPropertyName("validating_carrier")]
        public string ValidatingCarrier { get; set; }

        [JsonPropertyName("fare_rules")]
        public List<SegmentFareRule> FareRules { get; set; }

        [JsonPropertyName("display_mini_rules")]
        public bool DisplayMiniRules { get; set; } = true;

        [JsonPropertyName("base_fare_price")]
        public decimal? BaseFarePrice { get; set; }

        [JsonPropertyName("total_tax_price")]
        public decimal? TotalTaxPrice { get; set; }

        [JsonPropertyName("total_fee_price")]
        public decimal? TotalFeePrice { get; set; }

        [JsonPropertyName("with_merchant_fee")]
        public bool WithMerchantFee { get; set; }

        [JsonPropertyName("merchant_card_type")]
        public string MerchantCardType { get; set; }

        [JsonPropertyName("merchant_fee")]
        public decimal MerchantFee { get; set; }

        [JsonPropertyName("total_price")]
        public decimal? TotalPrice { get; set; }

        [JsonPropertyName("agent_note")]
        public string AgentNote { get; set; }

        [JsonPropertyName("display_option")]
        public string DisplayOption { get; set; }

        [JsonPropertyName("consolidator_id")]
        public string ConsolidatorId { get; set; }

        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        [JsonPropertyName("agent_name")]
        public string AgentName { get; set; }

        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }

        [JsonPropertyName("agent_contact_name")]
        public string AgentContactName { get; set; }

        [JsonPropertyName("agent_contact_phone")]
        public string AgentContactPhone { get; set; }

        [JsonPropertyName("agent_logo")]
        public string AgentLogo { get; set; }

        [JsonPropertyName("consolidator_name")]
        public string ConsolidatorName { get; set; }

        [JsonPropertyName("consolidator_site_settings")]
        public string ConsolidatorSiteSettings { get; set; }

        [JsonPropertyName("user_full_name")]
        public string UserFullName { get; set; }






        [JsonPropertyName("agent_iata_number")]
        public string AgentIataNumber { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("gross_price")]
        public decimal? GrossPrice { get; set; }

        [JsonPropertyName("total_fare_price")]
        public decimal? TotalFarePrice { get; set; }

        [JsonPropertyName("gst_amount")]
        public decimal GstAmount { get; set; }

        [JsonPropertyName("commission_gst")]
        public decimal CommissionGst { get; set; }

        [JsonPropertyName("fee_gst")]
        public decimal FeeGst { get; set; }

        [JsonPropertyName("cc_fee")]
        public decimal CCFee { get; set; }

        [JsonPropertyName("agent_price")]
        public decimal? AgentPrice { get; set; }

        [JsonPropertyName("voided_by")]
        public string VoidedBy { get; set; }

        [JsonPropertyName("route")]
        public string Route { get; set; }

        [JsonPropertyName("commission")]
        public decimal Commission { get; set; }

        [JsonPropertyName("additional_fare")]
        public decimal? AdditionalFare { get; set; }

        [JsonPropertyName("new_fare")]
        public decimal? NewFare { get; set; }

        [JsonPropertyName("reissue_quote_ref_no")]
        public string ReissueQuoteRefNo { get; set; }
        [JsonPropertyName("tax_list")]
        public List<TaxLine> TaxList { get; set; }

        [JsonPropertyName("webtop_ticket")]
        public bool WebtopTicket { get; set; }

        [JsonPropertyName("price_type")]
        public PriceType? PriceType { get; set; }

        [JsonPropertyName("fare_type")]
        public FareTypeWebtop? FareType { get; set; }

        [JsonPropertyName("void_fee")]
        public decimal VoidFee { get; set; }

        

        [JsonPropertyName("emd_tax")]
        public decimal EMDTax { get; set; }

        [JsonPropertyName("emd_tax_gst")]
        public decimal EMDTaxGST { get; set; }

        [JsonPropertyName("is_residual_emd")]
        public bool IsResidualEMD { get; set; }
    }

    public class TaxLine
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }

    public enum PriceType
    {
        Published,
        Manual
    }

    public enum FareTypeWebtop
    {
        Published,
        IT,
        BT,
        NR
    }
}
