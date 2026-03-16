// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment transaction invoiced to customer.
/// </summary>
[IsoId("_RHVJkSCBEey8XKHwKquEQw")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction141
{
    /// <summary>
    /// List of codes representing type of fleet purchases.
    /// </summary>
    [IsoId("_RMU-USCBEey8XKHwKquEQw")]
    [DisplayName("Purchase Type")]
    [IsoXmlTag("PurchsTp")]
    public FleetPurchaseType1Code? PurchaseType { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_RMU-UyCBEey8XKHwKquEQw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Discount applied to the transaction.
    /// </summary>
    [IsoId("_RMU-VSCBEey8XKHwKquEQw")]
    [DisplayName("Discount Total")]
    [IsoXmlTag("DscntTtl")]
    public FleetDiscountTotals1? DiscountTotal { get; init; }

    /// <summary>
    /// Total taxes related to the products or services.
    /// </summary>
    [IsoId("_RMU-VyCBEey8XKHwKquEQw")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public Tax39? TaxTotal { get; init; }

    /// <summary>
    /// Total amount of the transaction, inclusive of all applicable taxes and fees.
    /// </summary>
    [IsoId("_RMU-WSCBEey8XKHwKquEQw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
