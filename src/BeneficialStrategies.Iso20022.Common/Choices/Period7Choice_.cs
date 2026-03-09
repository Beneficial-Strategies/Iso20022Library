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
    [KnownType(typeof(Period7Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period7Choice.FromDateToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period7Choice.FromDateTimeToDateTime),nameof(Period7Choice.FromDateTimeToDateTime))]
    [JsonDerivedType(typeof(Period7Choice.FromDateToDate),nameof(Period7Choice.FromDateToDate))]
    #endif
    [IsoId("_VEuSoTwGEemGDJYTly2NCA")]
    [DisplayName("Period 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period7Choice_
    #else
    public abstract partial class Period7Choice_
    #endif
    {
    }
}
