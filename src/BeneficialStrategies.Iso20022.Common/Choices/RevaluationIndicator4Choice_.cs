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
    /// Choice of format for the revaluation.
    /// </summary>
    [KnownType(typeof(RevaluationIndicator4Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RevaluationIndicator4Choice.Indicator),nameof(RevaluationIndicator4Choice.Indicator))]
    [JsonDerivedType(typeof(RevaluationIndicator4Choice.Proprietary),nameof(RevaluationIndicator4Choice.Proprietary))]
    #endif
    [IsoId("_5mw3_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Revaluation Indicator 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RevaluationIndicator4Choice_
    #else
    public abstract partial class RevaluationIndicator4Choice_
    #endif
    {
    }
}
