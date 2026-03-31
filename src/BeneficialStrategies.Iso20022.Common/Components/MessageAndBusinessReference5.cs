// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to identify the funds order confirmations.
/// </summary>
[IsoId("_RMLdRtp-Ed-ak6NoX_4Aeg_1019850992")]
[DisplayName("Message And Business Reference")]
public record MessageAndBusinessReference5
{
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_RMLdR9p-Ed-ak6NoX_4Aeg_1019851365")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public AdditionalReference3? OtherReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_RMLdSNp-Ed-ak6NoX_4Aeg_1019851019")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_RMLdSdp-Ed-ak6NoX_4Aeg_1019851828")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifiers of one or more individual order instructions.
    /// </summary>
    [IsoId("_RMLdStp-Ed-ak6NoX_4Aeg_977559213")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public ValueList<InvestmentFundOrder3> OrderReference { get; init; } = [];
}
