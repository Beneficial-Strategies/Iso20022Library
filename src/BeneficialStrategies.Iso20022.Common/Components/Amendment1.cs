// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9-jwoHltEeG7BsjMvd1mEw_-951875342")]
[DisplayName("Amendment")]
public record Amendment1
{
    /// <summary>
    /// Sequence number assigned by the issuer to each proposed amendment of the undertaking.
    /// </summary>
    [IsoId("_9-jwoXltEeG7BsjMvd1mEw_-733763552")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText SequenceNumber { get; init; }

    /// <summary>
    /// Date on which the proposed amendment is issued.
    /// </summary>
    [IsoId("_9-jwonltEeG7BsjMvd1mEw_571423814")]
    [DisplayName("Date Of Issuance")]
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfIssuance { get; init; }

    /// <summary>
    /// Identification of the undertaking.
    /// </summary>
    [IsoId("_9-jwo3ltEeG7BsjMvd1mEw_1503262591")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking7 UndertakingIdentification { get; init; }

    /// <summary>
    /// Party asked to advise the proposed amendment to the beneficiary or to another advising party at the request of the issuer.
    /// </summary>
    [IsoId("_9-jwpHltEeG7BsjMvd1mEw_1390806841")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public PartyIdentification43? AdvisingParty { get; init; }

    /// <summary>
    /// Additional party asked to advise the proposed amendment.
    /// </summary>
    [IsoId("_9-thoHltEeG7BsjMvd1mEw_922888858")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; }

    /// <summary>
    /// Details concerning the requested termination of the undertaking.
    /// </summary>
    [IsoId("_9-thoXltEeG7BsjMvd1mEw_279324661")]
    [DisplayName("Termination Details")]
    [IsoXmlTag("TermntnDtls")]
    public UndertakingTermination3? TerminationDetails { get; init; }

    /// <summary>
    /// Requested increase or decrease to the amount of for the undertaking.
    /// </summary>
    [IsoId("_9-thonltEeG7BsjMvd1mEw_-1198886709")]
    [DisplayName("Undertaking Amount Adjustment")]
    [IsoXmlTag("UdrtkgAmtAdjstmnt")]
    public UndertakingAmount2? UndertakingAmountAdjustment { get; init; }

    /// <summary>
    /// Requested new expiry terms for the undertaking.
    /// </summary>
    [IsoId("_9-tho3ltEeG7BsjMvd1mEw_-1424200957")]
    [DisplayName("New Expiry Details")]
    [IsoXmlTag("NewXpryDtls")]
    public ExpiryDetails1? NewExpiryDetails { get; init; }

    /// <summary>
    /// Requested new beneficiary of the undertaking.
    /// </summary>
    [IsoId("_9-thpHltEeG7BsjMvd1mEw_1943469697")]
    [DisplayName("New Beneficiary")]
    [IsoXmlTag("NewBnfcry")]
    public PartyIdentification43? NewBeneficiary { get; init; }

    /// <summary>
    /// Requested new terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_9-2rkHltEeG7BsjMvd1mEw_1346112541")]
    [DisplayName("New Undertaking Terms And Conditions")]
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    public ValueList<Narrative1> NewUndertakingTermsAndConditions { get; init; } = [];

    /// <summary>
    /// Amendment details related to the local undertaking.
    /// </summary>
    [IsoId("_iQNfYH8BEeGvEbxvurqpIg")]
    [DisplayName("Local Undertaking")]
    [IsoXmlTag("LclUdrtkg")]
    public Undertaking11? LocalUndertaking { get; init; }

    /// <summary>
    /// Indicates whether or not consent is requested from the beneficiary.
    /// </summary>
    [IsoId("_9-2rkXltEeG7BsjMvd1mEw_-270158341")]
    [DisplayName("Beneficiary Consent Request Indicator")]
    [IsoXmlTag("BnfcryCnsntReqInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BeneficiaryConsentRequestIndicator { get; init; }

    /// <summary>
    /// Communication channel for delivery of the proposed amendment.
    /// </summary>
    [IsoId("_9-2rknltEeG7BsjMvd1mEw_-1316238920")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public CommunicationChannel1? DeliveryChannel { get; init; }

    /// <summary>
    /// Document or template enclosed in the proposed amendment.
    /// </summary>
    [IsoId("_9-2rk3ltEeG7BsjMvd1mEw_-1801397282")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document9> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Additional information related to the proposed amendment.
    /// </summary>
    [IsoId("_9-2rlHltEeG7BsjMvd1mEw_-1115047921")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
