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
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap),nameof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex),nameof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative),nameof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative),nameof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative))]
    #endif
    [IsoId("_xH_acSe0Eei12pGEsJIAeQ")]
    [DisplayName("Credit Default Swaps Derivative 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditDefaultSwapsDerivative4Choice_
    #else
    public abstract partial class CreditDefaultSwapsDerivative4Choice_
    #endif
    {
    }
}
