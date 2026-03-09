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
    /// Choice of format for the CCP eligibility information.
    /// </summary>
    [KnownType(typeof(CentralCounterPartyEligibility5Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CentralCounterPartyEligibility5Choice.Indicator),nameof(CentralCounterPartyEligibility5Choice.Indicator))]
    [JsonDerivedType(typeof(CentralCounterPartyEligibility5Choice.Proprietary),nameof(CentralCounterPartyEligibility5Choice.Proprietary))]
    #endif
    [IsoId("_5m6oM5NLEeWGlc8L7oPDIg")]
    [DisplayName("Central Counter Party Eligibility 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CentralCounterPartyEligibility5Choice_
    #else
    public abstract partial class CentralCounterPartyEligibility5Choice_
    #endif
    {
    }
}
