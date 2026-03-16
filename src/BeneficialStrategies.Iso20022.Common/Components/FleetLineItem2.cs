// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_rPO3If5nEeiLerArw36g0w")]
[DisplayName("Fleet Line Item")]
public record FleetLineItem2
{
    /// <summary>
    /// Indicates whether or not the requested product or service is allowed.
    /// True = Allowed
    /// False = Not allowed
    /// </summary>
    [IsoId("_arjM8P5oEeiLerArw36g0w")]
    [DisplayName("Allowed Item Indicator")]
    [IsoXmlTag("AllwdItmInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AllowedItemIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// </summary>
    [IsoId("_rYjyQf5nEeiLerArw36g0w")]
    [DisplayName("Fuel Indicator")]
    [IsoXmlTag("FuelInd")]
    public required FleetPurchaseType1Code FuelIndicator { get; init; }

    /// <summary>
    /// Type of service received at the acceptor location.
    /// </summary>
    [IsoId("_rYjyQ_5nEeiLerArw36g0w")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public FleetServiceType1Code? ServiceType { get; init; }

    /// <summary>
    /// Contains a code that identifies a category of fleet products or services.
    /// </summary>
    [IsoId("_rYjySf5nEeiLerArw36g0w")]
    [DisplayName("Fleet Product Category")]
    [IsoXmlTag("FleetPdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FleetProductCategory { get; init; }

    /// <summary>
    /// Code that identifies the type of fuel or non-fuel product or service being purchased.
    /// </summary>
    [IsoId("_rYjyR_5nEeiLerArw36g0w")]
    [DisplayName("Fleet Product Code")]
    [IsoXmlTag("FleetPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? FleetProductCode { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_rYjyU_5nEeiLerArw36g0w")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_rYjyV_5nEeiLerArw36g0w")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    public IsoMax12NumericText? ProductQuantity { get; init; }

    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_rYjyX_5nEeiLerArw36g0w")]
    [DisplayName("Total Amount Excluding Tax")]
    [IsoXmlTag("TtlAmtExclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; }

    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_rYjyYf5nEeiLerArw36g0w")]
    [DisplayName("Total Amount Including Tax")]
    [IsoXmlTag("TtlAmtInclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; }
}
