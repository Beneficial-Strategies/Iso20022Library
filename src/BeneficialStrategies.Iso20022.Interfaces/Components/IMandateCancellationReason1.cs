// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the mandate cancellation request.
/// </summary>
[IsoId("_HSwZ2249EeiU9cctagi5ow")]
public interface IMandateCancellationReason1 : IIsoComponent
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_Hfkt0249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification135? Originator { get; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_Hfkt1W49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_Hfkt1249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
