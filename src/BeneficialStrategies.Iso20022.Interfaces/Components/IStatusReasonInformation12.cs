// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the transaction.
/// </summary>
[IsoId("_E6Ui6W49EeiU9cctagi5ow")]
public interface IStatusReasonInformation12 : IIsoComponent
{
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_FD25VW49EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification135? Originator { get; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_FD25V249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IStatusReason6Choice? Reason { get; }

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_FD25WW49EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<Max105Text> AdditionalInformation { get; }
}
