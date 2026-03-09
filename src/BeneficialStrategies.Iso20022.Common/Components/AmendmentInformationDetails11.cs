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
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_sm5qyWk2Eeanu6HLe77Rkg")]
[DisplayName("Amendment Information Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentInformationDetails11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_svFWUWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndtId")]
    #endif
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMandateIdentification { get; init; } 
    #else
    public System.String? OriginalMandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_svFWU2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrSchmeId")]
    #endif
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_svFWVWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrAgt")]
    #endif
    [IsoXmlTag("OrgnlCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWV2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrAgtAcct")]
    #endif
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    #else
    public CashAccount24? OriginalCreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_svFWWWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtr")]
    #endif
    [IsoXmlTag("OrgnlDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #else
    public PartyIdentification43? OriginalDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_svFWW2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAcct")]
    #endif
    [IsoXmlTag("OrgnlDbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #else
    public CashAccount24? OriginalDebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_svFWXWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAgt")]
    #endif
    [IsoXmlTag("OrgnlDbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWX2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAgtAcct")]
    #endif
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    #else
    public CashAccount24? OriginalDebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_svFWYWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Final Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlFnlColltnDt")]
    #endif
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalFinalCollectionDate { get; init; } 
    #else
    public System.DateOnly? OriginalFinalCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_svFWY2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlFrqcy")]
    #endif
    [IsoXmlTag("OrgnlFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency36Choice_? OriginalFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency36Choice_? OriginalFrequency { get; init; } 
    #else
    public Frequency36Choice_? OriginalFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_svFWZWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRsn")]
    #endif
    [IsoXmlTag("OrgnlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 
    #else
    public MandateSetupReason1Choice_? OriginalReason { get; set; } 
    #endif
    
    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_oldnwWn1EearR-CA7eRZXQ")]
    [DisplayName("Original Tracking Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTrckgDays")]
    #endif
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2NumericText? OriginalTrackingDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalTrackingDays { get; init; } 
    #else
    public System.String? OriginalTrackingDays { get; set; } 
    #endif
    
    
    #nullable disable
    
}
