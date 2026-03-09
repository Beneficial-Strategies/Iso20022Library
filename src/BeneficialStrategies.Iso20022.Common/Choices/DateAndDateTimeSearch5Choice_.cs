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
    /// Choice between a date or a date and time format.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch5Choice.Date))]
    [KnownType(typeof(DateAndDateTimeSearch5Choice.DateTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndDateTimeSearch5Choice.Date),nameof(DateAndDateTimeSearch5Choice.Date))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch5Choice.DateTime),nameof(DateAndDateTimeSearch5Choice.DateTime))]
    #endif
    [IsoId("_Ve-bjTp9EemwKdP955WBJQ")]
    [DisplayName("Date And Date Time Search 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndDateTimeSearch5Choice_
    #else
    public abstract partial class DateAndDateTimeSearch5Choice_
    #endif
    {
    }
}
