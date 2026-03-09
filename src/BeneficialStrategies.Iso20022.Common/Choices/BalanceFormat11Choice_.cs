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
    [KnownType(typeof(BalanceFormat11Choice.Balance))]
    [KnownType(typeof(BalanceFormat11Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat11Choice.NotEligibleBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat11Choice.Balance),nameof(BalanceFormat11Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat11Choice.EligibleBalance),nameof(BalanceFormat11Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat11Choice.NotEligibleBalance),nameof(BalanceFormat11Choice.NotEligibleBalance))]
    #endif
    [IsoId("_JBUKmxuyEeyhRdHRjakS2w")]
    [DisplayName("Balance Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat11Choice_
    #else
    public abstract partial class BalanceFormat11Choice_
    #endif
    {
    }
}
