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
    [KnownType(typeof(RevaluationIndicator1Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RevaluationIndicator1Choice.Indicator),nameof(RevaluationIndicator1Choice.Indicator))]
    [JsonDerivedType(typeof(RevaluationIndicator1Choice.Proprietary),nameof(RevaluationIndicator1Choice.Proprietary))]
    #endif
    [IsoId("_Quh38dp-Ed-ak6NoX_4Aeg_1541845195")]
    [DisplayName("Revaluation Indicator 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RevaluationIndicator1Choice_
    #else
    public abstract partial class RevaluationIndicator1Choice_
    #endif
    {
    }
}
