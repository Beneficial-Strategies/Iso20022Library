// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or object in charge of verifying the cardholder authenticity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSESjQEcEeCQm6a_G2yO_w_-1884722384")]
[Description(@"Entity or object in charge of verifying the cardholder authenticity.")]
[DerivedFrom(typeof(AuthenticationEntityCode))]
public enum AuthenticationEntity1Code
{
    /// <summary>
    /// Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_TSESjgEcEeCQm6a_G2yO_w_2010756602")]
    [Description(
        @"Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification."
    )]
    ICC = AuthenticationEntityCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation agent of the issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_TSESjwEcEeCQm6a_G2yO_w_1127523315")]
    [Description(@"Authorisation agent of the issuer.")]
    AuthorisedAgent = AuthenticationEntityCode.AuthorisedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TSESkAEcEeCQm6a_G2yO_w_-1384309028")]
    [Description(@"Merchant (for example signature verification by the attendant).")]
    Merchant = AuthenticationEntityCode.Merchant, // same ordinal as derivation source for type conversions
}
