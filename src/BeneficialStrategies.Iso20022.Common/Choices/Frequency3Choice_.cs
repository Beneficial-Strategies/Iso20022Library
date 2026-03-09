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
    [KnownType(typeof(Frequency3Choice.Code))]
    [KnownType(typeof(Frequency3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency3Choice.Code),nameof(Frequency3Choice.Code))]
    [JsonDerivedType(typeof(Frequency3Choice.Proprietary),nameof(Frequency3Choice.Proprietary))]
    #endif
    [IsoId("_QvHt09p-Ed-ak6NoX_4Aeg_-1581052955")]
    [DisplayName("Frequency 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency3Choice_
    #else
    public abstract partial class Frequency3Choice_
    #endif
    {
    }
}
