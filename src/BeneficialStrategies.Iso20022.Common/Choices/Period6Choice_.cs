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
    /// Choice between a period or a period code.
    /// </summary>
    [KnownType(typeof(Period6Choice.Period))]
    [KnownType(typeof(Period6Choice.PeriodCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period6Choice.Period),nameof(Period6Choice.Period))]
    [JsonDerivedType(typeof(Period6Choice.PeriodCode),nameof(Period6Choice.PeriodCode))]
    #endif
    [IsoId("_jZvEW7QYEeeKRKrD60ELBQ")]
    [DisplayName("Period 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period6Choice_
    #else
    public abstract partial class Period6Choice_
    #endif
    {
    }
}
