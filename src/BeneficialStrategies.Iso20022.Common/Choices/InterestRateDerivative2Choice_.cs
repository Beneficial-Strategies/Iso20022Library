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
    /// Choice element specifying the underlying types of an interest rate derivative.
    /// </summary>
    [KnownType(typeof(InterestRateDerivative2Choice.SwapRelated))]
    [KnownType(typeof(InterestRateDerivative2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRateDerivative2Choice.SwapRelated),nameof(InterestRateDerivative2Choice.SwapRelated))]
    [JsonDerivedType(typeof(InterestRateDerivative2Choice.Other),nameof(InterestRateDerivative2Choice.Other))]
    #endif
    [IsoId("_xSfx_WlIEeaLAKoEUNsD9g")]
    [DisplayName("Interest Rate Derivative 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateDerivative2Choice_
    #else
    public abstract partial class InterestRateDerivative2Choice_
    #endif
    {
    }
}
