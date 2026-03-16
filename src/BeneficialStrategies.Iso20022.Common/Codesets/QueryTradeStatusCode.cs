// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry status of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LmV-saacEeSR8qifggAitQ")]
[Description(@"Specifies the inquiry status of the trade.")]
[Derivations(typeof(QueryTradeStatus1Code))]
public enum QueryTradeStatusCode
{
    /// <summary>
    /// Query for all trades.
    /// Encoded/decoded by serializers as &quot;QAST&quot;.
    /// </summary>
    [EnumMember(Value = "QAST")]
    [IsoId("_kHkRwKacEeSR8qifggAitQ")]
    [Description(@"Query for all trades.")]
    QueryAllStatus,

    /// <summary>
    /// Query for new trades.
    /// Encoded/decoded by serializers as &quot;QNTR&quot;.
    /// </summary>
    [EnumMember(Value = "QNTR")]
    [IsoId("_kRQZQKacEeSR8qifggAitQ")]
    [Description(@"Query for new trades.")]
    QueryNewTrade,

    /// <summary>
    /// Query for trades have been canceled.
    /// Encoded/decoded by serializers as &quot;QCTR&quot;.
    /// </summary>
    [EnumMember(Value = "QCTR")]
    [IsoId("_kVkRgKacEeSR8qifggAitQ")]
    [Description(@"Query for trades have been canceled.")]
    QueryCanceledTrade,

    /// <summary>
    /// Query for trades have been replaced.
    /// Encoded/decoded by serializers as &quot;QRTR&quot;.
    /// </summary>
    [EnumMember(Value = "QRTR")]
    [IsoId("_kXgLMKacEeSR8qifggAitQ")]
    [Description(@"Query for trades have been replaced.")]
    QueryReplacedTrade,

    /// <summary>
    /// Query for emergency trades.
    /// Encoded/decoded by serializers as &quot;QETR&quot;.
    /// </summary>
    [EnumMember(Value = "QETR")]
    [IsoId("_yRy70KacEeSR8qifggAitQ")]
    [Description(@"Query for emergency trades.")]
    QueryEmergencyTrade,

    /// <summary>
    /// Query for cancelling trades.
    /// Encoded/decoded by serializers as &quot;QCIR&quot;.
    /// </summary>
    [EnumMember(Value = "QCIR")]
    [IsoId("_8K2roKacEeSR8qifggAitQ")]
    [Description(@"Query for cancelling trades.")]
    QueryCancellingTrade,
}
