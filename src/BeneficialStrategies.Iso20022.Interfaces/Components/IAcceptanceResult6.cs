// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the acceptance result.
/// </summary>
[IsoId("_RBvu4dp-Ed-ak6NoX_4Aeg_2046006177")]
public interface IAcceptanceResult6 : IIsoComponent
{
    /// <summary>
    /// Indicates whether the mandate request was accepted or rejected.
    /// </summary>
    [IsoId("_RBvu4tp-Ed-ak6NoX_4Aeg_1773632231")]
    [DisplayName("Accepted")]
    [IsoXmlTag("Accptd")]
    IsoYesNoIndicator Accepted { get; }

    /// <summary>
    /// Specifies the reason for the rejection of a mandate request.
    /// </summary>
    [IsoId("_RBvu49p-Ed-ak6NoX_4Aeg_1929136883")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    IMandateReason1Choice? RejectReason { get; }

    /// <summary>
    /// Further details on the reject reason.
    /// </summary>
    [IsoId("_RBvu5Np-Ed-ak6NoX_4Aeg_-192674430")]
    [DisplayName("Additional Reject Reason Information")]
    [IsoXmlTag("AddtlRjctRsnInf")]
    IEnumerable<IsoMax105Text> AdditionalRejectReasonInformation { get; }
}
