// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_QVynMUQlEeiO2efj8UFv0A")]
[DisplayName("Processing Result")]
public record ProcessingResult8
{
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_Qh_QIUQlEeiO2efj8UFv0A")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData1? ResultData { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_Qh_QJUQlEeiO2efj8UFv0A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation20> AdditionalInformation { get; init; } = [];
}
