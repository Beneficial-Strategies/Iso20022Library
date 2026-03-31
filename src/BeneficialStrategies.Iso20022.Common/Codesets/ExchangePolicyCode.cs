// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange policy between parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KR1s8X1DEeCF8NjrBemJWQ_-1574352782")]
[Description(@"Exchange policy between parties.")]
[Derivations(typeof(ExchangePolicy1Code), typeof(ExchangePolicy2Code))]
public enum ExchangePolicyCode
{
    /// <summary>
    /// Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.
    /// Encoded/decoded by serializers as &quot;ONDM&quot;.
    /// </summary>
    [EnumMember(Value = "ONDM")]
    [IsoId("_KR1s8n1DEeCF8NjrBemJWQ_-1538833043")]
    [Description(
        @"Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor."
    )]
    OnDemand,

    /// <summary>
    /// Exchange is performed just after the transaction completion.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_KR1s831DEeCF8NjrBemJWQ_1759061900")]
    [Description(@"Exchange is performed just after the transaction completion.")]
    Immediately,

    /// <summary>
    /// As soon as the acquirer is contacted, for example with the next on-line transaction.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_KR1s9H1DEeCF8NjrBemJWQ_-1360714371")]
    [Description(
        @"As soon as the acquirer is contacted, for example with the next on-line transaction."
    )]
    AsSoonAsPossible,

    /// <summary>
    /// Exchanges are performed after reaching a maximum number of transaction or time period.
    /// Encoded/decoded by serializers as &quot;AGRP&quot;.
    /// </summary>
    [EnumMember(Value = "AGRP")]
    [IsoId("_KR1s9X1DEeCF8NjrBemJWQ_1937180572")]
    [Description(
        @"Exchanges are performed after reaching a maximum number of transaction or time period."
    )]
    AsGroup,

    /// <summary>
    /// Exchange is performed after reaching a number of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;NBLT&quot;.
    /// </summary>
    [EnumMember(Value = "NBLT")]
    [IsoId("_KR1s9n1DEeCF8NjrBemJWQ_-1652672109")]
    [Description(
        @"Exchange is performed after reaching a number of transactions without exchanges with the acquirer."
    )]
    NumberLimit,

    /// <summary>
    /// Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as &quot;TTLT&quot;.
    /// </summary>
    [EnumMember(Value = "TTLT")]
    [IsoId("_KR1s931DEeCF8NjrBemJWQ_-1474553437")]
    [Description(
        @"Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer."
    )]
    TotalLimit,

    /// <summary>
    /// Cyclic exchanges based on the related time conditions.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_KR1s-H1DEeCF8NjrBemJWQ_182113240")]
    [Description(@"Cyclic exchanges based on the related time conditions.")]
    Cyclic,

    /// <summary>
    /// No exchange.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_KR1s-X1DEeCF8NjrBemJWQ_-612711196")]
    [Description(@"No exchange.")]
    None,

    /// <summary>
    /// All pending process must be paused until exchange is exclusively performed just after the transaction completion.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_xQvLkA0vEeqUVL7sB4m7NA")]
    [Description(
        @"All pending process must be paused until exchange is exclusively performed just after the transaction completion."
    )]
    Blocking,
}
