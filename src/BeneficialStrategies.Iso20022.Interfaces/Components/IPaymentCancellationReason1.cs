// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the mandate cancellation request.
/// </summary>
[IsoId("_t4JrBVkyEeGeoaLUQk__nA_-1435065297")]
public interface IPaymentCancellationReason1 : IIsoComponent
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_t4TcAFkyEeGeoaLUQk__nA_1434167759")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification43? Originator { get; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_t4TcAVkyEeGeoaLUQk__nA_2020114785")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_t4TcAlkyEeGeoaLUQk__nA_463313170")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
