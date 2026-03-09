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
    [KnownType(typeof(DateCode11Choice.Code))]
    [KnownType(typeof(DateCode11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateCode11Choice.Code),nameof(DateCode11Choice.Code))]
    [JsonDerivedType(typeof(DateCode11Choice.Proprietary),nameof(DateCode11Choice.Proprietary))]
    #endif
    [IsoId("_lHtQUfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Code 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode11Choice_
    #else
    public abstract partial class DateCode11Choice_
    #endif
    {
    }
}
