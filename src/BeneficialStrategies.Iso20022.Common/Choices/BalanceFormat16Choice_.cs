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
    [KnownType(typeof(BalanceFormat16Choice.Balance))]
    [KnownType(typeof(BalanceFormat16Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat16Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat16Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat16Choice.PartWayPeriodUnits))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat16Choice.Balance),nameof(BalanceFormat16Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat16Choice.EligibleBalance),nameof(BalanceFormat16Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat16Choice.NotEligibleBalance),nameof(BalanceFormat16Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat16Choice.FullPeriodUnits),nameof(BalanceFormat16Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat16Choice.PartWayPeriodUnits),nameof(BalanceFormat16Choice.PartWayPeriodUnits))]
    #endif
    [IsoId("_plN2Izi7Eeydid5dcNPKvg")]
    [DisplayName("Balance Format 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat16Choice_
    #else
    public abstract partial class BalanceFormat16Choice_
    #endif
    {
    }
}
