// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader70"/>
[IsoId("_jSZswTq3EeWZFYSPlduMhw")]
[DisplayName("Group Header")]
public partial record GroupHeader70
{
    /// <inheritdoc cref="IGroupHeader70.MessageIdentification"/>
    [IsoId("_ja46Yzq3EeWZFYSPlduMhw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader70.CreationDateTime"/>
    [IsoId("_ja46ZTq3EeWZFYSPlduMhw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader70.BatchBooking"/>
    [IsoId("_ja46Zzq3EeWZFYSPlduMhw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader70.NumberOfTransactions"/>
    [IsoId("_ja46aTq3EeWZFYSPlduMhw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader70.ControlSum"/>
    [IsoId("_ja46azq3EeWZFYSPlduMhw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader70.TotalInterbankSettlementAmount"/>
    [IsoId("_ja46bTq3EeWZFYSPlduMhw")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader70.InterbankSettlementDate"/>
    [IsoId("_ja46bzq3EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader70.SettlementInformation"/>
    [IsoId("_ja46cTq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction4 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader70.PaymentTypeInformation"/>
    [IsoId("_ja46czq3EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader70.InstructingAgent"/>
    [IsoId("_ja46dTq3EeWZFYSPlduMhw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader70.InstructedAgent"/>
    [IsoId("_ja46dzq3EeWZFYSPlduMhw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
