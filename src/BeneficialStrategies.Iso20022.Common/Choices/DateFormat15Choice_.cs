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
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat15Choice.Date))]
    [KnownType(typeof(DateFormat15Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat15Choice.Date),nameof(DateFormat15Choice.Date))]
    [JsonDerivedType(typeof(DateFormat15Choice.DateCode),nameof(DateFormat15Choice.DateCode))]
    #endif
    [IsoId("_QmL0QNp-Ed-ak6NoX_4Aeg_838705942")]
    [DisplayName("Date Format 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat15Choice_
    #else
    public abstract partial class DateFormat15Choice_
    #endif
    {
    }
}
