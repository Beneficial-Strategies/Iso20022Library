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
    [KnownType(typeof(DateFormat1Choice.Date))]
    [KnownType(typeof(DateFormat1Choice.Code))]
    [KnownType(typeof(DateFormat1Choice.DateTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat1Choice.Date),nameof(DateFormat1Choice.Date))]
    [JsonDerivedType(typeof(DateFormat1Choice.Code),nameof(DateFormat1Choice.Code))]
    [JsonDerivedType(typeof(DateFormat1Choice.DateTime),nameof(DateFormat1Choice.DateTime))]
    #endif
    [IsoId("_RE37ZNp-Ed-ak6NoX_4Aeg_-1132412760")]
    [DisplayName("Date Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat1Choice_
    #else
    public abstract partial class DateFormat1Choice_
    #endif
    {
    }
}
