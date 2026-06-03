// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("983dfe0b-8406-465c-8059-079b5243aa85")]
[DisplayName("Payment Transaction172")]
public record PaymentTransaction172
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request, as assigned by the assigner.
    /// </summary>
    [IsoId("32db28b3-7648-423b-9f3e-ed5ce5019d78")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("7e4351ef-6361-4475-903b-6abcd4f758bd")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case6? Case { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("c671e795-33c5-42ba-b82c-c30ab364828c")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("0aea58fc-aae0-4993-a9c4-cd1f66a01283")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("55a5a837-a8bb-42fb-b555-e038212306eb")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("4a6fdf2a-48d1-4998-a056-ec80bcd7b632")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("3d992e21-8e13-4b32-b0c5-d52b7abedecd")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("98e52064-770b-4ee2-912e-f943be02004c")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("a19fd0cb-a3a1-4192-b610-cb0a97b29995")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it.
    /// </summary>
    [IsoId("272a75bd-7238-4d3a-a89e-8ca238975cd9")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <summary>
    /// Party who assigns the case.
    /// </summary>
    [IsoId("37455edf-3bd1-470f-a8a7-2772eaa50581")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public BranchAndFinancialInstitutionIdentification8? Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.
    /// </summary>
    [IsoId("08879ab1-ef8b-48b7-8b54-08678921543a")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public BranchAndFinancialInstitutionIdentification8? Assignee { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("94ef6c96-ded9-4516-af98-cf760ef0e26e")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<PaymentCancellationReason6> CancellationReasonInformation { get; init; } = [];

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("e18aa2dd-b6d5-4fbf-b1a1-dc7de7bb79d2")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference47? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("3d2e604b-fb13-4953-b952-49830b8b5c41")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
