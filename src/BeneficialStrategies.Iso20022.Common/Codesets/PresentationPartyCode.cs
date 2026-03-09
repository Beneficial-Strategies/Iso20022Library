// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the party to receive the presentation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v7BzIHycEeGWJuGCfvwOsQ")]
[Description(@"Specifies the party to receive the presentation.")]
[Derivations(typeof(PresentationParty1Code))]
public enum PresentationPartyCode
{
    /// <summary>
    /// Presentation made exclusively to the confirmer.
    /// Encoded/decoded by serializers as &quot;EXCN&quot;.
    /// </summary>
    [EnumMember(Value = "EXCN")]
    [IsoId("_miKJ0HydEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made exclusively to the confirmer.")]
    ExclusiveConfirmer,
    
    /// <summary>
    /// Presentation made exclusively to the issuer.
    /// Encoded/decoded by serializers as &quot;EXIS&quot;.
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_t0V-AHydEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made exclusively to the issuer.")]
    ExclusiveIssuer,
    
    /// <summary>
    /// Presentation made either to the issuer or other nominated party.
    /// Encoded/decoded by serializers as &quot;ETHR&quot;.
    /// </summary>
    [EnumMember(Value = "ETHR")]
    [IsoId("_3TDUIHydEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made either to the issuer or other nominated party.")]
    IssuerOrOtherNominatatedParty,
    
}
