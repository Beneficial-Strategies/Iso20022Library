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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat6Choice.Rate))]
    [KnownType(typeof(RateFormat6Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat6Choice.Rate),nameof(RateFormat6Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat6Choice.NotSpecifiedRate),nameof(RateFormat6Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_PO4fIOwOEd-sn-FiNtktcA")]
    [DisplayName("Rate Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat6Choice_
    #else
    public abstract partial class RateFormat6Choice_
    #endif
    {
    }
}
