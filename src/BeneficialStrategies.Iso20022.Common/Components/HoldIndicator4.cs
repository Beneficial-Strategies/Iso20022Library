// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the transaction is on hold/blocked/frozen.
/// </summary>
[IsoId("_shQx4RXZEeGmOJpfhCvx_g")]
[DisplayName("Hold Indicator")]
public record HoldIndicator4
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_shQx4xXZEeGmOJpfhCvx_g")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Indicator { get; init; }

    /// <summary>
    /// Specifies the reason of the registration staus.
    /// </summary>
    [IsoId("_shQx5xXZEeGmOJpfhCvx_g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public RegistrationReason3? Reason { get; init; }
}
