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
[IsoId("_rV3zQQCEEeqouY-yI_q3qQ")]
[DisplayName("Option Transaction SD")]
public record OptionTransactionSD6
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_rpXXAQCEEeqouY-yI_q3qQ")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_rphIAQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIAwCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIBQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; }

    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIBwCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; }

    /// <summary>
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    [IsoId("_rphICQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; }

    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_rphICwCEEeqouY-yI_q3qQ")]
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; }

    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_rphIDQCEEeqouY-yI_q3qQ")]
    [DisplayName("Unaccepted Quantity")]
    [IsoXmlTag("UaccptdQty")]
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; }

    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_rphIDwCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_rphIEQCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; }

    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    [IsoId("_rphIEwCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Oversubscription Quantity")]
    [IsoXmlTag("EntitldOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    [IsoId("_rphIFQCEEeqouY-yI_q3qQ")]
    [DisplayName("Subscription Amount")]
    [IsoXmlTag("SbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; }

    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    [IsoId("_rphIFwCEEeqouY-yI_q3qQ")]
    [DisplayName("Oversubscription Amount")]
    [IsoXmlTag("OvrsbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_rphIGQCEEeqouY-yI_q3qQ")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_rphIIQCEEeqouY-yI_q3qQ")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_rphIIwCEEeqouY-yI_q3qQ")]
    [DisplayName("Agent Entered Quantity")]
    [IsoXmlTag("AgtNtrdQty")]
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; }

    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_rphIJQCEEeqouY-yI_q3qQ")]
    [DisplayName("Instruction Comments")]
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionComments { get; init; }

    /// <summary>
    /// Amount of money debited or credited to adjust for the difference between the estimated and the final subscription rate for Rights Exercise events.
    /// </summary>
    [IsoId("_nkt10gCEEeqouY-yI_q3qQ")]
    [DisplayName("Adjusted Subscription Amount")]
    [IsoXmlTag("AdjstdSbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; }

    /// <summary>
    /// Amount of money refunded from the original subscription cost for a Rights Exercise event.  This occurs when the event is prorated and the subscription cost relating to the unaffected (unaccepted) balance is returned to the holder.
    /// </summary>
    [IsoId("_nkt10wCEEeqouY-yI_q3qQ")]
    [DisplayName("Refunded Subscription Amount")]
    [IsoXmlTag("RfnddSbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; }
}
