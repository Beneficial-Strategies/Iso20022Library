// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of the replacement request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZwirANp-Ed-ak6NoX_4Aeg_478087079")]
[Description(@"Specifies the processing status of the replacement request.")]
[Derivations(typeof(ReplacementProcessingStatus1Code))]
public enum ReplacementProcessingStatusCode
{
    /// <summary>
    /// Replacement request cannot be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZwirAdp-Ed-ak6NoX_4Aeg_1109777748")]
    [Description(@"Replacement request cannot be executed.")]
    Denied,
    
    /// <summary>
    /// Replacement request previously received from you has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_ZwirAtp-Ed-ak6NoX_4Aeg_1441321726")]
    [Description(@"Replacement request previously received from you has been received at the stock exchange.")]
    ReceivedAtStockExchange,
    
    /// <summary>
    /// Replacement request previously received from you has been received at intermediary (if not stock exchange).
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZwirA9p-Ed-ak6NoX_4Aeg_1498577579")]
    [Description(@"Replacement request previously received from you has been received at intermediary (if not stock exchange).")]
    ReceivedAtIntermediary,
    
    /// <summary>
    /// Replacement request has been accepted for further processing by the account servicer (technical receipt).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZwirBNp-Ed-ak6NoX_4Aeg_1579850029")]
    [Description(@"Replacement request has been accepted for further processing by the account servicer (technical receipt).")]
    Accepted,
    
    /// <summary>
    /// Order is partially filled, replacement processing accepted for the remaining.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZwirBdp-Ed-ak6NoX_4Aeg_1612172256")]
    [Description(@"Order is partially filled, replacement processing accepted for the remaining.")]
    PartialReplacementAccepted,
    
    /// <summary>
    /// Replacement request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZwirBtp-Ed-ak6NoX_4Aeg_1987122153")]
    [Description(@"Replacement request is pending.")]
    Pending,
    
    /// <summary>
    /// Replacement request has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZwirB9p-Ed-ak6NoX_4Aeg_-2050182268")]
    [Description(@"Replacement request has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Replacement request has been completed.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_ZwirCNp-Ed-ak6NoX_4Aeg_-1979995218")]
    [Description(@"Replacement request has been completed.")]
    Completed,
    
    /// <summary>
    /// Replacement request previously received from you is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZwirCdp-Ed-ak6NoX_4Aeg_-1937515093")]
    [Description(@"Replacement request previously received from you is in repair.")]
    InRepair,
    
}
