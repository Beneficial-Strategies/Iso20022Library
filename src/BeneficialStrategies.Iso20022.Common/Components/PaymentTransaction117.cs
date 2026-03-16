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
[IsoId("_Bf1da_jAEeiJaN6-Lf-c_w")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction117
{
    /// <summary>
    /// List of codes representing type of fleet purchases.
    /// </summary>
    [IsoId("_Bf1ddfjAEeiJaN6-Lf-c_w")]
    [DisplayName("Purchase Type")]
    [IsoXmlTag("PurchsTp")]
    public FleetPurchaseType1Code? PurchaseType { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_4lROwfjCEeiJaN6-Lf-c_w")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Discount applied to the transaction.
    /// </summary>
    [IsoId("_Bf1dbvjAEeiJaN6-Lf-c_w")]
    [DisplayName("Discount Total")]
    [IsoXmlTag("DscntTtl")]
    public FleetDiscountTotals1? DiscountTotal { get; init; }

    /// <summary>
    /// Total taxes related to the products or services.
    /// </summary>
    [IsoId("_Bf1dc_jAEeiJaN6-Lf-c_w")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public Tax33? TaxTotal { get; init; }

    /// <summary>
    /// Total amount of the transaction, inclusive of all applicable taxes and fees.
    /// </summary>
    [IsoId("_ysQ6YPjKEeiJaN6-Lf-c_w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
