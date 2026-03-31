// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange policy between parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KRiyAH1DEeCF8NjrBemJWQ_-642247861")]
[Description(@"Exchange policy between parties.")]
[DerivedFrom(typeof(ExchangePolicyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExchangePolicy1Code>))]
#endif
public enum ExchangePolicy1Code
{
    /// <summary>
    /// Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.
    /// Encoded/decoded by serializers as &quot;ONDM&quot;.
    /// </summary>
    [EnumMember(Value = "ONDM")]
    [IsoId("_KRsjAH1DEeCF8NjrBemJWQ_-1296053757")]
    [Description(
        @"Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor."
    )]
    OnDemand = ExchangePolicyCode.OnDemand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed just after the transaction completion.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_KRsjAX1DEeCF8NjrBemJWQ_-1946713364")]
    [Description(@"Exchange is performed just after the transaction completion.")]
    Immediately = ExchangePolicyCode.Immediately, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As soon as the acquirer is contacted, for example with the next on-line transaction.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_KRsjAn1DEeCF8NjrBemJWQ_799792606")]
    [Description(
        @"As soon as the acquirer is contacted, for example with the next on-line transaction."
    )]
    AsSoonAsPossible = ExchangePolicyCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchanges are performed after reaching a maximum number of transaction or time period.
    /// Encoded/decoded by serializers as &quot;AGRP&quot;.
    /// </summary>
    [EnumMember(Value = "AGRP")]
    [IsoId("_KRsjA31DEeCF8NjrBemJWQ_-2068447648")]
    [Description(
        @"Exchanges are performed after reaching a maximum number of transaction or time period."
    )]
    AsGroup = ExchangePolicyCode.AsGroup, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed after reaching a number of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;NBLT&quot;.
    /// </summary>
    [EnumMember(Value = "NBLT")]
    [IsoId("_KRsjBH1DEeCF8NjrBemJWQ_-1391748620")]
    [Description(
        @"Exchange is performed after reaching a number of transactions without exchanges with the acquirer."
    )]
    NumberLimit = ExchangePolicyCode.NumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;TTLT&quot;.
    /// </summary>
    [EnumMember(Value = "TTLT")]
    [IsoId("_KRsjBX1DEeCF8NjrBemJWQ_1174078869")]
    [Description(
        @"Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer."
    )]
    TotalLimit = ExchangePolicyCode.TotalLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cyclic exchanges based on the related time conditions.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_KRsjBn1DEeCF8NjrBemJWQ_-164514241")]
    [Description(@"Cyclic exchanges based on the related time conditions.")]
    Cyclic = ExchangePolicyCode.Cyclic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No exchange.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_KR1s8H1DEeCF8NjrBemJWQ_-65190958")]
    [Description(@"No exchange.")]
    None = ExchangePolicyCode.None, // same ordinal as derivation source for type conversions
}
