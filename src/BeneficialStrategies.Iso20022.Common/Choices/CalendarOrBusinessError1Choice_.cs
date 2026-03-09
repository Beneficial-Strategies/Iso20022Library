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
    /// Choice between the audit trail or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(CalendarOrBusinessError1Choice.CalendarData))]
    [KnownType(typeof(CalendarOrBusinessError1Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CalendarOrBusinessError1Choice.CalendarData),nameof(CalendarOrBusinessError1Choice.CalendarData))]
    [JsonDerivedType(typeof(CalendarOrBusinessError1Choice.BusinessError),nameof(CalendarOrBusinessError1Choice.BusinessError))]
    #endif
    [IsoId("_dVcQ2Im7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Or Business Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CalendarOrBusinessError1Choice_
    #else
    public abstract partial class CalendarOrBusinessError1Choice_
    #endif
    {
    }
}
