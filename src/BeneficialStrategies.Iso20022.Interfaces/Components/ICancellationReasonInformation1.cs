// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the cancellation reason of the transaction.
/// </summary>
[IsoId("_TO3Gttp-Ed-ak6NoX_4Aeg_-436227161")]
public interface ICancellationReasonInformation1 : IIsoComponent
{
    /// <summary>
    /// Party issuing the cancellation request.
    /// </summary>
    [IsoId("_TO3Gt9p-Ed-ak6NoX_4Aeg_-436226813")]
    [DisplayName("Cancellation Originator")]
    [IsoXmlTag("CxlOrgtr")]
    IPartyIdentification8? CancellationOriginator { get; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_TPA3sNp-Ed-ak6NoX_4Aeg_-436226866")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    ICancellationReason1Choice? CancellationReason { get; }

    /// <summary>
    /// Further details on the cancellation request reason.||Usage: Additional cancellation reason information can be used to further detail the cancellation request reason.
    /// </summary>
    [IsoId("_TPA3sdp-Ed-ak6NoX_4Aeg_-436227125")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    IEnumerable<IsoMax105Text> AdditionalCancellationReasonInformation { get; }
}
