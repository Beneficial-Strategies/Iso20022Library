// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader33"/>
[IsoId("_P0HeKtp-Ed-ak6NoX_4Aeg_2014335912")]
[DisplayName("Group Header")]
public partial record GroupHeader33
{
    /// <inheritdoc cref="IGroupHeader33.MessageIdentification"/>
    [IsoId("_P0QoENp-Ed-ak6NoX_4Aeg_2014335914")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader33.CreationDateTime"/>
    [IsoId("_P0QoEdp-Ed-ak6NoX_4Aeg_2014335973")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader33.BatchBooking"/>
    [IsoId("_P0QoEtp-Ed-ak6NoX_4Aeg_2014336004")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader33.NumberOfTransactions"/>
    [IsoId("_P0QoE9p-Ed-ak6NoX_4Aeg_2014336282")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader33.ControlSum"/>
    [IsoId("_P0QoFNp-Ed-ak6NoX_4Aeg_2014336313")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader33.TotalInterbankSettlementAmount"/>
    [IsoId("_P0QoFdp-Ed-ak6NoX_4Aeg_2014336344")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader33.InterbankSettlementDate"/>
    [IsoId("_P0QoFtp-Ed-ak6NoX_4Aeg_2014336397")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader33.SettlementInformation"/>
    [IsoId("_P0QoF9p-Ed-ak6NoX_4Aeg_2014336799")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation13 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader33.PaymentTypeInformation"/>
    [IsoId("_P0QoGNp-Ed-ak6NoX_4Aeg_2014336690")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader33.InstructingAgent"/>
    [IsoId("_P0aZENp-Ed-ak6NoX_4Aeg_2014336707")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader33.InstructedAgent"/>
    [IsoId("_P0aZEdp-Ed-ak6NoX_4Aeg_2014336768")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
