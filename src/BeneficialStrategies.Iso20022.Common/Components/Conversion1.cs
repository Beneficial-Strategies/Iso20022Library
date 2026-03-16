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
[IsoId("__Z0PQE3dEeidB49bWZiS0g")]
[DisplayName("Conversion")]
public record Conversion1
{
    /// <summary>
    /// Identification of the target security.
    /// </summary>
    [IsoId("_LKm8wU3eEeidB49bWZiS0g")]
    [DisplayName("Target Security")]
    [IsoXmlTag("TrgtScty")]
    public required FinancialInstrumentIdentification1 TargetSecurity { get; init; }

    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("_V7oZ4E3fEeidB49bWZiS0g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
