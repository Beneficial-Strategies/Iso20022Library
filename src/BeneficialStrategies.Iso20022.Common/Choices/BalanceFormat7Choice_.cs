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
    [KnownType(typeof(BalanceFormat7Choice.Balance))]
    [KnownType(typeof(BalanceFormat7Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat7Choice.NotEligibleBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceFormat7Choice.Balance),nameof(BalanceFormat7Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat7Choice.EligibleBalance),nameof(BalanceFormat7Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat7Choice.NotEligibleBalance),nameof(BalanceFormat7Choice.NotEligibleBalance))]
    #endif
    [IsoId("_cfsErZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat7Choice_
    #else
    public abstract partial class BalanceFormat7Choice_
    #endif
    {
    }
}
