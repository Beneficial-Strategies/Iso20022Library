// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the return reason of the transaction.
/// </summary>
[IsoId("_TPKBpdp-Ed-ak6NoX_4Aeg_2976420")]
public interface IReturnReasonInformation1 : IIsoComponent
{
    /// <summary>
    /// Party issuing the return.
    /// </summary>
    [IsoId("_TPKBptp-Ed-ak6NoX_4Aeg_1003149399")]
    [DisplayName("Return Originator")]
    [IsoXmlTag("RtrOrgtr")]
    IPartyIdentification8? ReturnOriginator { get; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TPKBp9p-Ed-ak6NoX_4Aeg_515527494")]
    [DisplayName("Return Reason")]
    [IsoXmlTag("RtrRsn")]
    IReturnReason1Choice? ReturnReason { get; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TPKBqNp-Ed-ak6NoX_4Aeg_84246003")]
    [DisplayName("Additional Return Reason Information")]
    [IsoXmlTag("AddtlRtrRsnInf")]
    IEnumerable<IsoMax105Text> AdditionalReturnReasonInformation { get; }
}
