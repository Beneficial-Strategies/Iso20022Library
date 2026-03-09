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
    [KnownType(typeof(CentralCounterPartyEligibility1Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CentralCounterPartyEligibility1Choice.Indicator),nameof(CentralCounterPartyEligibility1Choice.Indicator))]
    [JsonDerivedType(typeof(CentralCounterPartyEligibility1Choice.Proprietary),nameof(CentralCounterPartyEligibility1Choice.Proprietary))]
    #endif
    [IsoId("_Qvaox9p-Ed-ak6NoX_4Aeg_22450085")]
    [DisplayName("Central Counter Party Eligibility 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CentralCounterPartyEligibility1Choice_
    #else
    public abstract partial class CentralCounterPartyEligibility1Choice_
    #endif
    {
    }
}
