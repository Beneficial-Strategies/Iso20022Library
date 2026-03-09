// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication that the reports subject of reconciliation do not match.
/// </summary>
[IsoId("_C44f9f_oEemm3skPVSMJQg")]
[DisplayName("Reconciliation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationResult7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationResult7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationResult7( OrganisationIdentification9Choice_ reqCounterparty1,OrganisationIdentification9Choice_ reqCounterparty2,MatchingCriteria7 reqMatchingCriteria )
    {
        Counterparty1 = reqCounterparty1;
        Counterparty2 = reqCounterparty2;
        MatchingCriteria = reqMatchingCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// First side of the contract that needs to be matched.
    /// </summary>
    [IsoId("_C9D1Uf_oEemm3skPVSMJQg")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty1")]
    #endif
    [IsoXmlTag("CtrPty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ Counterparty1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ Counterparty1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ Counterparty1 { get; init; } 
    #else
    public OrganisationIdentification9Choice_ Counterparty1 { get; set; } 
    #endif
    
    /// <summary>
    /// Second side of the contract that needs to be matched.
    /// </summary>
    [IsoId("_C9D1U__oEemm3skPVSMJQg")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty2")]
    #endif
    [IsoXmlTag("CtrPty2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ Counterparty2 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ Counterparty2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ Counterparty2 { get; init; } 
    #else
    public OrganisationIdentification9Choice_ Counterparty2 { get; set; } 
    #endif
    
    /// <summary>
    /// Criteria used to match the sides of the contract.
    /// </summary>
    [IsoId("_C9D1Vf_oEemm3skPVSMJQg")]
    [DisplayName("Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgCrit")]
    #endif
    [IsoXmlTag("MtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MatchingCriteria7 MatchingCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MatchingCriteria7 MatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingCriteria7 MatchingCriteria { get; init; } 
    #else
    public MatchingCriteria7 MatchingCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
