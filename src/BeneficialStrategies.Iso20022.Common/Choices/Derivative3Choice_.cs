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
    /// Choice element to define a derivative instrument.
    /// </summary>
    [KnownType(typeof(Derivative3Choice.Commodity))]
    [KnownType(typeof(Derivative3Choice.InterestRate))]
    [KnownType(typeof(Derivative3Choice.ForeignExchange))]
    [KnownType(typeof(Derivative3Choice.Equity))]
    [KnownType(typeof(Derivative3Choice.ContractForDifference))]
    [KnownType(typeof(Derivative3Choice.Credit))]
    [KnownType(typeof(Derivative3Choice.EmissionAllowance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Derivative3Choice.Commodity),nameof(Derivative3Choice.Commodity))]
    [JsonDerivedType(typeof(Derivative3Choice.InterestRate),nameof(Derivative3Choice.InterestRate))]
    [JsonDerivedType(typeof(Derivative3Choice.ForeignExchange),nameof(Derivative3Choice.ForeignExchange))]
    [JsonDerivedType(typeof(Derivative3Choice.Equity),nameof(Derivative3Choice.Equity))]
    [JsonDerivedType(typeof(Derivative3Choice.ContractForDifference),nameof(Derivative3Choice.ContractForDifference))]
    [JsonDerivedType(typeof(Derivative3Choice.Credit),nameof(Derivative3Choice.Credit))]
    [JsonDerivedType(typeof(Derivative3Choice.EmissionAllowance),nameof(Derivative3Choice.EmissionAllowance))]
    #endif
    [IsoId("_w9mvYSe0Eei12pGEsJIAeQ")]
    [DisplayName("Derivative 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Derivative3Choice_
    #else
    public abstract partial class Derivative3Choice_
    #endif
    {
    }
}
