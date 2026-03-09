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
/// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be honoured on the presentation of documents that comply with its terms and conditions.
/// </summary>
[IsoId("_916yAnltEeG7BsjMvd1mEw_562975782")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Undertaking name.
    /// </summary>
    [IsoId("_8Skgo4LIEeGwNp5ZjMErfw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingName1Code? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingName1Code? Name { get; init; } 
    #else
    public UndertakingName1Code? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Party in whose favour the counter-undertaking is issued.
    /// </summary>
    [IsoId("_916yA3ltEeG7BsjMvd1mEw_1423077489")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Beneficiary { get; init; } 
    #else
    public PartyIdentification43? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the expiry terms of the counter-undertaking.
    /// </summary>
    [IsoId("_nltCUhR7EeKyNbjzgBLUcA")]
    [DisplayName("Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtls")]
    #endif
    [IsoXmlTag("XpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryDetails2? ExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails2? ExpiryDetails { get; init; } 
    #else
    public ExpiryDetails2? ExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the amount of the counter-undertaking.
    /// </summary>
    [IsoId("_916yBXltEeG7BsjMvd1mEw_-1180399069")]
    [DisplayName("Counter Undertaking Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrUdrtkgAmt")]
    #endif
    [IsoXmlTag("CntrUdrtkgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingAmount1? CounterUndertakingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount1? CounterUndertakingAmount { get; init; } 
    #else
    public UndertakingAmount1? CounterUndertakingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_92D78HltEeG7BsjMvd1mEw_1953031282")]
    [DisplayName("Confirmation Charges Payable By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfChrgsPyblBy")]
    #endif
    [IsoXmlTag("ConfChrgsPyblBy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    #else
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; set; } 
    #endif
    
    /// <summary>
    /// Rules and laws governing the counter-undertaking.
    /// </summary>
    [IsoId("_92D78XltEeG7BsjMvd1mEw_-138238292")]
    [DisplayName("Governance Rules And Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovncRulesAndLaw")]
    #endif
    [IsoXmlTag("GovncRulesAndLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GovernanceRules1? GovernanceRulesAndLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceRules1? GovernanceRulesAndLaw { get; init; } 
    #else
    public GovernanceRules1? GovernanceRulesAndLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Indication as to whether a claim is to utilise a standard claim form of the issuing institution.
    /// </summary>
    [IsoId("_92D78nltEeG7BsjMvd1mEw_816197846")]
    [DisplayName("Standard Claim Document Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdClmDocInd")]
    #endif
    [IsoXmlTag("StdClmDocInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StandardClaimDocumentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandardClaimDocumentIndicator { get; init; } 
    #else
    public System.String? StandardClaimDocumentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the counter-undertaking.
    /// </summary>
    [IsoId("_92D783ltEeG7BsjMvd1mEw_1702800733")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
