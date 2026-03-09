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
    /// Choice of formats for a date or quarter.
    /// </summary>
    [KnownType(typeof(DateQuarter1Choice.Date))]
    [KnownType(typeof(DateQuarter1Choice.Period))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateQuarter1Choice.Date),nameof(DateQuarter1Choice.Date))]
    [JsonDerivedType(typeof(DateQuarter1Choice.Period),nameof(DateQuarter1Choice.Period))]
    #endif
    [IsoId("_CUTHIKFTEei_VZq-6SQkuQ")]
    [DisplayName("Date Quarter 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateQuarter1Choice_
    #else
    public abstract partial class DateQuarter1Choice_
    #endif
    {
    }
}
