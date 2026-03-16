// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange policy between parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mEFs8Q0vEeqUVL7sB4m7NA")]
[Description(@"Exchange policy between parties.")]
[DerivedFrom(typeof(ExchangePolicyCode))]
public enum ExchangePolicy2Code
{
    /// <summary>
    /// Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.
    /// Encoded/decoded by serializers as &quot;ONDM&quot;.
    /// </summary>
    [EnumMember(Value = "ONDM")]
    [IsoId("_mQNdYQ0vEeqUVL7sB4m7NA")]
    [Description(
        @"Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor."
    )]
    OnDemand = ExchangePolicyCode.OnDemand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed just after the transaction completion.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_mQNdYw0vEeqUVL7sB4m7NA")]
    [Description(@"Exchange is performed just after the transaction completion.")]
    Immediately = ExchangePolicyCode.Immediately, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As soon as the acquirer is contacted, for example with the next on-line transaction.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_mQNdZQ0vEeqUVL7sB4m7NA")]
    [Description(
        @"As soon as the acquirer is contacted, for example with the next on-line transaction."
    )]
    AsSoonAsPossible = ExchangePolicyCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchanges are performed after reaching a maximum number of transaction or time period.
    /// Encoded/decoded by serializers as &quot;AGRP&quot;.
    /// </summary>
    [EnumMember(Value = "AGRP")]
    [IsoId("_mQNdZw0vEeqUVL7sB4m7NA")]
    [Description(
        @"Exchanges are performed after reaching a maximum number of transaction or time period."
    )]
    AsGroup = ExchangePolicyCode.AsGroup, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed after reaching a number of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;NBLT&quot;.
    /// </summary>
    [EnumMember(Value = "NBLT")]
    [IsoId("_mQNdaQ0vEeqUVL7sB4m7NA")]
    [Description(
        @"Exchange is performed after reaching a number of transactions without exchanges with the acquirer."
    )]
    NumberLimit = ExchangePolicyCode.NumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;TTLT&quot;.
    /// </summary>
    [EnumMember(Value = "TTLT")]
    [IsoId("_mQNdaw0vEeqUVL7sB4m7NA")]
    [Description(
        @"Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer."
    )]
    TotalLimit = ExchangePolicyCode.TotalLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cyclic exchanges based on the related time conditions.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_mQNdbQ0vEeqUVL7sB4m7NA")]
    [Description(@"Cyclic exchanges based on the related time conditions.")]
    Cyclic = ExchangePolicyCode.Cyclic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No exchange.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mQNdbw0vEeqUVL7sB4m7NA")]
    [Description(@"No exchange.")]
    None = ExchangePolicyCode.None, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All pending process must be paused until exchange is exclusively performed just after the transaction completion.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_Lya6gQ0wEeqUVL7sB4m7NA")]
    [Description(
        @"All pending process must be paused until exchange is exclusively performed just after the transaction completion."
    )]
    Blocking = ExchangePolicyCode.Blocking, // same ordinal as derivation source for type conversions
}
