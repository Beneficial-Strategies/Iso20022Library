// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// No specified reason available for the status.
/// </summary>
[IsoId("_UakE19p-Ed-ak6NoX_4Aeg_-1550563657")]
[DisplayName("No Specified Reason")]
public record NoSpecifiedReason1
{
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; }
}
