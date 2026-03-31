// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity acting as a Payment Initiation Service Provider.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SBhCMJmMEee_M7tURHTZTQ")]
[Description(@"Type of entity acting as a Payment Initiation Service Provider.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType26Code>))]
#endif
public enum PartyType26Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_UUqwkZmMEee_M7tURHTZTQ")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_UjpAsZmMEee_M7tURHTZTQ")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_VJ4hUZmMEee_M7tURHTZTQ")]
    [Description(@"Application in the smart card.")]
    CardApplication = PartyTypeCode.CardApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_ViAtcZmMEee_M7tURHTZTQ")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_Wz7oUZmMEee_M7tURHTZTQ")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_X5jMkZmMEee_M7tURHTZTQ")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_fdQOkZmMEee_M7tURHTZTQ")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_frdpsZmMEee_M7tURHTZTQ")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
