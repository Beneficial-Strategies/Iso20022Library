// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason of registration.
/// </summary>
[IsoId("_zxI48RXZEeGmOJpfhCvx_g")]
[DisplayName("Registration Reason")]
public record RegistrationReason3
{
    /// <summary>
    /// Specifies the reaoson of the holding status.
    /// </summary>
    [IsoId("_zxSp8RXZEeGmOJpfhCvx_g")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required Registration7Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_zxSp9RXZEeGmOJpfhCvx_g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; }
}
