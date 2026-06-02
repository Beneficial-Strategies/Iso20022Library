// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial instrument.
/// </summary>
[IsoId("57ef7968-f5e2-4699-a4a6-764e699ef427")]
[DisplayName("Conversion6")]
public record Conversion6
{
    /// <summary>
    /// Identification of the original security.
    /// </summary>
    [IsoId("b52161bd-c43b-417f-bba5-00b2b49d6ec7")]
    [DisplayName("Original Security")]
    [IsoXmlTag("OrgnlScty")]
    public required FinancialInstrumentIdentification7 OriginalSecurity { get; init; }

    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("1c68536d-7e60-4e56-99bb-e461bbc89644")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
