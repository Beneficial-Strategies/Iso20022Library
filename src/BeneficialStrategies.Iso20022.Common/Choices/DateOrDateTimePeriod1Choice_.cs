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
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod1Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod1Choice.DateTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateOrDateTimePeriod1Choice.Date),nameof(DateOrDateTimePeriod1Choice.Date))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod1Choice.DateTime),nameof(DateOrDateTimePeriod1Choice.DateTime))]
    #endif
    [IsoId("_Q8Ps0a6AEeexrtTFgmVD3Q")]
    [DisplayName("Date Or Date Time Period 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateOrDateTimePeriod1Choice_
    #else
    public abstract partial class DateOrDateTimePeriod1Choice_
    #endif
    {
    }
}
