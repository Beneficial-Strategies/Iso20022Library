// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet Transaction Detail1.
/// </summary>
[IsoId("_x5PxQXNVEe6Y1uOeeiF_Eg")]
[DisplayName("Fleet Transaction Detail1")]
public record FleetTransactionDetail1
{
    /// <summary>
    /// Discount Total Amount.
    /// </summary>
    [DisplayName("Discount Total Amount")]
    [IsoXmlTag("DscntTtlAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalAmount { get; init; }

    /// <summary>
    /// Discount Total Fuel Amount.
    /// </summary>
    [DisplayName("Discount Total Fuel Amount")]
    [IsoXmlTag("DscntTtlFuelAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalFuelAmount { get; init; }

    /// <summary>
    /// Discount Total Non Fuel Amount.
    /// </summary>
    [DisplayName("Discount Total Non Fuel Amount")]
    [IsoXmlTag("DscntTtlNonFuelAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalNonFuelAmount { get; init; }

    /// <summary>
    /// Purchase Type.
    /// </summary>
    [DisplayName("Purchase Type")]
    [IsoXmlTag("PurchsTp")]
    public FleetPurchaseType1Code? PurchaseType { get; init; }

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Tax Total.
    /// </summary>
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public ValueList<Tax41> TaxTotal { get; init; } = [];

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
