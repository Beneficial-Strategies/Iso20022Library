// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be honoured on the presentation of documents that comply with its terms and conditions.
/// </summary>
[IsoId("_9ziMYXltEeG7BsjMvd1mEw_-2112761130")]
[DisplayName("Undertaking")]
public record Undertaking1
{
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_9ziMYnltEeG7BsjMvd1mEw_460465579")]
    [DisplayName("Applicant Reference Number")]
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicantReferenceNumber { get; init; }

    /// <summary>
    /// Brief description of the purpose of the undertaking. Provided as information for the issuer reference.
    /// </summary>
    [IsoId("_9ziMY3ltEeG7BsjMvd1mEw_1517489578")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Purpose { get; init; }

    /// <summary>
    /// Undertaking name.
    /// </summary>
    [IsoId("_bk57JYLJEeGwNp5ZjMErfw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required UndertakingName1Code Name { get; init; }

    /// <summary>
    /// Type of undertaking, for example, performance, payment.
    /// </summary>
    [IsoId("_9zrWUHltEeG7BsjMvd1mEw_-10772614")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required UndertakingType1Choice_ Type { get; init; }

    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// </summary>
    [IsoId("_9zrWUXltEeG7BsjMvd1mEw_1174661624")]
    [DisplayName("Obligor")]
    [IsoXmlTag("Oblgr")]
    public required PartyIdentification43 Obligor { get; init; }

    /// <summary>
    /// Party to be named in the undertaking as the “applicant” when different from the obligor.
    /// </summary>
    [IsoId("_9zrWUnltEeG7BsjMvd1mEw_-679982016")]
    [DisplayName("Applicant")]
    [IsoXmlTag("Applcnt")]
    public ValueList<PartyIdentification43> Applicant { get; init; } = [];

    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// </summary>
    [IsoId("_vdjc0310EeGlwNeVP9egyg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification43 Issuer { get; init; }

    /// <summary>
    /// Ultimate party in whose favour the undertaking is to be issued.
    /// </summary>
    [IsoId("_9zrWU3ltEeG7BsjMvd1mEw_-33006693")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = [];

    // ID for the above is _9zrWU3ltEeG7BsjMvd1mEw_-33006693

    /// <summary>
    /// Party asked to advise the undertaking to the beneficiary or to another advising party.
    /// </summary>
    [IsoId("_9zrWVHltEeG7BsjMvd1mEw_2007270322")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public PartyIdentification43? AdvisingParty { get; init; }

    /// <summary>
    /// Additional party asked to advise the undertaking.
    /// </summary>
    [IsoId("_9z1HUHltEeG7BsjMvd1mEw_224779758")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; }

    /// <summary>
    /// Party that adds its confirmation to the undertaking. For further clarification, reference the applicable rules to which the undertaking is subject.
    /// </summary>
    [IsoId("_9z1HUXltEeG7BsjMvd1mEw_-1332939117")]
    [DisplayName("Confirmer")]
    [IsoXmlTag("Cnfrmr")]
    public PartyIdentification43? Confirmer { get; init; }

    /// <summary>
    /// Indicates whether the advising bank (confirmer) is requested to add its confirmation to the undertaking. The absence of this element indicates that the advising bank (confirmer) is not requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_9z1HUnltEeG7BsjMvd1mEw_1175132881")]
    [DisplayName("Confirmation Indicator")]
    [IsoXmlTag("ConfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the undertaking is a local or ancillary undertaking to be issued under a counter-undertaking.
    /// </summary>
    [IsoId("_9z1HU3ltEeG7BsjMvd1mEw_1727440495")]
    [DisplayName("Counter Undertaking Indicator")]
    [IsoXmlTag("CntrUdrtkgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CounterUndertakingIndicator { get; init; }

    /// <summary>
    /// Details related to the counter undertaking.
    /// </summary>
    [IsoId("_9z1HVHltEeG7BsjMvd1mEw_617505551")]
    [DisplayName("Counter Undertaking")]
    [IsoXmlTag("CntrUdrtkg")]
    public Undertaking2? CounterUndertaking { get; init; }

    /// <summary>
    /// Details related to the amount of the undertaking.
    /// </summary>
    [IsoId("_9z-4UHltEeG7BsjMvd1mEw_-434744147")]
    [DisplayName("Undertaking Amount")]
    [IsoXmlTag("UdrtkgAmt")]
    public required UndertakingAmount1 UndertakingAmount { get; init; }

    /// <summary>
    /// Details related to the expiry terms of the undertaking.
    /// </summary>
    [IsoId("_9z-4UXltEeG7BsjMvd1mEw_2087724389")]
    [DisplayName("Expiry Details")]
    [IsoXmlTag("XpryDtls")]
    public required ExpiryDetails2 ExpiryDetails { get; init; }

    /// <summary>
    /// Party, in addition to the other parties specified in the undertaking, that is also related to the undertaking.
    /// </summary>
    [IsoId("_9z-4UnltEeG7BsjMvd1mEw_-1228971442")]
    [DisplayName("Additional Party")]
    [IsoXmlTag("AddtlPty")]
    public ValueList<PartyAndType1> AdditionalParty { get; init; } = [];

    /// <summary>
    /// Rules and laws governing the undertaking.
    /// </summary>
    [IsoId("_9z-4U3ltEeG7BsjMvd1mEw_1523824041")]
    [DisplayName("Governance Rules And Law")]
    [IsoXmlTag("GovncRulesAndLaw")]
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; }

    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    [IsoId("_9z-4VHltEeG7BsjMvd1mEw_1809587553")]
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public ValueList<UnderlyingTradeTransaction1> UnderlyingTransaction { get; init; } = [];

    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    [IsoId("_E0MAA31xEeGlwNeVP9egyg")]
    [DisplayName("Presentation Details")]
    [IsoXmlTag("PresntnDtls")]
    public Presentation4? PresentationDetails { get; init; }

    /// <summary>
    /// Wording details and text for the undertaking.
    /// </summary>
    [IsoId("_9z-4VXltEeG7BsjMvd1mEw_524306423")]
    [DisplayName("Undertaking Wording")]
    [IsoXmlTag("UdrtkgWrdg")]
    public required UndertakingWording1 UndertakingWording { get; init; }

    /// <summary>
    /// Indicates whether multiple demands are permitted.
    /// </summary>
    [IsoId("_90ICQHltEeG7BsjMvd1mEw_-1002106461")]
    [DisplayName("Multiple Demand Indicator")]
    [IsoXmlTag("MltplDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; }

    /// <summary>
    /// Indicates whether partial demands/drawings are permitted.
    /// </summary>
    [IsoId("_90ICQXltEeG7BsjMvd1mEw_1249598259")]
    [DisplayName("Partial Demand Indicator")]
    [IsoXmlTag("PrtlDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; }

    /// <summary>
    /// Indicates whether the undertaking is transferable.
    /// </summary>
    [IsoId("_90ICQnltEeG7BsjMvd1mEw_918585136")]
    [DisplayName("Transfer Indicator")]
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferIndicator { get; init; }

    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_90ICQ3ltEeG7BsjMvd1mEw_2007327829")]
    [DisplayName("Transfer Charges Payable By")]
    [IsoXmlTag("TrfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; }

    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_90RzQHltEeG7BsjMvd1mEw_-1998513296")]
    [DisplayName("Confirmation Charges Payable By")]
    [IsoXmlTag("ConfChrgsPyblBy")]
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; }

    /// <summary>
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_90RzQXltEeG7BsjMvd1mEw_1001580649")]
    [DisplayName("Automatic Amount Variation")]
    [IsoXmlTag("AutomtcAmtVartn")]
    public ValueList<AutomaticVariation1> AutomaticAmountVariation { get; init; } = [];

    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    [IsoId("_90RzQnltEeG7BsjMvd1mEw_706566425")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public required CommunicationChannel1 DeliveryChannel { get; init; }

    /// <summary>
    /// Account nominated by the obligor to record the liability amount of the undertaking.
    /// </summary>
    [IsoId("_90RzQ3ltEeG7BsjMvd1mEw_41581817")]
    [DisplayName("Obligor Liability Account")]
    [IsoXmlTag("OblgrLbltyAcct")]
    public CashAccount28? ObligorLiabilityAccount { get; init; }

    /// <summary>
    /// Account nominated by the obligor for the settlement of charges related to the undertaking.
    /// </summary>
    [IsoId("_90RzRHltEeG7BsjMvd1mEw_-2031243712")]
    [DisplayName("Obligor Charge Account")]
    [IsoXmlTag("OblgrChrgAcct")]
    public CashAccount28? ObligorChargeAccount { get; init; }

    /// <summary>
    /// Account nominated by the obligor for the settlement of the amount claimed under the undertaking.
    /// </summary>
    [IsoId("_90RzRXltEeG7BsjMvd1mEw_-545066091")]
    [DisplayName("Obligor Settlement Account")]
    [IsoXmlTag("OblgrSttlmAcct")]
    public CashAccount28? ObligorSettlementAccount { get; init; }

    /// <summary>
    /// Document or template enclosed in the undertaking directly related to the undertaking to be issued.
    /// </summary>
    [IsoId("_90a9MHltEeG7BsjMvd1mEw_1646449472")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document9> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Additional information related to the application for an undertaking.
    /// </summary>
    [IsoId("_90a9MXltEeG7BsjMvd1mEw_-1178434824")]
    [DisplayName("Additional Application Information")]
    [IsoXmlTag("AddtlApplInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalApplicationInformation { get; init; } = [];
}
