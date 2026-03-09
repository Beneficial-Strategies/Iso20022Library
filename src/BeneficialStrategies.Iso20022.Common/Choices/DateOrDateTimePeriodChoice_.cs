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
    [KnownType(typeof(DateOrDateTimePeriodChoice.Date))]
    [KnownType(typeof(DateOrDateTimePeriodChoice.DateTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateOrDateTimePeriodChoice.Date),nameof(DateOrDateTimePeriodChoice.Date))]
    [JsonDerivedType(typeof(DateOrDateTimePeriodChoice.DateTime),nameof(DateOrDateTimePeriodChoice.DateTime))]
    #endif
    [IsoId("_T6Em7Np-Ed-ak6NoX_4Aeg_1481614183")]
    [DisplayName("Date Or Date Time Period Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateOrDateTimePeriodChoice_
    #else
    public abstract partial class DateOrDateTimePeriodChoice_
    #endif
    {
    }
}
