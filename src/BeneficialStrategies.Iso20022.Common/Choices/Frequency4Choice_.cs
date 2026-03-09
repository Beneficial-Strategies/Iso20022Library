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
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency4Choice.Code))]
    [KnownType(typeof(Frequency4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency4Choice.Code),nameof(Frequency4Choice.Code))]
    [JsonDerivedType(typeof(Frequency4Choice.Proprietary),nameof(Frequency4Choice.Proprietary))]
    #endif
    [IsoId("_QxXJitp-Ed-ak6NoX_4Aeg_-163463652")]
    [DisplayName("Frequency 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency4Choice_
    #else
    public abstract partial class Frequency4Choice_
    #endif
    {
    }
}
