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
[IsoId("ae633bfa-0b92-4282-b7a0-62cf5ed05e04")]
[DisplayName("Conversion5")]
public record Conversion5
{
    /// <summary>
    /// Identification of the target security.
    /// </summary>
    [IsoId("76971682-2587-43b7-b365-1266d67f58da")]
    [DisplayName("Target Security")]
    [IsoXmlTag("TrgtScty")]
    public required FinancialInstrumentIdentification7 TargetSecurity { get; init; }

    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("7661a6e1-0dec-4ee5-a08a-5b7fc3d10c0f")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
