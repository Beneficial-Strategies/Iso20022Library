// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry status of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tAngoKadEeSR8qifggAitQ")]
[Description(@"Specifies the inquiry status of the trade.")]
[DerivedFrom(typeof(QueryTradeStatusCode))]
public enum QueryTradeStatus1Code
{
    /// <summary>
    /// Query for all trades.
    /// Encoded/decoded by serializers as &quot;QAST&quot;.
    /// </summary>
    [EnumMember(Value = "QAST")]
    [IsoId("_vWekwaadEeSR8qifggAitQ")]
    [Description(@"Query for all trades.")]
    QueryAllStatus = QueryTradeStatusCode.QueryAllStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for trades have been canceled.
    /// Encoded/decoded by serializers as &quot;QCTR&quot;.
    /// </summary>
    [EnumMember(Value = "QCTR")]
    [IsoId("_vcIg0aadEeSR8qifggAitQ")]
    [Description(@"Query for trades have been canceled.")]
    QueryCanceledTrade = QueryTradeStatusCode.QueryCanceledTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for cancelling trades.
    /// Encoded/decoded by serializers as &quot;QCIR&quot;.
    /// </summary>
    [EnumMember(Value = "QCIR")]
    [IsoId("_vhor4aadEeSR8qifggAitQ")]
    [Description(@"Query for cancelling trades.")]
    QueryCancellingTrade = QueryTradeStatusCode.QueryCancellingTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for emergency trades.
    /// Encoded/decoded by serializers as &quot;QETR&quot;.
    /// </summary>
    [EnumMember(Value = "QETR")]
    [IsoId("_vnI28aadEeSR8qifggAitQ")]
    [Description(@"Query for emergency trades.")]
    QueryEmergencyTrade = QueryTradeStatusCode.QueryEmergencyTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for new trades.
    /// Encoded/decoded by serializers as &quot;QNTR&quot;.
    /// </summary>
    [EnumMember(Value = "QNTR")]
    [IsoId("_vsppEaadEeSR8qifggAitQ")]
    [Description(@"Query for new trades.")]
    QueryNewTrade = QueryTradeStatusCode.QueryNewTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for trades have been replaced.
    /// Encoded/decoded by serializers as &quot;QRTR&quot;.
    /// </summary>
    [EnumMember(Value = "QRTR")]
    [IsoId("_vyQh0aadEeSR8qifggAitQ")]
    [Description(@"Query for trades have been replaced.")]
    QueryReplacedTrade = QueryTradeStatusCode.QueryReplacedTrade, // same ordinal as derivation source for type conversions
    
}
