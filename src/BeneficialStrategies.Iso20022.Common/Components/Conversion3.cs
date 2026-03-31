// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion3.
/// </summary>
[IsoId("_enviAX_8Ee-5A_neRtHpSQ")]
[DisplayName("Conversion3")]
public record Conversion3
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Original Security.
    /// </summary>
    [DisplayName("Original Security")]
    [IsoXmlTag("OrgnlScty")]
    public required FinancialInstrumentIdentification5 OriginalSecurity { get; init; }
}
