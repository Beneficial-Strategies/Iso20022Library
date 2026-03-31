// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
[IsoId("_57pqEb5ZEeexmbB7KsjCwA")]
[DisplayName("Option Transaction Details SD")]
public record OptionTransactionDetailsSD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_6L2pQb5ZEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_6L2pQ75ZEeexmbB7KsjCwA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_6L2pRb5ZEeexmbB7KsjCwA")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_6L2pR75ZEeexmbB7KsjCwA")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; }

    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_6L2pSb5ZEeexmbB7KsjCwA")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; }

    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_6L2pS75ZEeexmbB7KsjCwA")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_6L2pTb5ZEeexmbB7KsjCwA")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_6L2pT75ZEeexmbB7KsjCwA")]
    [DisplayName("Agent Entered Quantity")]
    [IsoXmlTag("AgtNtrdQty")]
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; }

    /// <summary>
    /// Instructed quantity less the quantity entered by Agent on PUT (Mortgage Backed) instructions. Remaining unpaid quantity.
    /// </summary>
    [IsoId("_6L2pUb5ZEeexmbB7KsjCwA")]
    [DisplayName("Agent Remaining Quantity")]
    [IsoXmlTag("AgtRmngQty")]
    public FinancialInstrumentQuantity15Choice_? AgentRemainingQuantity { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_6L2pU75ZEeexmbB7KsjCwA")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }
}
