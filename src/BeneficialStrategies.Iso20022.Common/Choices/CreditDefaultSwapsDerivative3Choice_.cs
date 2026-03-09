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
    /// Choice structure allowing a credit default swap derivative to be defined.
    /// </summary>
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap),nameof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex),nameof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative),nameof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative),nameof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative))]
    #endif
    [IsoId("_xTXs0X5eEea2k7EBUopqxw")]
    [DisplayName("Credit Default Swaps Derivative 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditDefaultSwapsDerivative3Choice_
    #else
    public abstract partial class CreditDefaultSwapsDerivative3Choice_
    #endif
    {
    }
}
