// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_TfaEIdp-Ed-ak6NoX_4Aeg_-1443525698")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate4
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the coupons are to be/were submitted for payment of interest.
    /// </summary>
    [IsoId("_TfaEItp-Ed-ak6NoX_4Aeg_94731329")]
    [DisplayName("Coupon Clipping Date")]
    [IsoXmlTag("CpnClpngDt")]
    public DateFormat4Choice_? CouponClippingDate { get; init; } 
    
    /// <summary>
    /// Last date/time at which a holder can consent to the changes sought by the corporation.
    /// </summary>
    [IsoId("_TfaEI9p-Ed-ak6NoX_4Aeg_-1147075800")]
    [DisplayName("Consent Expiration Date")]
    [IsoXmlTag("CnsntXprtnDt")]
    public DateFormat4Choice_? ConsentExpirationDate { get; init; } 
    
    /// <summary>
    /// Date/time used by the offeror to determine the beneficiary eligible to participate in a consent based on the registered owner of the securities, eg, beneficial owner of consent record. The consent record date qualifier is used to indicate that a record date only applies to a certain part of the offer, not the entire offer.
    /// </summary>
    [IsoId("_TfaEJNp-Ed-ak6NoX_4Aeg_-1147075769")]
    [DisplayName("Consent Record Date")]
    [IsoXmlTag("CnsntRcrdDt")]
    public DateFormat4Choice_? ConsentRecordDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TfaEJdp-Ed-ak6NoX_4Aeg_-1147075460")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat4Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a payment can be made, eg, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TfaEJtp-Ed-ak6NoX_4Aeg_-1147075430")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat4Choice_? EarliestPaymentDate { get; init; } 
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_TfaEJ9p-Ed-ak6NoX_4Aeg_-1147075338")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat4Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in an SLA.
    /// </summary>
    [IsoId("_TfaEKNp-Ed-ak6NoX_4Aeg_-1147075307")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat4Choice_? ResponseDeadline { get; init; } 
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, eg, of physical certificates.
    /// </summary>
    [IsoId("_TfjOENp-Ed-ak6NoX_4Aeg_-1147074998")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat4Choice_? DeadlineToSplit { get; init; } 
    
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TfjOEdp-Ed-ak6NoX_4Aeg_-1147074967")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat4Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the price of a security is determined.
    /// </summary>
    [IsoId("_TfjOEtp-Ed-ak6NoX_4Aeg_1190354439")]
    [DisplayName("Quotation Setting Date")]
    [IsoXmlTag("QtnSetngDt")]
    public DateFormat4Choice_? QuotationSettingDate { get; init; } 
    
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_TfjOE9p-Ed-ak6NoX_4Aeg_1148708365")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat4Choice_? SubscriptionCostDebitDate { get; init; } 
    
    
    #nullable disable
    
}
