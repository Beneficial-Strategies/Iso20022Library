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
    /// Choice between a date time period or blank elements.
    /// </summary>
    [KnownType(typeof(DateTimeOrBlankQuery1Choice.Range))]
    [KnownType(typeof(DateTimeOrBlankQuery1Choice.NotReported))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateTimeOrBlankQuery1Choice.Range),nameof(DateTimeOrBlankQuery1Choice.Range))]
    [JsonDerivedType(typeof(DateTimeOrBlankQuery1Choice.NotReported),nameof(DateTimeOrBlankQuery1Choice.NotReported))]
    #endif
    [IsoId("_HY688WE4Ee2S65ml6YCOtA")]
    [DisplayName("Date Time Or Blank Query 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateTimeOrBlankQuery1Choice_
    #else
    public abstract partial class DateTimeOrBlankQuery1Choice_
    #endif
    {
    }
}
