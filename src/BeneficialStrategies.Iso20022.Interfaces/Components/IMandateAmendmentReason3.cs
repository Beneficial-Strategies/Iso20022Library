// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the amendment of the mandate.
/// </summary>
[IsoId("_yUI4ITEyEe6g-ffJsqGiSA")]
public interface IMandateAmendmentReason3 : IIsoComponent
{
    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }

    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification272? Originator { get; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }
}
