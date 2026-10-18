// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_w1V-sTEyEe6g-ffJsqGiSA")]
public interface IPartyAndSignature4 : IIsoComponent
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    IPartyIdentification272 Party { get; }

    /// <summary>
    /// Signature of a party.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    SkipPayload Signature { get; }
}
