// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_5VcU1TbsEead9bDRE_1DAQ")]
[DisplayName("Order Status And Reason")]
public record OrderStatusAndReason9
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_5uS5tTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    [IsoId("_MlLY8EgsEeaD2L_hzZaE0w")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public required CancellationStatus22Choice_ CancellationStatus { get; init; }

    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("_5uS5uzbsEead9bDRE_1DAQ")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification113? StatusInitiator { get; init; }
}
