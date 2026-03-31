// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_3zSo0FSDEemTt7251YwCKw")]
[DisplayName("Linkages")]
public record Linkages58
{
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_cb45MFSLEemTt7251YwCKw")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction or instruction.
    /// </summary>
    [IsoId("_x_BDcFSLEemTt7251YwCKw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References70Choice_ References { get; init; }
}
