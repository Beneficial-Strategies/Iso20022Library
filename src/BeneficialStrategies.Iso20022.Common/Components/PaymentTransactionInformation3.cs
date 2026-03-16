// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and status information concerning the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_PsOGYNp-Ed-ak6NoX_4Aeg_1422225346")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation3
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request, assigned by an instructing party.||Usage: the cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request transaction.
    /// </summary>
    [IsoId("_PsOGYdp-Ed-ak6NoX_4Aeg_1422225381")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    [IsoId("_PsOGYtp-Ed-ak6NoX_4Aeg_1422225766")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_PsOGY9p-Ed-ak6NoX_4Aeg_1422225801")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_PsOGZNp-Ed-ak6NoX_4Aeg_1422225844")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    [IsoId("_PsOGZdp-Ed-ak6NoX_4Aeg_1422225879")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Amount of money transferred between the instructing agent and the instructed agent in the original transaction.
    /// </summary>
    [IsoId("_PsOGZtp-Ed-ak6NoX_4Aeg_780333300")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency as ordered by the initiating party in the original transaction.
    /// </summary>
    [IsoId("_PsOGZ9p-Ed-ak6NoX_4Aeg_1422225921")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public CurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PsOGaNp-Ed-ak6NoX_4Aeg_-472077655")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PsXQUNp-Ed-ak6NoX_4Aeg_-472077748")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_PsXQUdp-Ed-ak6NoX_4Aeg_-613481166")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public CancellationReasonInformation1? CancellationReasonInformation { get; init; }

    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_PsXQUtp-Ed-ak6NoX_4Aeg_1422226791")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
