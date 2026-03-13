// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be honoured on the presentation of documents that comply with its terms and conditions.
/// </summary>
[IsoId("_90kuMnltEeG7BsjMvd1mEw_-642295687")]
[DisplayName("Undertaking")]
public partial record Undertaking3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_90kuM3ltEeG7BsjMvd1mEw_1282240890")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Name of undertaking such as, demand guarantee, standby letter of credit.
    /// </summary>
    [IsoId("_90kuNHltEeG7BsjMvd1mEw_-1574689593")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required UndertakingIssuanceName1Code Name { get; init; } 
    
    /// <summary>
    /// Type of undertaking, for example, performance, payment.
    /// </summary>
    [IsoId("_90kuNXltEeG7BsjMvd1mEw_-320799075")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public UndertakingType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Type of the undertaking issuance.
    /// </summary>
    [IsoId("_90kuNnltEeG7BsjMvd1mEw_-775223111")]
    [DisplayName("Issuance Type")]
    [IsoXmlTag("IssncTp")]
    public required IssuanceType1Code IssuanceType { get; init; } 
    
    /// <summary>
    /// Party named in the undertaking as the “applicant”.
    /// </summary>
    [IsoId("_90ufMHltEeG7BsjMvd1mEw_-1105882178")]
    [DisplayName("Applicant")]
    [IsoXmlTag("Applcnt")]
    public PartyIdentification43? Applicant { get; init; } 
    
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// </summary>
    [IsoId("_90ufMXltEeG7BsjMvd1mEw_1179128260")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification43 Issuer { get; init; } 
    
    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// </summary>
    [IsoId("_90ufMnltEeG7BsjMvd1mEw_1504245767")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = [];
    // ID for the above is _90ufMnltEeG7BsjMvd1mEw_1504245767
    
    /// <summary>
    /// Date on which the undertaking is issued.
    /// </summary>
    [IsoId("_90ufM3ltEeG7BsjMvd1mEw_-776484199")]
    [DisplayName("Date Of Issuance")]
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfIssuance { get; init; } 
    
    /// <summary>
    /// Location which is to be regarded as the place from which the undertaking is issued.
    /// </summary>
    [IsoId("_90ufNHltEeG7BsjMvd1mEw_-164292819")]
    [DisplayName("Place Of Issue")]
    [IsoXmlTag("PlcOfIsse")]
    public PostalAddress12? PlaceOfIssue { get; init; } 
    
    /// <summary>
    /// Party asked to advise the undertaking to the beneficiary or to another advising party at the request of the issuer.
    /// </summary>
    [IsoId("_90ufNXltEeG7BsjMvd1mEw_188094849")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public PartyIdentification43? AdvisingParty { get; init; } 
    
    /// <summary>
    /// Additional party asked to advise the undertaking.
    /// </summary>
    [IsoId("_903pIHltEeG7BsjMvd1mEw_-1729409632")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    
    /// <summary>
    /// Details related to the amount of the undertaking.
    /// </summary>
    [IsoId("_903pIXltEeG7BsjMvd1mEw_-460655972")]
    [DisplayName("Undertaking Amount")]
    [IsoXmlTag("UdrtkgAmt")]
    public required UndertakingAmount1 UndertakingAmount { get; init; } 
    
    /// <summary>
    /// Details related to the expiry of the undertaking.
    /// </summary>
    [IsoId("_903pInltEeG7BsjMvd1mEw_1815536700")]
    [DisplayName("Expiry Details")]
    [IsoXmlTag("XpryDtls")]
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the advising bank (confirmer) is requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_903pI3ltEeG7BsjMvd1mEw_-1282634856")]
    [DisplayName("Confirmation Indicator")]
    [IsoXmlTag("ConfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the type of party requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_903pJHltEeG7BsjMvd1mEw_-497049183")]
    [DisplayName("Confirmation Party Type")]
    [IsoXmlTag("ConfPtyTp")]
    public ExternalTypeOfParty1Code? ConfirmationPartyType { get; init; } 
    
    /// <summary>
    /// Party, in addition to the other parties specified in the undertaking, that is also related to the undertaking.
    /// </summary>
    [IsoId("_91BaIHltEeG7BsjMvd1mEw_-1201686871")]
    [DisplayName("Additional Party")]
    [IsoXmlTag("AddtlPty")]
    public PartyAndType1? AdditionalParty { get; init; } 
    
    /// <summary>
    /// Rules and laws governing the undertaking.
    /// </summary>
    [IsoId("_91BaIXltEeG7BsjMvd1mEw_1314439670")]
    [DisplayName("Governance Rules And Law")]
    [IsoXmlTag("GovncRulesAndLaw")]
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    
    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    [IsoId("_91BaInltEeG7BsjMvd1mEw_575458194")]
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    
    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    [IsoId("_91BaI3ltEeG7BsjMvd1mEw_-499300389")]
    [DisplayName("Presentation Details")]
    [IsoXmlTag("PresntnDtls")]
    public Presentation1? PresentationDetails { get; init; } 
    
    /// <summary>
    /// Terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_91BaJHltEeG7BsjMvd1mEw_1083323567")]
    [DisplayName("Undertaking Terms And Conditions")]
    [IsoXmlTag("UdrtkgTermsAndConds")]
    public ValueList<Narrative1> UndertakingTermsAndConditions { get; init; } = [];
    // ID for the above is _91BaJHltEeG7BsjMvd1mEw_1083323567
    
    /// <summary>
    /// Indicates that multiple demands are not permitted.
    /// </summary>
    [IsoId("_91LLIHltEeG7BsjMvd1mEw_-1758524165")]
    [DisplayName("Multiple Demand Indicator")]
    [IsoXmlTag("MltplDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; } 
    
    /// <summary>
    /// Indicates that partial demands/drawings are not permitted.
    /// </summary>
    [IsoId("_91LLIXltEeG7BsjMvd1mEw_-1433406658")]
    [DisplayName("Partial Demand Indicator")]
    [IsoXmlTag("PrtlDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_91LLInltEeG7BsjMvd1mEw_-1434307037")]
    [DisplayName("Confirmation Charges Payable By")]
    [IsoXmlTag("ConfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_91LLI3ltEeG7BsjMvd1mEw_611229394")]
    [DisplayName("Transfer Charges Payable By")]
    [IsoXmlTag("TrfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    
    /// <summary>
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_91LLJHltEeG7BsjMvd1mEw_1235192092")]
    [DisplayName("Automatic Amount Variation")]
    [IsoXmlTag("AutomtcAmtVartn")]
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    
    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    [IsoId("__-dh438KEeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    
    /// <summary>
    /// Indicates whether the undertaking is transferable.
    /// </summary>
    [IsoId("_91UVEHltEeG7BsjMvd1mEw_-737334082")]
    [DisplayName("Transfer Indicator")]
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    
    /// <summary>
    /// Document or template enclosed in the undertaking directly related to the issued undertaking.
    /// </summary>
    [IsoId("_91UVEXltEeG7BsjMvd1mEw_-1334688304")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; } 
    
    /// <summary>
    /// Additional information related to the undertaking.
    /// </summary>
    [IsoId("_91UVEnltEeG7BsjMvd1mEw_-1357279647")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    /// <summary>
    /// Details of the local or ancillary undertaking requested to be issued by a local or other issuing institution.
    /// </summary>
    [IsoId("_91UVFHltEeG7BsjMvd1mEw_-1115655388")]
    [DisplayName("Requested Local Undertaking")]
    [IsoXmlTag("ReqdLclUdrtkg")]
    public Undertaking4? RequestedLocalUndertaking { get; init; } 
    
    
    #nullable disable
    
}
