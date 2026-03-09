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
    /// Choice between a date or a date and time format.
    /// </summary>
    [KnownType(typeof(DateAndDateTime2Choice.Date))]
    [KnownType(typeof(DateAndDateTime2Choice.DateTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndDateTime2Choice.Date),nameof(DateAndDateTime2Choice.Date))]
    [JsonDerivedType(typeof(DateAndDateTime2Choice.DateTime),nameof(DateAndDateTime2Choice.DateTime))]
    #endif
    [IsoId("_fGuzgZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Date And Date Time 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndDateTime2Choice_
    #else
    public abstract partial class DateAndDateTime2Choice_
    #endif
    {
    }
}
