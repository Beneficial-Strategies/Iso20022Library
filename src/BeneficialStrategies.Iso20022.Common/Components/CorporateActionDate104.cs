// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Date104.
/// </summary>
[IsoId("_serYIYFmEe-L4fccMJVoAw")]
[DisplayName("Corporate Action Date104")]
public partial record CorporateActionDate104
{
    #nullable enable

    /// <summary>
    /// Borrower Stock Lending Deadline.
    /// </summary>
    [DisplayName("Borrower Stock Lending Deadline")]
    [IsoXmlTag("BrrwrStockLndgDdln")]
    public ValueList<BorrowerLendingDeadline5> BorrowerStockLendingDeadline { get; init; } = [];

    /// <summary>
    /// Cover Expiration Deadline.
    /// </summary>
    [DisplayName("Cover Expiration Deadline")]
    [IsoXmlTag("CoverXprtnDdln")]
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 

    /// <summary>
    /// Depository Cover Expiration Date.
    /// </summary>
    [DisplayName("Depository Cover Expiration Date")]
    [IsoXmlTag("DpstryCoverXprtnDt")]
    public DateFormat43Choice_? DepositoryCoverExpirationDate { get; init; } 

    /// <summary>
    /// Documentation Deadline.
    /// </summary>
    [DisplayName("Documentation Deadline")]
    [IsoXmlTag("DcmnttnDdln")]
    public DateFormat43Choice_? DocumentationDeadline { get; init; } 

    /// <summary>
    /// Early Response Deadline.
    /// </summary>
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; } 

    /// <summary>
    /// End Of Securities Blocking Period.
    /// </summary>
    [DisplayName("End Of Securities Blocking Period")]
    [IsoXmlTag("EndOfSctiesBlckgPrd")]
    public DateFormat59Choice_? EndOfSecuritiesBlockingPeriod { get; init; } 

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat43Choice_? ExpiryDate { get; init; } 

    /// <summary>
    /// Market Deadline.
    /// </summary>
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat43Choice_? MarketDeadline { get; init; } 

    /// <summary>
    /// Protect Deadline.
    /// </summary>
    [DisplayName("Protect Deadline")]
    [IsoXmlTag("PrtctDdln")]
    public DateFormat43Choice_? ProtectDeadline { get; init; } 

    /// <summary>
    /// Response Deadline.
    /// </summary>
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat44Choice_? ResponseDeadline { get; init; } 

    /// <summary>
    /// Stock Lending Deadline.
    /// </summary>
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public DateFormat43Choice_? StockLendingDeadline { get; init; } 

    /// <summary>
    /// Subscription Cost Debit Date.
    /// </summary>
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat43Choice_? SubscriptionCostDebitDate { get; init; } 

    
    #nullable disable
    
}
