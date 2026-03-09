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
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period2Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period2Choice.FromDateToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period2Choice.FromDateTimeToDateTime),nameof(Period2Choice.FromDateTimeToDateTime))]
    [JsonDerivedType(typeof(Period2Choice.FromDateToDate),nameof(Period2Choice.FromDateToDate))]
    #endif
    [IsoId("_T5exEdp-Ed-ak6NoX_4Aeg_913439020")]
    [DisplayName("Period 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period2Choice_
    #else
    public abstract partial class Period2Choice_
    #endif
    {
    }
}
