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
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat21Choice.Date))]
    [KnownType(typeof(DateFormat21Choice.NotSpecifiedDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat21Choice.Date),nameof(DateFormat21Choice.Date))]
    [JsonDerivedType(typeof(DateFormat21Choice.NotSpecifiedDate),nameof(DateFormat21Choice.NotSpecifiedDate))]
    #endif
    [IsoId("_5PdBsfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat21Choice_
    #else
    public abstract partial class DateFormat21Choice_
    #endif
    {
    }
}
