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
    /// Specifies the settlement failure reason as defined in the relevant regulation or explicit no data report..
    /// </summary>
    [KnownType(typeof(SettlementDailyFailureReason1Choice.DataSetAction))]
    [KnownType(typeof(SettlementDailyFailureReason1Choice.Data))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDailyFailureReason1Choice.DataSetAction),nameof(SettlementDailyFailureReason1Choice.DataSetAction))]
    [JsonDerivedType(typeof(SettlementDailyFailureReason1Choice.Data),nameof(SettlementDailyFailureReason1Choice.Data))]
    #endif
    [IsoId("_-7zQ0TOkEeqX8uoQQ3KffQ")]
    [DisplayName("Settlement Daily Failure Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDailyFailureReason1Choice_
    #else
    public abstract partial class SettlementDailyFailureReason1Choice_
    #endif
    {
    }
}
