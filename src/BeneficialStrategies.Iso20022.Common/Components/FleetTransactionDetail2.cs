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
[IsoId("_kqBOYVXgEfC0lMwgjvMClw")]
[DisplayName("Fleet Transaction Detail2")]
public record FleetTransactionDetail2
{
    /// <summary>
    /// List of codes representing type of fleet purchases.
    /// </summary>
    [IsoId("_ksf6oVXgEfC0lMwgjvMClw")]
    [DisplayName("Purchase Type")]
    [IsoXmlTag("PurchsTp")]
    public FleetPurchaseType1Code? PurchaseType { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_ksf6o1XgEfC0lMwgjvMClw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Total amount of the transaction, inclusive of all applicable taxes and fees.
    /// </summary>
    [IsoId("_ksf6pVXgEfC0lMwgjvMClw")]
    [DisplayName("Discount Total Amount")]
    [IsoXmlTag("DscntTtlAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalAmount { get; init; }

    /// <summary>
    /// Total amount.
    /// </summary>
    [IsoId("_ksf6p1XgEfC0lMwgjvMClw")]
    [DisplayName("Discount Total Fuel Amount")]
    [IsoXmlTag("DscntTtlFuelAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalFuelAmount { get; init; }

    /// <summary>
    /// Fuel amount.
    /// </summary>
    [IsoId("_ksf6qVXgEfC0lMwgjvMClw")]
    [DisplayName("Discount Total Non Fuel Amount")]
    [IsoXmlTag("DscntTtlNonFuelAmt")]
    public ImpliedCurrencyAndAmount? DiscountTotalNonFuelAmount { get; init; }

    /// <summary>
    /// Total amount of the transaction, inclusive of all applicable taxes and fees.
    /// </summary>
    [IsoId("_ksf6q1XgEfC0lMwgjvMClw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Total taxes related to the products or services.
    /// </summary>
    [IsoId("_ksf6rVXgEfC0lMwgjvMClw")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public ValueList<Tax44> TaxTotal { get; init; } = [];
}
