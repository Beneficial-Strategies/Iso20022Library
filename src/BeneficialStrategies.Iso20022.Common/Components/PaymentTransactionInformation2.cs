// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and status information concerning the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_PsXQU9p-Ed-ak6NoX_4Aeg_-1190214356")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation2
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the returned transaction.
    /// </summary>
    [IsoId("_PsXQVNp-Ed-ak6NoX_4Aeg_-1190213875")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_PsXQVdp-Ed-ak6NoX_4Aeg_-2131644084")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_PsXQVtp-Ed-ak6NoX_4Aeg_-1551043273")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_PsXQV9p-Ed-ak6NoX_4Aeg_-1190213970")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    [IsoId("_PsXQWNp-Ed-ak6NoX_4Aeg_511775997")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Original amount of money as moved between the instructing agent and the instructed agent in the original transaction.
    /// </summary>
    [IsoId("_PshBUNp-Ed-ak6NoX_4Aeg_-1190213840")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Returned amount of money moved between the instructing agent and the instructed agent in the return transaction.
    /// </summary>
    [IsoId("_PshBUdp-Ed-ak6NoX_4Aeg_-1190213331")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required CurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_PshBUtp-Ed-ak6NoX_4Aeg_-1190213763")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// </summary>
    [IsoId("_PshBU9p-Ed-ak6NoX_4Aeg_1617271903")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public CurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <summary>
    /// The factor used for conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_PshBVNp-Ed-ak6NoX_4Aeg_-1190213443")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_PshBVdp-Ed-ak6NoX_4Aeg_-1190213720")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public CurrencyAndAmount? CompensationAmount { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_PshBVtp-Ed-ak6NoX_4Aeg_-1190213408")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Transaction charges to be paid by the charge bearer for the return transaction.
    /// </summary>
    [IsoId("_PshBV9p-Ed-ak6NoX_4Aeg_-2132608256")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PshBWNp-Ed-ak6NoX_4Aeg_-710385882")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PshBWdp-Ed-ak6NoX_4Aeg_-710387311")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <summary>
    /// Detailed information on the return reason.
    /// </summary>
    [IsoId("_PsqLQNp-Ed-ak6NoX_4Aeg_-1111192957")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<ReturnReasonInformation1> ReturnReasonInformation { get; init; } = [];

    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_PsqLQdp-Ed-ak6NoX_4Aeg_-405283210")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
