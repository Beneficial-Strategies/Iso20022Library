// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the proprietary status and reason of an instruction or an instruction cancellation.
/// </summary>
[IsoId("_UatOwdp-Ed-ak6NoX_4Aeg_-1279072871")]
[DisplayName("Proprietary Status And Reason")]
public record ProprietaryStatusAndReason1
{
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    [IsoId("_UatOwtp-Ed-ak6NoX_4Aeg_-1158092658")]
    [DisplayName("Proprietary Status")]
    [IsoXmlTag("PrtrySts")]
    public required GenericIdentification20 ProprietaryStatus { get; init; }

    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    [IsoId("_UatOw9p-Ed-ak6NoX_4Aeg_-1512024757")]
    [DisplayName("Proprietary Reason")]
    [IsoXmlTag("PrtryRsn")]
    public ProprietaryReason1? ProprietaryReason { get; init; }
}
