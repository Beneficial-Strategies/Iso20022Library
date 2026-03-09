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
    /// Choice between the formats to express a date.
    /// </summary>
    [KnownType(typeof(DateFormat3Choice.Date))]
    [KnownType(typeof(DateFormat3Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat3Choice.Date),nameof(DateFormat3Choice.Date))]
    [JsonDerivedType(typeof(DateFormat3Choice.DateCode),nameof(DateFormat3Choice.DateCode))]
    #endif
    [IsoId("_RVkCydp-Ed-ak6NoX_4Aeg_1324481717")]
    [DisplayName("Date Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat3Choice_
    #else
    public abstract partial class DateFormat3Choice_
    #endif
    {
    }
}
