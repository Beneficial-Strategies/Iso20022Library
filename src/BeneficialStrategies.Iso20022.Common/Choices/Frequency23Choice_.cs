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
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency23Choice.Code))]
    [KnownType(typeof(Frequency23Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency23Choice.Code),nameof(Frequency23Choice.Code))]
    [JsonDerivedType(typeof(Frequency23Choice.Proprietary),nameof(Frequency23Choice.Proprietary))]
    #endif
    [IsoId("_XpKWcTm_EeWV5sr121Fc8A")]
    [DisplayName("Frequency 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency23Choice_
    #else
    public abstract partial class Frequency23Choice_
    #endif
    {
    }
}
