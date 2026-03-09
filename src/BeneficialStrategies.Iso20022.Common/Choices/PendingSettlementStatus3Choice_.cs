// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the pending settlement status.
    /// </summary>
    [KnownType(typeof(PendingSettlementStatus3Choice.Reason))]
    [KnownType(typeof(PendingSettlementStatus3Choice.ExtendedReason))]
    [KnownType(typeof(PendingSettlementStatus3Choice.DataSourceScheme))]
    [KnownType(typeof(PendingSettlementStatus3Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingSettlementStatus3Choice.Reason),nameof(PendingSettlementStatus3Choice.Reason))]
    [JsonDerivedType(typeof(PendingSettlementStatus3Choice.ExtendedReason),nameof(PendingSettlementStatus3Choice.ExtendedReason))]
    [JsonDerivedType(typeof(PendingSettlementStatus3Choice.DataSourceScheme),nameof(PendingSettlementStatus3Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(PendingSettlementStatus3Choice.NoSpecifiedReason),nameof(PendingSettlementStatus3Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_LPufISY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Pending Settlement Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingSettlementStatus3Choice_
    #else
    public abstract partial class PendingSettlementStatus3Choice_
    #endif
    {
    }
}
