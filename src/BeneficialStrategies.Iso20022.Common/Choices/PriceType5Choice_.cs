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
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType5Choice.Market))]
    [KnownType(typeof(PriceType5Choice.Indicative))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceType5Choice.Market),nameof(PriceType5Choice.Market))]
    [JsonDerivedType(typeof(PriceType5Choice.Indicative),nameof(PriceType5Choice.Indicative))]
    #endif
    [IsoId("_SKL8C83yEee5nJBZsW8MFQ")]
    [DisplayName("Price Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceType5Choice_
    #else
    public abstract partial class PriceType5Choice_
    #endif
    {
    }
}
