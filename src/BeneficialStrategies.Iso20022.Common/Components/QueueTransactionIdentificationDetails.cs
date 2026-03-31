// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a payment instruction by its relative position in a queue of payment transactions managed by the clearing agent.
/// </summary>
[IsoId("_Rb1C09p-Ed-ak6NoX_4Aeg_1491461462")]
[DisplayName("Queue Transaction Identification Details")]
public record QueueTransactionIdentificationDetails
{
    /// <summary>
    /// Identification of the payment queue where the payment instruction resides.
    /// </summary>
    [IsoId("_Rb1C1Np-Ed-ak6NoX_4Aeg_1491461463")]
    [DisplayName("Queue Identification")]
    [IsoXmlTag("QId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text QueueIdentification { get; init; }

    /// <summary>
    /// Position of the payment instruction within the identified queue.
    /// </summary>
    [IsoId("_Rb1C1dp-Ed-ak6NoX_4Aeg_1491461464")]
    [DisplayName("Position In Queue")]
    [IsoXmlTag("PosInQ")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text PositionInQueue { get; init; }
}
