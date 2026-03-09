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
    /// Reason for the failed settlement status.
    /// </summary>
    [KnownType(typeof(FailedSettlementStatus2Choice.Reason))]
    [KnownType(typeof(FailedSettlementStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(FailedSettlementStatus2Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailedSettlementStatus2Choice.Reason),nameof(FailedSettlementStatus2Choice.Reason))]
    [JsonDerivedType(typeof(FailedSettlementStatus2Choice.DataSourceScheme),nameof(FailedSettlementStatus2Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(FailedSettlementStatus2Choice.NoSpecifiedReason),nameof(FailedSettlementStatus2Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_DOTJ4SY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Failed Settlement Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailedSettlementStatus2Choice_
    #else
    public abstract partial class FailedSettlementStatus2Choice_
    #endif
    {
    }
}
