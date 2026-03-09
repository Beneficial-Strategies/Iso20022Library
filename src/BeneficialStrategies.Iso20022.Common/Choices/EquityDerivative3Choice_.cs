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
    /// Element to define an equity instrument underlying code types.
    /// </summary>
    [KnownType(typeof(EquityDerivative3Choice.Basket))]
    [KnownType(typeof(EquityDerivative3Choice.Index))]
    [KnownType(typeof(EquityDerivative3Choice.SingleName))]
    [KnownType(typeof(EquityDerivative3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EquityDerivative3Choice.Basket),nameof(EquityDerivative3Choice.Basket))]
    [JsonDerivedType(typeof(EquityDerivative3Choice.Index),nameof(EquityDerivative3Choice.Index))]
    [JsonDerivedType(typeof(EquityDerivative3Choice.SingleName),nameof(EquityDerivative3Choice.SingleName))]
    [JsonDerivedType(typeof(EquityDerivative3Choice.Other),nameof(EquityDerivative3Choice.Other))]
    #endif
    [IsoId("_hW-FN2lPEeaLAKoEUNsD9g")]
    [DisplayName("Equity Derivative 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EquityDerivative3Choice_
    #else
    public abstract partial class EquityDerivative3Choice_
    #endif
    {
    }
}
