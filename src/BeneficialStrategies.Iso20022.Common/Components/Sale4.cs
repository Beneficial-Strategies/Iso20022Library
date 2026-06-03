// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of good and services included in the sale.
/// </summary>
[IsoId("_G95uUVXhEfC0lMwgjvMClw")]
[DisplayName("Sale4")]
public record Sale4
{
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_HAUwMVXhEfC0lMwgjvMClw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains loyalty programme information.
    /// </summary>
    [IsoId("_HAUwM1XhEfC0lMwgjvMClw")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Contains adjustment details of the transaction.
    /// </summary>
    [IsoId("_HAUwNVXhEfC0lMwgjvMClw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment13> Adjustment { get; init; } = [];

    /// <summary>
    /// Sale line item information.
    /// </summary>
    [IsoId("_HAUwN1XhEfC0lMwgjvMClw")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<SaleItem5> LineItem { get; init; } = [];
}
