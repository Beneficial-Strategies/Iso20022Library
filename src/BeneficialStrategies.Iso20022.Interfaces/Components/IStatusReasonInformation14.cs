// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the transaction.
/// </summary>
[IsoId("_xPVMATEyEe6g-ffJsqGiSA")]
public interface IStatusReasonInformation14 : IIsoComponent
{
    /// <summary>
    /// Further details on the status reason.
    /// Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }

    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification272? Originator { get; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IStatusReason6Choice? Reason { get; }
}
