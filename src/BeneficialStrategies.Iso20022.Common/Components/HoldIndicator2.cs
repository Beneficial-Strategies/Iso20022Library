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
[IsoId("_sCslEPIqEd-dOvqmSLSz5g")]
[DisplayName("Hold Indicator")]
public record HoldIndicator2
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_4oPwUPIqEd-dOvqmSLSz5g")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Indicator { get; init; }

    /// <summary>
    /// Specifies the reason of the registration staus.
    /// </summary>
    [IsoId("_OsayIPIrEd-dOvqmSLSz5g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RegistrationReason1> Reason { get; init; } = [];
}
