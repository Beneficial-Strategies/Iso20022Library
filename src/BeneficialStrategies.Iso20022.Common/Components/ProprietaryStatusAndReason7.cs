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
[IsoId("_cemew5KQEeWHWpTQn1FFVg")]
[DisplayName("Proprietary Status And Reason")]
public record ProprietaryStatusAndReason7
{
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    [IsoId("_cemexZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proprietary Status")]
    [IsoXmlTag("PrtrySts")]
    public required GenericIdentification47 ProprietaryStatus { get; init; }

    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    [IsoId("_cemex5KQEeWHWpTQn1FFVg")]
    [DisplayName("Proprietary Reason")]
    [IsoXmlTag("PrtryRsn")]
    public ProprietaryReason5? ProprietaryReason { get; init; }
}
