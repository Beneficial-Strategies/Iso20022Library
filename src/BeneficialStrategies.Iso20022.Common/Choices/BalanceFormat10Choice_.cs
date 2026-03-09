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
    [KnownType(typeof(BalanceFormat10Choice.Balance))]
    [KnownType(typeof(BalanceFormat10Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat10Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat10Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat10Choice.PartWayPeriodUnits))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat10Choice.Balance),nameof(BalanceFormat10Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat10Choice.EligibleBalance),nameof(BalanceFormat10Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat10Choice.NotEligibleBalance),nameof(BalanceFormat10Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat10Choice.FullPeriodUnits),nameof(BalanceFormat10Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat10Choice.PartWayPeriodUnits),nameof(BalanceFormat10Choice.PartWayPeriodUnits))]
    #endif
    [IsoId("_cjzu3ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat10Choice_
    #else
    public abstract partial class BalanceFormat10Choice_
    #endif
    {
    }
}
