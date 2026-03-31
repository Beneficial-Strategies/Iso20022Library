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
[IsoId("_yRcdkTp4EeWVrPy0StzzSg")]
[DisplayName("Proprietary Status And Reason")]
public record ProprietaryStatusAndReason6
{
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    [IsoId("_y0NzcTp4EeWVrPy0StzzSg")]
    [DisplayName("Proprietary Status")]
    [IsoXmlTag("PrtrySts")]
    public required GenericIdentification30 ProprietaryStatus { get; init; }

    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    [IsoId("_y0OagTp4EeWVrPy0StzzSg")]
    [DisplayName("Proprietary Reason")]
    [IsoXmlTag("PrtryRsn")]
    public ValueList<ProprietaryReason4> ProprietaryReason { get; init; } = [];
}
