// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Suspension Reason3.
/// </summary>
[IsoId("_4TGJuzEyEe6g-ffJsqGiSA")]
public interface IMandateSuspensionReason3 : IIsoComponent
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
    IMandateSuspensionReason1Choice Reason { get; }
}
