// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an undertaking.
/// </summary>
[IsoId("_9zFgdXltEeG7BsjMvd1mEw_1035435998")]
[DisplayName("Undertaking")]
public partial record Undertaking4
{
    #nullable enable
    
    /// <summary>
    /// Name of the requested local undertaking such as, demand guarantee, standby letter of credit, surety.
    /// </summary>
    [IsoId("_9zFgdnltEeG7BsjMvd1mEw_-864566025")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required UndertakingName1Code Name { get; init; } 
    
    /// <summary>
    /// Type of the requested local undertaking such as performance, payment.
    /// </summary>
    [IsoId("_9zOqYHltEeG7BsjMvd1mEw_-1636131870")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ExternalUndertakingType1Code Type { get; init; } 
    
    /// <summary>
    /// Party requested to be named in the local undertaking as the party on whose behalf the undertaking is issued.
    /// </summary>
    [IsoId("_9zOqYXltEeG7BsjMvd1mEw_-1559280949")]
    [DisplayName("Applicant")]
    [IsoXmlTag("Applcnt")]
    public ValueList<PartyIdentification43> Applicant { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9zOqYXltEeG7BsjMvd1mEw_-1559280949
    
    /// <summary>
    /// Party in whose favour the requested local undertaking is to be issued.
    /// </summary>
    [IsoId("_9zOqYnltEeG7BsjMvd1mEw_1081181075")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9zOqYnltEeG7BsjMvd1mEw_1081181075
    
    /// <summary>
    /// Date on which the requested local undertaking is to be issued.
    /// </summary>
    [IsoId("_9zOqY3ltEeG7BsjMvd1mEw_-930204574")]
    [DisplayName("Date Of Issuance")]
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfIssuance { get; init; } 
    
    /// <summary>
    /// Party asked to advise the requested local undertaking to the beneficiary or to another advising party at the request of the local undertaking issuer.
    /// </summary>
    [IsoId("_WeZCcxSDEeKyNbjzgBLUcA")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public PartyIdentification43? AdvisingParty { get; init; } 
    
    /// <summary>
    /// Additional party asked to advise the requested local undertaking.
    /// </summary>
    [IsoId("_rP0C8xSDEeKyNbjzgBLUcA")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    
    /// <summary>
    /// Details related to the amount of the local undertaking.
    /// </summary>
    [IsoId("_9zOqZHltEeG7BsjMvd1mEw_-1709390526")]
    [DisplayName("Local Undertaking Amount")]
    [IsoXmlTag("LclUdrtkgAmt")]
    public required UndertakingAmount1 LocalUndertakingAmount { get; init; } 
    
    /// <summary>
    /// Details related to the expiry of the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbYXltEeG7BsjMvd1mEw_1290133370")]
    [DisplayName("Expiry Details")]
    [IsoXmlTag("XpryDtls")]
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the advising bank (confirmer) is requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_56z_IxSAEeKyNbjzgBLUcA")]
    [DisplayName("Confirmation Indicator")]
    [IsoXmlTag("ConfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; } 
    
    /// <summary>
    /// Party, in addition to the other parties specified in the requested local undertaking, that is also related to the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbYnltEeG7BsjMvd1mEw_-1413623178")]
    [DisplayName("Additional Party")]
    [IsoXmlTag("AddtlPty")]
    public PartyAndType1? AdditionalParty { get; init; } 
    
    /// <summary>
    /// Rules and laws governing the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbY3ltEeG7BsjMvd1mEw_1952872268")]
    [DisplayName("Governance Rules And Law")]
    [IsoXmlTag("GovncRulesAndLaw")]
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    
    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    [IsoId("_NC1go31qEeGlwNeVP9egyg")]
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    
    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    [IsoId("_aUeqkxSAEeKyNbjzgBLUcA")]
    [DisplayName("Presentation Details")]
    [IsoXmlTag("PresntnDtls")]
    public Presentation1? PresentationDetails { get; init; } 
    
    /// <summary>
    /// Wording details and text for the requested local undertaking.
    /// </summary>
    [IsoId("_AOEX1RR_EeKyNbjzgBLUcA")]
    [DisplayName("Undertaking Wording")]
    [IsoXmlTag("UdrtkgWrdg")]
    public required UndertakingWording1 UndertakingWording { get; init; } 
    
    /// <summary>
    /// Indicates that multiple demands are not permitted.
    /// </summary>
    [IsoId("_SbTu4xSAEeKyNbjzgBLUcA")]
    [DisplayName("Multiple Demand Indicator")]
    [IsoXmlTag("MltplDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; } 
    
    /// <summary>
    /// Indicates that partial demands/drawings are not permitted.
    /// </summary>
    [IsoId("_En7ekxSAEeKyNbjzgBLUcA")]
    [DisplayName("Partial Demand Indicator")]
    [IsoXmlTag("PrtlDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_9zOqZXltEeG7BsjMvd1mEw_998876300")]
    [DisplayName("Confirmation Charges Payable By")]
    [IsoXmlTag("ConfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_9zYbYHltEeG7BsjMvd1mEw_1020340301")]
    [DisplayName("Transfer Charges Payable By")]
    [IsoXmlTag("TrfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    
    /// <summary>
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_WEveQxSBEeKyNbjzgBLUcA")]
    [DisplayName("Automatic Amount Variation")]
    [IsoXmlTag("AutomtcAmtVartn")]
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    
    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    [IsoId("_TSG81X8LEeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    
    /// <summary>
    /// Indicates whether the requested local undertaking is transferable.
    /// </summary>
    [IsoId("_4WwA0xR_EeKyNbjzgBLUcA")]
    [DisplayName("Transfer Indicator")]
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    
    /// <summary>
    /// Additional information related to the requested local undertaking.
    /// </summary>
    [IsoId("_9ziMYHltEeG7BsjMvd1mEw_228131973")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
