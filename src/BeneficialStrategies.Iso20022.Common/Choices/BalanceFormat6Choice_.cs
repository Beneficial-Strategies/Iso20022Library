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
    [KnownType(typeof(BalanceFormat6Choice.Balance))]
    [KnownType(typeof(BalanceFormat6Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat6Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat6Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat6Choice.PartWayPeriodUnits))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat6Choice.Balance),nameof(BalanceFormat6Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.EligibleBalance),nameof(BalanceFormat6Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.NotEligibleBalance),nameof(BalanceFormat6Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.FullPeriodUnits),nameof(BalanceFormat6Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.PartWayPeriodUnits),nameof(BalanceFormat6Choice.PartWayPeriodUnits))]
    #endif
    [IsoId("_k7YK1zq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat6Choice_
    #else
    public abstract partial class BalanceFormat6Choice_
    #endif
    {
    }
}
