// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Cancellation Reason2.
/// </summary>
[IsoId("_5w0E6TEyEe6g-ffJsqGiSA")]
public interface IMandateCancellationReason2 : IIsoComponent
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification272? Originator { get; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }
}
