// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the mandate cancellation request.
/// </summary>
[IsoId("_TOt8yNp-Ed-ak6NoX_4Aeg_993731779")]
public interface ICancellationReasonInformation2 : IIsoComponent
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_TO3GsNp-Ed-ak6NoX_4Aeg_-102160306")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification32? Originator { get; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_TO3Gsdp-Ed-ak6NoX_4Aeg_-190159100")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_TO3Gstp-Ed-ak6NoX_4Aeg_256167406")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
