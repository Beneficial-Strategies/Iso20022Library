// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reorganisation Instruction SD15.
/// </summary>
[IsoId("_assCoXG2Ee6S2Llv74R19w")]
[DisplayName("Reorganisation Instruction SD15")]
public partial record ReorganisationInstructionSD15
{
    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public Max350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public Max15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Sequence.
    /// </summary>
    [DisplayName("Transaction Sequence")]
    [IsoXmlTag("TxSeq")]
    public ValueList<InstructionsTransactionsSequence2> TransactionSequence { get; init; } = [];

    /// <summary>
    /// Transaction Identification Status.
    /// </summary>
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; }

    /// <summary>
    /// Protect Transaction Status.
    /// </summary>
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public SimpleValueList<InstructionReason4Code> Reason { get; init; } = [];

    /// <summary>
    /// Securities Quantity Details.
    /// </summary>
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantitySD9? SecuritiesQuantityDetails { get; init; }

    /// <summary>
    /// Customer Reference Identification.
    /// </summary>
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    public Max30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Acknowledgement Details.
    /// </summary>
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; }

    /// <summary>
    /// Contact Person.
    /// </summary>
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Warrant Subscription Charge Amount.
    /// </summary>
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; }

    /// <summary>
    /// Certificate.
    /// </summary>
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; }

    /// <summary>
    /// User Reference Number.
    /// </summary>
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    public Max6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// Deceased Beneficial Owner Details.
    /// </summary>
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; }

    /// <summary>
    /// Transaction Record Number.
    /// </summary>
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    public Max10NumericText? TransactionRecordNumber { get; init; }

    /// <summary>
    /// Bid Price.
    /// </summary>
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat71Choice_? BidPrice { get; init; }

    /// <summary>
    /// Shareholder Number.
    /// </summary>
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    public RestrictedFINXMax25Text? ShareholderNumber { get; init; }
}
