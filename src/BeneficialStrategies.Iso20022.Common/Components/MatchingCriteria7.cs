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
/// Provides details on loan and collateral matching criteria.
/// </summary>
[IsoId("_C9D1V__oEemm3skPVSMJQg")]
[DisplayName("Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MatchingCriteria7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_DA7osf_oEemm3skPVSMJQg")]
    [DisplayName("Counterparty Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyMtchgCrit")]
    #endif
    [IsoXmlTag("CtrPtyMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyMatchingCriteria1? CounterpartyMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyMatchingCriteria1? CounterpartyMatchingCriteria { get; init; } 
    #else
    public CounterpartyMatchingCriteria1? CounterpartyMatchingCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_DA7os__oEemm3skPVSMJQg")]
    [DisplayName("Loan Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnMtchgCrit")]
    #endif
    [IsoXmlTag("LnMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoanMatchingCriteria6? LoanMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoanMatchingCriteria6? LoanMatchingCriteria { get; init; } 
    #else
    public LoanMatchingCriteria6? LoanMatchingCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Compares information related to both sides of a collateral.
    /// </summary>
    [IsoId("_DA7otf_oEemm3skPVSMJQg")]
    [DisplayName("Collateral Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMtchgCrit")]
    #endif
    [IsoXmlTag("CollMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralMatchingCriteria3? CollateralMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMatchingCriteria3? CollateralMatchingCriteria { get; init; } 
    #else
    public CollateralMatchingCriteria3? CollateralMatchingCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
