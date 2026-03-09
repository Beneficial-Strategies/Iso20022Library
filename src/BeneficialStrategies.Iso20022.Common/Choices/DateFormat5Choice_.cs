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
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat5Choice.Date))]
    [KnownType(typeof(DateFormat5Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat5Choice.Date),nameof(DateFormat5Choice.Date))]
    [JsonDerivedType(typeof(DateFormat5Choice.DateCode),nameof(DateFormat5Choice.DateCode))]
    #endif
    [IsoId("_Qy_hN9p-Ed-ak6NoX_4Aeg_407445243")]
    [DisplayName("Date Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat5Choice_
    #else
    public abstract partial class DateFormat5Choice_
    #endif
    {
    }
}
