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
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency21Choice.Type))]
    [KnownType(typeof(Frequency21Choice.Period))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency21Choice.Type),nameof(Frequency21Choice.Type))]
    [JsonDerivedType(typeof(Frequency21Choice.Period),nameof(Frequency21Choice.Period))]
    #endif
    [IsoId("_51BdAR7yEeSxevWRRWxNAg")]
    [DisplayName("Frequency 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency21Choice_
    #else
    public abstract partial class Frequency21Choice_
    #endif
    {
    }
}
