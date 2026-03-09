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
    /// Choice between the formats to express a date and time.
    /// </summary>
    [KnownType(typeof(DateFormat2Choice.Date))]
    [KnownType(typeof(DateFormat2Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat2Choice.Date),nameof(DateFormat2Choice.Date))]
    [JsonDerivedType(typeof(DateFormat2Choice.DateCode),nameof(DateFormat2Choice.DateCode))]
    #endif
    [IsoId("_RVH96Np-Ed-ak6NoX_4Aeg_1196051260")]
    [DisplayName("Date Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat2Choice_
    #else
    public abstract partial class DateFormat2Choice_
    #endif
    {
    }
}
