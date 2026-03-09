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
    [KnownType(typeof(Period3Choice.Period))]
    [KnownType(typeof(Period3Choice.PeriodCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period3Choice.Period),nameof(Period3Choice.Period))]
    [JsonDerivedType(typeof(Period3Choice.PeriodCode),nameof(Period3Choice.PeriodCode))]
    #endif
    [IsoId("_Nt3jceENEd-qUMZtd_eZuQ")]
    [DisplayName("Period 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period3Choice_
    #else
    public abstract partial class Period3Choice_
    #endif
    {
    }
}
