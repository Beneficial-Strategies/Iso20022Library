// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the party to receive the presentation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RvL0sHyeEeGWJuGCfvwOsQ")]
[Description(@"Specifies the party to receive the presentation.")]
[DerivedFrom(typeof(PresentationPartyCode))]
public enum PresentationParty1Code
{
    /// <summary>
    /// Presentation made either to the issuer or other nominated party.
    /// Encoded/decoded by serializers as &quot;ETHR&quot;.
    /// </summary>
    [EnumMember(Value = "ETHR")]
    [IsoId("_cu64tnyeEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made either to the issuer or other nominated party.")]
    IssuerOrOtherNominatatedParty = PresentationPartyCode.IssuerOrOtherNominatatedParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation made exclusively to the confirmer.
    /// Encoded/decoded by serializers as &quot;EXCN&quot;.
    /// </summary>
    [EnumMember(Value = "EXCN")]
    [IsoId("_c1xupnyeEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made exclusively to the confirmer.")]
    ExclusiveConfirmer = PresentationPartyCode.ExclusiveConfirmer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Presentation made exclusively to the issuer.
    /// Encoded/decoded by serializers as &quot;EXIS&quot;.
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_c-toNnyeEeGWJuGCfvwOsQ")]
    [Description(@"Presentation made exclusively to the issuer.")]
    ExclusiveIssuer = PresentationPartyCode.ExclusiveIssuer, // same ordinal as derivation source for type conversions
}
