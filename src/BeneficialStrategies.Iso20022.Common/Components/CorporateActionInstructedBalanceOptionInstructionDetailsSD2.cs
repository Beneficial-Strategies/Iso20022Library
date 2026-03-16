// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_HHDqMb-0Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Instructed Balance Option Instruction Details SD")]
public record CorporateActionInstructedBalanceOptionInstructionDetailsSD2
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_HW1Lkb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_HW1Lk7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_HW1Lm7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_HW1Lnb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_HW1Ln7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; }

    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_HW1Lob-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Contra CUSIP")]
    [IsoXmlTag("TxContraCUSIP")]
    public OtherIdentification2? TransactionContraCUSIP { get; init; }

    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_HW1Lo7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; }

    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_HW1Lpb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_HW1Lp7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; }

    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_HW1Lqb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Protect Date")]
    [IsoXmlTag("TxIdPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionIdentificationProtectDate { get; init; }

    /// <summary>
    /// Date and time of the cover protect.
    /// </summary>
    [IsoId("_HW1Lq7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Cover Protect Date")]
    [IsoXmlTag("TxIdCoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionIdentificationCoverProtectDate { get; init; }

    /// <summary>
    /// Conditional quantity on the instruction.
    /// </summary>
    [IsoId("_HW1Lrb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Conditional Quantity")]
    [IsoXmlTag("TxCondlQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; }

    /// <summary>
    /// Tender bid price of the instruction.
    /// </summary>
    [IsoId("_HW1Lr7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Tender Bid Price")]
    [IsoXmlTag("TxTndrBidPric")]
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_HW1Lsb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_-tTSsb_vEeeb2ZBoAlSG1Q")]
    [DisplayName("Instruction Comments")]
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionComments { get; init; }
}
