// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_RBmk8tp-Ed-ak6NoX_4Aeg_-1323180575")]
public interface IMandateCancellation1 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_RBmk89p-Ed-ak6NoX_4Aeg_-383303184")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_RBmk9Np-Ed-ak6NoX_4Aeg_-788540285")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    ICancellationReasonInformation2 CancellationReason { get; }

    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    [IsoId("_RBmk9dp-Ed-ak6NoX_4Aeg_-378686473")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate1Choice OriginalMandate { get; }
}
