// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sale3.
/// </summary>
[IsoId("_fE6sYXNREe6Y1uOeeiF_Eg")]
[DisplayName("Sale3")]
public record Sale3
{
    /// <summary>
    /// Adjustment.
    /// </summary>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment13> Adjustment { get; init; } = [];

    /// <summary>
    /// Line Item.
    /// </summary>
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<SaleItem4> LineItem { get; init; } = [];

    /// <summary>
    /// Loyalty Programme.
    /// </summary>
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }
}
