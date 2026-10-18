// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader94"/>
[IsoId("_4CrvqXL-EeidQ_AAdEzxQA")]
[DisplayName("Group Header")]
public partial record GroupHeader94
{
    /// <inheritdoc cref="IGroupHeader94.MessageIdentification"/>
    [IsoId("_4M0jA3L-EeidQ_AAdEzxQA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader94.CreationDateTime"/>
    [IsoId("_4M0jBXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader94.Authorisation"/>
    [IsoId("_4M0jB3L-EeidQ_AAdEzxQA")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader94.BatchBooking"/>
    [IsoId("_4M0jCXL-EeidQ_AAdEzxQA")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader94.NumberOfTransactions"/>
    [IsoId("_4M0jC3L-EeidQ_AAdEzxQA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader94.ControlSum"/>
    [IsoId("_4M0jDXL-EeidQ_AAdEzxQA")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader94.TotalInterbankSettlementAmount"/>
    [IsoId("_4M0jD3L-EeidQ_AAdEzxQA")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader94.InterbankSettlementDate"/>
    [IsoId("_4M0jEXL-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader94.SettlementInformation"/>
    [IsoId("_4M0jE3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction8 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader94.PaymentTypeInformation"/>
    [IsoId("_4M0jFXL-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader94.InstructingAgent"/>
    [IsoId("_4M0jF3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader94.InstructedAgent"/>
    [IsoId("_4M0jGXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }
}
