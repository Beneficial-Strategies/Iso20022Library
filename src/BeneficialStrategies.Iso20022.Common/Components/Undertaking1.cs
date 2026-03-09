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
[IsoId("_9ziMYXltEeG7BsjMvd1mEw_-2112761130")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Undertaking1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Undertaking1( System.String reqApplicantReferenceNumber,System.String reqPurpose,UndertakingName1Code reqName,UndertakingType1Choice_ reqType,PartyIdentification43 reqObligor,PartyIdentification43 reqIssuer,System.String reqCounterUndertakingIndicator,UndertakingAmount1 reqUndertakingAmount,ExpiryDetails2 reqExpiryDetails,GovernanceRules1 reqGovernanceRulesAndLaw,UndertakingWording1 reqUndertakingWording,CommunicationChannel1 reqDeliveryChannel )
    {
        ApplicantReferenceNumber = reqApplicantReferenceNumber;
        Purpose = reqPurpose;
        Name = reqName;
        Type = reqType;
        Obligor = reqObligor;
        Issuer = reqIssuer;
        CounterUndertakingIndicator = reqCounterUndertakingIndicator;
        UndertakingAmount = reqUndertakingAmount;
        ExpiryDetails = reqExpiryDetails;
        GovernanceRulesAndLaw = reqGovernanceRulesAndLaw;
        UndertakingWording = reqUndertakingWording;
        DeliveryChannel = reqDeliveryChannel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_9ziMYnltEeG7BsjMvd1mEw_460465579")]
    [DisplayName("Applicant Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplcntRefNb")]
    #endif
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ApplicantReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ApplicantReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ApplicantReferenceNumber { get; init; } 
    #else
    public System.String ApplicantReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Brief description of the purpose of the undertaking. Provided as information for the issuer reference.
    /// </summary>
    [IsoId("_9ziMY3ltEeG7BsjMvd1mEw_1517489578")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Purpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Purpose { get; init; } 
    #else
    public System.String Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Undertaking name.
    /// </summary>
    [IsoId("_bk57JYLJEeGwNp5ZjMErfw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingName1Code Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingName1Code Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingName1Code Name { get; init; } 
    #else
    public UndertakingName1Code Name { get; set; } 
    #endif
    
    /// <summary>
    /// Type of undertaking, for example, performance, payment.
    /// </summary>
    [IsoId("_9zrWUHltEeG7BsjMvd1mEw_-10772614")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingType1Choice_ Type { get; init; } 
    #else
    public UndertakingType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// </summary>
    [IsoId("_9zrWUXltEeG7BsjMvd1mEw_1174661624")]
    [DisplayName("Obligor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgr")]
    #endif
    [IsoXmlTag("Oblgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Obligor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Obligor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Obligor { get; init; } 
    #else
    public PartyIdentification43 Obligor { get; set; } 
    #endif
    
    /// <summary>
    /// Party to be named in the undertaking as the “applicant” when different from the obligor.
    /// </summary>
    [IsoId("_9zrWUnltEeG7BsjMvd1mEw_-679982016")]
    [DisplayName("Applicant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Applcnt")]
    #endif
    [IsoXmlTag("Applcnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Applicant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Applicant { get; init; } 
    #else
    public PartyIdentification43? Applicant { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// </summary>
    [IsoId("_vdjc0310EeGlwNeVP9egyg")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Issuer { get; init; } 
    #else
    public PartyIdentification43 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party in whose favour the undertaking is to be issued.
    /// </summary>
    [IsoId("_9zrWU3ltEeG7BsjMvd1mEw_-33006693")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9zrWU3ltEeG7BsjMvd1mEw_-33006693
    
    /// <summary>
    /// Party asked to advise the undertaking to the beneficiary or to another advising party.
    /// </summary>
    [IsoId("_9zrWVHltEeG7BsjMvd1mEw_2007270322")]
    [DisplayName("Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPty")]
    #endif
    [IsoXmlTag("AdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? AdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? AdvisingParty { get; init; } 
    #else
    public PartyIdentification43? AdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional party asked to advise the undertaking.
    /// </summary>
    [IsoId("_9z1HUHltEeG7BsjMvd1mEw_224779758")]
    [DisplayName("Second Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndAdvsgPty")]
    #endif
    [IsoXmlTag("ScndAdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #else
    public PartyIdentification43? SecondAdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that adds its confirmation to the undertaking. For further clarification, reference the applicable rules to which the undertaking is subject.
    /// </summary>
    [IsoId("_9z1HUXltEeG7BsjMvd1mEw_-1332939117")]
    [DisplayName("Confirmer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnfrmr")]
    #endif
    [IsoXmlTag("Cnfrmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Confirmer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Confirmer { get; init; } 
    #else
    public PartyIdentification43? Confirmer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the advising bank (confirmer) is requested to add its confirmation to the undertaking. The absence of this element indicates that the advising bank (confirmer) is not requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_9z1HUnltEeG7BsjMvd1mEw_1175132881")]
    [DisplayName("Confirmation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfInd")]
    #endif
    [IsoXmlTag("ConfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmationIndicator { get; init; } 
    #else
    public System.String? ConfirmationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the undertaking is a local or ancillary undertaking to be issued under a counter-undertaking.
    /// </summary>
    [IsoId("_9z1HU3ltEeG7BsjMvd1mEw_1727440495")]
    [DisplayName("Counter Undertaking Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrUdrtkgInd")]
    #endif
    [IsoXmlTag("CntrUdrtkgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CounterUndertakingIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CounterUndertakingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CounterUndertakingIndicator { get; init; } 
    #else
    public System.String CounterUndertakingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the counter undertaking.
    /// </summary>
    [IsoId("_9z1HVHltEeG7BsjMvd1mEw_617505551")]
    [DisplayName("Counter Undertaking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrUdrtkg")]
    #endif
    [IsoXmlTag("CntrUdrtkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Undertaking2? CounterUndertaking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking2? CounterUndertaking { get; init; } 
    #else
    public Undertaking2? CounterUndertaking { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the amount of the undertaking.
    /// </summary>
    [IsoId("_9z-4UHltEeG7BsjMvd1mEw_-434744147")]
    [DisplayName("Undertaking Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmt")]
    #endif
    [IsoXmlTag("UdrtkgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmount1 UndertakingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAmount1 UndertakingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount1 UndertakingAmount { get; init; } 
    #else
    public UndertakingAmount1 UndertakingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the expiry terms of the undertaking.
    /// </summary>
    [IsoId("_9z-4UXltEeG7BsjMvd1mEw_2087724389")]
    [DisplayName("Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtls")]
    #endif
    [IsoXmlTag("XpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExpiryDetails2 ExpiryDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExpiryDetails2 ExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails2 ExpiryDetails { get; init; } 
    #else
    public ExpiryDetails2 ExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party, in addition to the other parties specified in the undertaking, that is also related to the undertaking.
    /// </summary>
    [IsoId("_9z-4UnltEeG7BsjMvd1mEw_-1228971442")]
    [DisplayName("Additional Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPty")]
    #endif
    [IsoXmlTag("AddtlPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndType1? AdditionalParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndType1? AdditionalParty { get; init; } 
    #else
    public PartyAndType1? AdditionalParty { get; set; } 
    #endif
    
    /// <summary>
    /// Rules and laws governing the undertaking.
    /// </summary>
    [IsoId("_9z-4U3ltEeG7BsjMvd1mEw_1523824041")]
    [DisplayName("Governance Rules And Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovncRulesAndLaw")]
    #endif
    [IsoXmlTag("GovncRulesAndLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #else
    public GovernanceRules1 GovernanceRulesAndLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    [IsoId("_9z-4VHltEeG7BsjMvd1mEw_1809587553")]
    [DisplayName("Underlying Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygTx")]
    #endif
    [IsoXmlTag("UndrlygTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    #else
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    [IsoId("_E0MAA31xEeGlwNeVP9egyg")]
    [DisplayName("Presentation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntnDtls")]
    #endif
    [IsoXmlTag("PresntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Presentation4? PresentationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Presentation4? PresentationDetails { get; init; } 
    #else
    public Presentation4? PresentationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Wording details and text for the undertaking.
    /// </summary>
    [IsoId("_9z-4VXltEeG7BsjMvd1mEw_524306423")]
    [DisplayName("Undertaking Wording")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgWrdg")]
    #endif
    [IsoXmlTag("UdrtkgWrdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingWording1 UndertakingWording { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingWording1 UndertakingWording { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingWording1 UndertakingWording { get; init; } 
    #else
    public UndertakingWording1 UndertakingWording { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether multiple demands are permitted.
    /// </summary>
    [IsoId("_90ICQHltEeG7BsjMvd1mEw_-1002106461")]
    [DisplayName("Multiple Demand Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplDmndInd")]
    #endif
    [IsoXmlTag("MltplDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultipleDemandIndicator { get; init; } 
    #else
    public System.String? MultipleDemandIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether partial demands/drawings are permitted.
    /// </summary>
    [IsoId("_90ICQXltEeG7BsjMvd1mEw_1249598259")]
    [DisplayName("Partial Demand Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlDmndInd")]
    #endif
    [IsoXmlTag("PrtlDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialDemandIndicator { get; init; } 
    #else
    public System.String? PartialDemandIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the undertaking is transferable.
    /// </summary>
    [IsoId("_90ICQnltEeG7BsjMvd1mEw_918585136")]
    [DisplayName("Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfInd")]
    #endif
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferIndicator { get; init; } 
    #else
    public System.String? TransferIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_90ICQ3ltEeG7BsjMvd1mEw_2007327829")]
    [DisplayName("Transfer Charges Payable By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfChrgsPyblBy")]
    #endif
    [IsoXmlTag("TrfChrgsPyblBy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    #else
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_90RzQHltEeG7BsjMvd1mEw_-1998513296")]
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
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_90RzQXltEeG7BsjMvd1mEw_1001580649")]
    [DisplayName("Automatic Amount Variation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcAmtVartn")]
    #endif
    [IsoXmlTag("AutomtcAmtVartn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    #else
    public AutomaticVariation1? AutomaticAmountVariation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    [IsoId("_90RzQnltEeG7BsjMvd1mEw_706566425")]
    [DisplayName("Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryChanl")]
    #endif
    [IsoXmlTag("DlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationChannel1 DeliveryChannel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationChannel1 DeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationChannel1 DeliveryChannel { get; init; } 
    #else
    public CommunicationChannel1 DeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Account nominated by the obligor to record the liability amount of the undertaking.
    /// </summary>
    [IsoId("_90RzQ3ltEeG7BsjMvd1mEw_41581817")]
    [DisplayName("Obligor Liability Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrLbltyAcct")]
    #endif
    [IsoXmlTag("OblgrLbltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount28? ObligorLiabilityAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount28? ObligorLiabilityAccount { get; init; } 
    #else
    public CashAccount28? ObligorLiabilityAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account nominated by the obligor for the settlement of charges related to the undertaking.
    /// </summary>
    [IsoId("_90RzRHltEeG7BsjMvd1mEw_-2031243712")]
    [DisplayName("Obligor Charge Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrChrgAcct")]
    #endif
    [IsoXmlTag("OblgrChrgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount28? ObligorChargeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount28? ObligorChargeAccount { get; init; } 
    #else
    public CashAccount28? ObligorChargeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account nominated by the obligor for the settlement of the amount claimed under the undertaking.
    /// </summary>
    [IsoId("_90RzRXltEeG7BsjMvd1mEw_-545066091")]
    [DisplayName("Obligor Settlement Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrSttlmAcct")]
    #endif
    [IsoXmlTag("OblgrSttlmAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount28? ObligorSettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount28? ObligorSettlementAccount { get; init; } 
    #else
    public CashAccount28? ObligorSettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the undertaking directly related to the undertaking to be issued.
    /// </summary>
    [IsoId("_90a9MHltEeG7BsjMvd1mEw_1646449472")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the application for an undertaking.
    /// </summary>
    [IsoId("_90a9MXltEeG7BsjMvd1mEw_-1178434824")]
    [DisplayName("Additional Application Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlApplInf")]
    #endif
    [IsoXmlTag("AddtlApplInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalApplicationInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
