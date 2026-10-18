// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader51"/>
[IsoId("_s6UJw1kyEeGeoaLUQk__nA_37863884")]
[DisplayName("Group Header")]
public partial record GroupHeader51
{
    /// <inheritdoc cref="IGroupHeader51.MessageIdentification"/>
    [IsoId("_s6dTsFkyEeGeoaLUQk__nA_-1073047535")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader51.CreationDateTime"/>
    [IsoId("_s6dTsVkyEeGeoaLUQk__nA_642786800")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader51.BatchBooking"/>
    [IsoId("_s6dTslkyEeGeoaLUQk__nA_1169782743")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader51.NumberOfTransactions"/>
    [IsoId("_s6dTs1kyEeGeoaLUQk__nA_-801923330")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader51.ControlSum"/>
    [IsoId("_s6nEsFkyEeGeoaLUQk__nA_1612738326")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader51.TotalInterbankSettlementAmount"/>
    [IsoId("_s6wOoFkyEeGeoaLUQk__nA_1025241908")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader51.InterbankSettlementDate"/>
    [IsoId("_s6wOoVkyEeGeoaLUQk__nA_-855063732")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader51.SettlementInformation"/>
    [IsoId("_s6wOolkyEeGeoaLUQk__nA_2103262246")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader51.PaymentTypeInformation"/>
    [IsoId("_s6wOo1kyEeGeoaLUQk__nA_1688836374")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader51.InstructingAgent"/>
    [IsoId("_s6wOpFkyEeGeoaLUQk__nA_-1081885637")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader51.InstructedAgent"/>
    [IsoId("_s65_oFkyEeGeoaLUQk__nA_-321120484")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
