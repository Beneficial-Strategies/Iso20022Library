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
    [KnownType(typeof(NonEligibleProceedsIndicator3Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator3Choice.Code),nameof(NonEligibleProceedsIndicator3Choice.Code))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator3Choice.Proprietary),nameof(NonEligibleProceedsIndicator3Choice.Proprietary))]
    #endif
    [IsoId("_MvA2sUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Non Eligible Proceeds Indicator 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NonEligibleProceedsIndicator3Choice_
    #else
    public abstract partial class NonEligibleProceedsIndicator3Choice_
    #endif
    {
    }
}
