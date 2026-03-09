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
    [KnownType(typeof(DateCode21Choice.Code))]
    [KnownType(typeof(DateCode21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateCode21Choice.Code),nameof(DateCode21Choice.Code))]
    [JsonDerivedType(typeof(DateCode21Choice.Proprietary),nameof(DateCode21Choice.Proprietary))]
    #endif
    [IsoId("_btDb-0ENEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode21Choice_
    #else
    public abstract partial class DateCode21Choice_
    #endif
    {
    }
}
