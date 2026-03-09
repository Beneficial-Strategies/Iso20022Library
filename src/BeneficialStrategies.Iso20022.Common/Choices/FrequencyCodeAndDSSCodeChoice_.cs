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
    /// Choice between formats for the frequency.
    /// </summary>
    [KnownType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode))]
    [KnownType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode),nameof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode))]
    [JsonDerivedType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS),nameof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS))]
    #endif
    [IsoId("_UuhioNp-Ed-ak6NoX_4Aeg_400175868")]
    [DisplayName("Frequency Code And DSS Code Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FrequencyCodeAndDSSCodeChoice_
    #else
    public abstract partial class FrequencyCodeAndDSSCodeChoice_
    #endif
    {
    }
}
