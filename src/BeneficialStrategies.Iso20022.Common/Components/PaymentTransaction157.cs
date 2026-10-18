// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction157.
/// </summary>
[IsoId("_9y63ITEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Transaction157")]
public record PaymentTransaction157
{
    /// <summary>
    /// Assignee.
    /// </summary>
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public Party50Choice_? Assignee { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public Party50Choice_? Assigner { get; init; }

    /// <summary>
    /// Modification Status Identification.
    /// </summary>
    [DisplayName("Modification Status Identification")]
    [IsoXmlTag("ModStsId")]
    public Max35Text? ModificationStatusIdentification { get; init; }

    /// <summary>
    /// Modification Status Reason Information.
    /// </summary>
    [DisplayName("Modification Status Reason Information")]
    [IsoXmlTag("ModStsRsnInf")]
    public ValueList<ModificationStatusReason3> ModificationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Original Clearing System Reference.
    /// </summary>
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    public Max35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public Max35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation29 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public Max35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Original Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Original Interbank Settlement Date.
    /// </summary>
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    public ISODate? OriginalInterbankSettlementDate { get; init; }

    /// <summary>
    /// Original Payment Information Identification.
    /// </summary>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public Max35Text? OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Original Transaction Identification.
    /// </summary>
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public Max35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Original Transaction Reference.
    /// </summary>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference42? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public UUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Resolution Related Information.
    /// </summary>
    [DisplayName("Resolution Related Information")]
    [IsoXmlTag("RsltnRltdInf")]
    public ResolutionData5? ResolutionRelatedInformation { get; init; }

    /// <summary>
    /// Resolved Case.
    /// </summary>
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case6? ResolvedCase { get; init; }
}
