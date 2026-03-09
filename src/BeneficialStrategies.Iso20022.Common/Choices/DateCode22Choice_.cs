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
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode22Choice.Code))]
    [KnownType(typeof(DateCode22Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateCode22Choice.Code),nameof(DateCode22Choice.Code))]
    [JsonDerivedType(typeof(DateCode22Choice.Proprietary),nameof(DateCode22Choice.Proprietary))]
    #endif
    [IsoId("_cdSQd5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode22Choice_
    #else
    public abstract partial class DateCode22Choice_
    #endif
    {
    }
}
