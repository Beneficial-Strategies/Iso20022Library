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
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat12Choice.Balance))]
    [KnownType(typeof(BalanceFormat12Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat12Choice.PartWayPeriodUnits))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat12Choice.Balance),nameof(BalanceFormat12Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat12Choice.EligibleBalance),nameof(BalanceFormat12Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat12Choice.NotEligibleBalance),nameof(BalanceFormat12Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat12Choice.FullPeriodUnits),nameof(BalanceFormat12Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat12Choice.PartWayPeriodUnits),nameof(BalanceFormat12Choice.PartWayPeriodUnits))]
    #endif
    [IsoId("_KADDNRuyEeyhRdHRjakS2w")]
    [DisplayName("Balance Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat12Choice_
    #else
    public abstract partial class BalanceFormat12Choice_
    #endif
    {
    }
}
