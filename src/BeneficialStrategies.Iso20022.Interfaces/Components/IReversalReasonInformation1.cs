// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the reversal reason of the transaction.
/// </summary>
[IsoId("_TPKBodp-Ed-ak6NoX_4Aeg_157540470")]
public interface IReversalReasonInformation1 : IIsoComponent
{
    /// <summary>
    /// Party issuing the reversal.
    /// </summary>
    [IsoId("_TPKBotp-Ed-ak6NoX_4Aeg_157540608")]
    [DisplayName("Reversal Originator")]
    [IsoXmlTag("RvslOrgtr")]
    IPartyIdentification8? ReversalOriginator { get; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TPKBo9p-Ed-ak6NoX_4Aeg_157540556")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    IReversalReason1Choice? ReversalReason { get; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_TPKBpNp-Ed-ak6NoX_4Aeg_157540512")]
    [DisplayName("Additional Reversal Reason Information")]
    [IsoXmlTag("AddtlRvslRsnInf")]
    IEnumerable<Max105Text> AdditionalReversalReasonInformation { get; }
}
