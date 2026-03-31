// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the fee collection initiator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NTwz8CxLEeyg-aG5nXcnfg")]
[Description(@"Code that specifies the fee collection initiator.")]
[DerivedFrom(typeof(FeeCollectionInitiatorCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FeeCollectionInitiator1Code>))]
#endif
public enum FeeCollectionInitiator1Code
{
    /// <summary>
    /// Entity acquiring card transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_Qd1jQSxLEeyg-aG5nXcnfg")]
    [Description(@"Entity acquiring card transaction.")]
    Acquirer = FeeCollectionInitiatorCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_Qih2ASxLEeyg-aG5nXcnfg")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer"
    )]
    Agent = FeeCollectionInitiatorCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity issuing card.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_QnBUcSxLEeyg-aG5nXcnfg")]
    [Description(@"Entity issuing card.")]
    CardIssuer = FeeCollectionInitiatorCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other entity initiates fee collection defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Qs3dwSxLEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at national level.")]
    OtherNational = FeeCollectionInitiatorCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other entity initiates fee collection defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Qw30ASxLEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at private level.")]
    OtherPrivate = FeeCollectionInitiatorCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
