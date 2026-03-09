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
    /// Choice between a standard code or proprietary code to specify the eligibility of outturn resources.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator1Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator1Choice.Code),nameof(NonEligibleProceedsIndicator1Choice.Code))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator1Choice.Proprietary),nameof(NonEligibleProceedsIndicator1Choice.Proprietary))]
    #endif
    [IsoId("_Q5GwR9p-Ed-ak6NoX_4Aeg_-1230859873")]
    [DisplayName("Non Eligible Proceeds Indicator 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NonEligibleProceedsIndicator1Choice_
    #else
    public abstract partial class NonEligibleProceedsIndicator1Choice_
    #endif
    {
    }
}
