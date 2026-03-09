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
    /// Choice of rate formats.
    /// </summary>
    [KnownType(typeof(AmountAndRateFormat3Choice.Amount))]
    [KnownType(typeof(AmountAndRateFormat3Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountAndRateFormat3Choice.Amount),nameof(AmountAndRateFormat3Choice.Amount))]
    [JsonDerivedType(typeof(AmountAndRateFormat3Choice.NotSpecifiedRate),nameof(AmountAndRateFormat3Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UIFNs9p-Ed-ak6NoX_4Aeg_635648648")]
    [DisplayName("Amount And Rate Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountAndRateFormat3Choice_
    #else
    public abstract partial class AmountAndRateFormat3Choice_
    #endif
    {
    }
}
