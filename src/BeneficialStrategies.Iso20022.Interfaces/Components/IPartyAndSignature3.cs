// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_Q_AvW3R1EeiH1ZOt2UD8vQ")]
public interface IPartyAndSignature3 : IIsoComponent
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_RJI7sXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    IPartyIdentification135 Party { get; }

    /// <summary>
    /// Signature of a party.
    /// </summary>
    [IsoId("_RJI7s3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    SkipPayload Signature { get; }
}
