// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the status reason of the transaction.
/// </summary>
[IsoId("_TPA3stp-Ed-ak6NoX_4Aeg_-1001293915")]
public interface IStatusReasonInformation1 : IIsoComponent
{
    /// <summary>
    /// Party issuing the status.
    /// </summary>
    [IsoId("_TPA3s9p-Ed-ak6NoX_4Aeg_-1001293584")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    IPartyIdentification8? StatusOriginator { get; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TPA3tNp-Ed-ak6NoX_4Aeg_-1001293862")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    IStatusReason1Choice? StatusReason { get; }

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes, e.g. to report repaired information, or to further detail the status reason.
    /// </summary>
    [IsoId("_TPA3tdp-Ed-ak6NoX_4Aeg_-80545028")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    IEnumerable<IsoMax105Text> AdditionalStatusReasonInformation { get; }
}
