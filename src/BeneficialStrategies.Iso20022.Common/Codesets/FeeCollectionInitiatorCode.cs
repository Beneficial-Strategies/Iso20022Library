// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the initiator of the fee collection message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9YEBsCxJEeyg-aG5nXcnfg")]
[Description(@"Specifies the initiator of the fee collection message.")]
[Derivations(typeof(FeeCollectionInitiator1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FeeCollectionInitiatorCode>))]
#endif
public enum FeeCollectionInitiatorCode
{
    /// <summary>
    /// Entity acquiring card transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_JLz8kCxKEeyg-aG5nXcnfg")]
    [Description(@"Entity acquiring card transaction.")]
    Acquirer,

    /// <summary>
    /// Entity issuing card.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_k1rbkCxKEeyg-aG5nXcnfg")]
    [Description(@"Entity issuing card.")]
    CardIssuer,

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t-qZUCxKEeyg-aG5nXcnfg")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer"
    )]
    Agent,

    /// <summary>
    /// Other entity initiates fee collection defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-S6D4CxKEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Other entity initiates fee collection defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_HfS68CxLEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at national level.")]
    OtherNational,
}
