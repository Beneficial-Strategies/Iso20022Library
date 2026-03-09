// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the report includes pending or settled transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x8pjANBUEeiirviLm7P0IA")]
[Description(@"Specifies whether the report includes pending or settled transactions.")]
[Derivations(typeof(StatementStatusType1Code))]
public enum StatementStatusTypeCode
{
    /// <summary>
    /// Transactions reported are confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_DQH18NBVEeiirviLm7P0IA")]
    [Description(@"Transactions reported are confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Instructions or transactions  reported are pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_SbArwNBVEeiirviLm7P0IA")]
    [Description(@"Instructions or transactions  reported are pending.")]
    Pending,
    
}
