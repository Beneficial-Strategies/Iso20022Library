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
    /// Choice between a date or a date time pattern as search selection criteria.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch3Choice.DateTimeSearch))]
    [KnownType(typeof(DateAndDateTimeSearch3Choice.DateSearch))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndDateTimeSearch3Choice.DateTimeSearch),nameof(DateAndDateTimeSearch3Choice.DateTimeSearch))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch3Choice.DateSearch),nameof(DateAndDateTimeSearch3Choice.DateSearch))]
    #endif
    [IsoId("_xs2zZ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date And Date Time Search 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndDateTimeSearch3Choice_
    #else
    public abstract partial class DateAndDateTimeSearch3Choice_
    #endif
    {
    }
}
