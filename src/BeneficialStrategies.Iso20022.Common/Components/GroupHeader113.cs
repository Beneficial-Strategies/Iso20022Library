// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader113"/>
[IsoId("_yfTmITEyEe6g-ffJsqGiSA")]
[DisplayName("Group Header113")]
public partial record GroupHeader113
{
    /// <inheritdoc cref="IGroupHeader113.BatchBooking"/>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader113.ControlSum"/>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader113.CreationDateTime"/>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader113.InstructedAgent"/>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader113.InstructingAgent"/>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader113.InterbankSettlementDate"/>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader113.MessageIdentification"/>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader113.NumberOfTransactions"/>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader113.PaymentTypeInformation"/>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader113.SettlementInformation"/>
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction15 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader113.TotalInterbankSettlementAmount"/>
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }
}
