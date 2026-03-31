// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or device that has performed the verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arLtkWjoEeSDR-pyia6Xtg")]
[Description(@"Entity or device that has performed the verification.")]
[DerivedFrom(typeof(AuthenticationEntityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthenticationEntity2Code>))]
#endif
public enum AuthenticationEntity2Code
{
    /// <summary>
    /// Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_a4ZqMWjoEeSDR-pyia6Xtg")]
    [Description(
        @"Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification."
    )]
    ICC = AuthenticationEntityCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation agent of the issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_a4ZqM2joEeSDR-pyia6Xtg")]
    [Description(@"Authorisation agent of the issuer.")]
    AuthorisedAgent = AuthenticationEntityCode.AuthorisedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_a4ZqNWjoEeSDR-pyia6Xtg")]
    [Description(@"Merchant (for example signature verification by the attendant).")]
    Merchant = AuthenticationEntityCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_xWp_8WjoEeSDR-pyia6Xtg")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer = AuthenticationEntityCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_xlWjQWjoEeSDR-pyia6Xtg")]
    [Description(@"Card issuer.")]
    Issuer = AuthenticationEntityCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure application in the terminal.
    /// Encoded/decoded by serializers as &quot;TRML&quot;.
    /// </summary>
    [EnumMember(Value = "TRML")]
    [IsoId("_xytCwWjoEeSDR-pyia6Xtg")]
    [Description(@"Secure application in the terminal.")]
    Terminal = AuthenticationEntityCode.Terminal, // same ordinal as derivation source for type conversions
}
