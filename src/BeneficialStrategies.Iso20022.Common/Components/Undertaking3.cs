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
[IsoId("_90kuMnltEeG7BsjMvd1mEw_-642295687")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Undertaking3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Undertaking3( System.String reqIdentification,UndertakingIssuanceName1Code reqName,IssuanceType1Code reqIssuanceType,PartyIdentification43 reqIssuer,System.DateOnly reqDateOfIssuance,UndertakingAmount1 reqUndertakingAmount,ExpiryDetails1 reqExpiryDetails,GovernanceRules1 reqGovernanceRulesAndLaw )
    {
        Identification = reqIdentification;
        Name = reqName;
        IssuanceType = reqIssuanceType;
        Issuer = reqIssuer;
        DateOfIssuance = reqDateOfIssuance;
        UndertakingAmount = reqUndertakingAmount;
        ExpiryDetails = reqExpiryDetails;
        GovernanceRulesAndLaw = reqGovernanceRulesAndLaw;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_90kuM3ltEeG7BsjMvd1mEw_1282240890")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of undertaking such as, demand guarantee, standby letter of credit.
    /// </summary>
    [IsoId("_90kuNHltEeG7BsjMvd1mEw_-1574689593")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingIssuanceName1Code Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingIssuanceName1Code Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingIssuanceName1Code Name { get; init; } 
    #else
    public UndertakingIssuanceName1Code Name { get; set; } 
    #endif
    
    /// <summary>
    /// Type of undertaking, for example, performance, payment.
    /// </summary>
    [IsoId("_90kuNXltEeG7BsjMvd1mEw_-320799075")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingType1Choice_? Type { get; init; } 
    #else
    public UndertakingType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the undertaking issuance.
    /// </summary>
    [IsoId("_90kuNnltEeG7BsjMvd1mEw_-775223111")]
    [DisplayName("Issuance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncTp")]
    #endif
    [IsoXmlTag("IssncTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IssuanceType1Code IssuanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IssuanceType1Code IssuanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuanceType1Code IssuanceType { get; init; } 
    #else
    public IssuanceType1Code IssuanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Party named in the undertaking as the “applicant”.
    /// </summary>
    [IsoId("_90ufMHltEeG7BsjMvd1mEw_-1105882178")]
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
    [IsoId("_90ufMXltEeG7BsjMvd1mEw_1179128260")]
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
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// </summary>
    [IsoId("_90ufMnltEeG7BsjMvd1mEw_1504245767")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _90ufMnltEeG7BsjMvd1mEw_1504245767
    
    /// <summary>
    /// Date on which the undertaking is issued.
    /// </summary>
    [IsoId("_90ufM3ltEeG7BsjMvd1mEw_-776484199")]
    [DisplayName("Date Of Issuance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfIssnc")]
    #endif
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateOfIssuance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateOfIssuance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateOfIssuance { get; init; } 
    #else
    public System.DateOnly DateOfIssuance { get; set; } 
    #endif
    
    /// <summary>
    /// Location which is to be regarded as the place from which the undertaking is issued.
    /// </summary>
    [IsoId("_90ufNHltEeG7BsjMvd1mEw_-164292819")]
    [DisplayName("Place Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfIsse")]
    #endif
    [IsoXmlTag("PlcOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress12? PlaceOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress12? PlaceOfIssue { get; init; } 
    #else
    public PostalAddress12? PlaceOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Party asked to advise the undertaking to the beneficiary or to another advising party at the request of the issuer.
    /// </summary>
    [IsoId("_90ufNXltEeG7BsjMvd1mEw_188094849")]
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
    [IsoId("_903pIHltEeG7BsjMvd1mEw_-1729409632")]
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
    /// Details related to the amount of the undertaking.
    /// </summary>
    [IsoId("_903pIXltEeG7BsjMvd1mEw_-460655972")]
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
    /// Details related to the expiry of the undertaking.
    /// </summary>
    [IsoId("_903pInltEeG7BsjMvd1mEw_1815536700")]
    [DisplayName("Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtls")]
    #endif
    [IsoXmlTag("XpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails1 ExpiryDetails { get; init; } 
    #else
    public ExpiryDetails1 ExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the advising bank (confirmer) is requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_903pI3ltEeG7BsjMvd1mEw_-1282634856")]
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
    /// Indicates the type of party requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_903pJHltEeG7BsjMvd1mEw_-497049183")]
    [DisplayName("Confirmation Party Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPtyTp")]
    #endif
    [IsoXmlTag("ConfPtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalTypeOfParty1Code? ConfirmationPartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code? ConfirmationPartyType { get; init; } 
    #else
    public ExternalTypeOfParty1Code? ConfirmationPartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Party, in addition to the other parties specified in the undertaking, that is also related to the undertaking.
    /// </summary>
    [IsoId("_91BaIHltEeG7BsjMvd1mEw_-1201686871")]
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
    [IsoId("_91BaIXltEeG7BsjMvd1mEw_1314439670")]
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
    [IsoId("_91BaInltEeG7BsjMvd1mEw_575458194")]
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
    [IsoId("_91BaI3ltEeG7BsjMvd1mEw_-499300389")]
    [DisplayName("Presentation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntnDtls")]
    #endif
    [IsoXmlTag("PresntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Presentation1? PresentationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Presentation1? PresentationDetails { get; init; } 
    #else
    public Presentation1? PresentationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_91BaJHltEeG7BsjMvd1mEw_1083323567")]
    [DisplayName("Undertaking Terms And Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgTermsAndConds")]
    #endif
    [IsoXmlTag("UdrtkgTermsAndConds")]
    public ValueList<Narrative1> UndertakingTermsAndConditions { get; init; } = new ValueList<Narrative1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _91BaJHltEeG7BsjMvd1mEw_1083323567
    
    /// <summary>
    /// Indicates that multiple demands are not permitted.
    /// </summary>
    [IsoId("_91LLIHltEeG7BsjMvd1mEw_-1758524165")]
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
    /// Indicates that partial demands/drawings are not permitted.
    /// </summary>
    [IsoId("_91LLIXltEeG7BsjMvd1mEw_-1433406658")]
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
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_91LLInltEeG7BsjMvd1mEw_-1434307037")]
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
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_91LLI3ltEeG7BsjMvd1mEw_611229394")]
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
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_91LLJHltEeG7BsjMvd1mEw_1235192092")]
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
    [IsoId("__-dh438KEeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryChanl")]
    #endif
    [IsoXmlTag("DlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #else
    public CommunicationChannel1? DeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the undertaking is transferable.
    /// </summary>
    [IsoId("_91UVEHltEeG7BsjMvd1mEw_-737334082")]
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
    /// Document or template enclosed in the undertaking directly related to the issued undertaking.
    /// </summary>
    [IsoId("_91UVEXltEeG7BsjMvd1mEw_-1334688304")]
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
    /// Additional information related to the undertaking.
    /// </summary>
    [IsoId("_91UVEnltEeG7BsjMvd1mEw_-1357279647")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Details of the local or ancillary undertaking requested to be issued by a local or other issuing institution.
    /// </summary>
    [IsoId("_91UVFHltEeG7BsjMvd1mEw_-1115655388")]
    [DisplayName("Requested Local Undertaking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdLclUdrtkg")]
    #endif
    [IsoXmlTag("ReqdLclUdrtkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Undertaking4? RequestedLocalUndertaking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking4? RequestedLocalUndertaking { get; init; } 
    #else
    public Undertaking4? RequestedLocalUndertaking { get; set; } 
    #endif
    
    
    #nullable disable
    
}
