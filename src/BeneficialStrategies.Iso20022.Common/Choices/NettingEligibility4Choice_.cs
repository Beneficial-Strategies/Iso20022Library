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
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility4Choice.Indicator))]
    [KnownType(typeof(NettingEligibility4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NettingEligibility4Choice.Indicator),nameof(NettingEligibility4Choice.Indicator))]
    [JsonDerivedType(typeof(NettingEligibility4Choice.Proprietary),nameof(NettingEligibility4Choice.Proprietary))]
    #endif
    [IsoId("_0h_JkTqIEeWVrPy0StzzSg")]
    [DisplayName("Netting Eligibility 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NettingEligibility4Choice_
    #else
    public abstract partial class NettingEligibility4Choice_
    #endif
    {
    }
}
