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
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod1Choice.StatementDate))]
    [KnownType(typeof(DateAndPeriod1Choice.StatementPeriod))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndPeriod1Choice.StatementDate),nameof(DateAndPeriod1Choice.StatementDate))]
    [JsonDerivedType(typeof(DateAndPeriod1Choice.StatementPeriod),nameof(DateAndPeriod1Choice.StatementPeriod))]
    #endif
    [IsoId("_Qqpdidp-Ed-ak6NoX_4Aeg_-2134500203")]
    [DisplayName("Date And Period 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndPeriod1Choice_
    #else
    public abstract partial class DateAndPeriod1Choice_
    #endif
    {
    }
}
