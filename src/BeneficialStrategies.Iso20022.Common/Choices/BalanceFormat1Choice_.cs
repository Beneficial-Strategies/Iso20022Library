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
    [KnownType(typeof(BalanceFormat1Choice.Balance))]
    [KnownType(typeof(BalanceFormat1Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat1Choice.NotEligibleBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat1Choice.Balance),nameof(BalanceFormat1Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat1Choice.EligibleBalance),nameof(BalanceFormat1Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat1Choice.NotEligibleBalance),nameof(BalanceFormat1Choice.NotEligibleBalance))]
    #endif
    [IsoId("_Q0of-tp-Ed-ak6NoX_4Aeg_86295556")]
    [DisplayName("Balance Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat1Choice_
    #else
    public abstract partial class BalanceFormat1Choice_
    #endif
    {
    }
}
