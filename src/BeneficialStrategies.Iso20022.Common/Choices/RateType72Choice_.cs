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
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType72Choice.Code))]
    [KnownType(typeof(RateType72Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType72Choice.Code),nameof(RateType72Choice.Code))]
    [JsonDerivedType(typeof(RateType72Choice.Proprietary),nameof(RateType72Choice.Proprietary))]
    #endif
    [IsoId("_skrJd83wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type 72 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType72Choice_
    #else
    public abstract partial class RateType72Choice_
    #endif
    {
    }
}
