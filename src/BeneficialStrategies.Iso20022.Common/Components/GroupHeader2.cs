// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader2"/>
[IsoId("_Pu5m-Np-Ed-ak6NoX_4Aeg_1836538935")]
[DisplayName("Group Header")]
public partial record GroupHeader2
{
    /// <inheritdoc cref="IGroupHeader2.MessageIdentification"/>
    [IsoId("_Pu5m-dp-Ed-ak6NoX_4Aeg_1983380232")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader2.CreationDateTime"/>
    [IsoId("_Pu5m-tp-Ed-ak6NoX_4Aeg_2024935405")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader2.BatchBooking"/>
    [IsoId("_PvCw4Np-Ed-ak6NoX_4Aeg_2051718894")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader2.NumberOfTransactions"/>
    [IsoId("_PvCw4dp-Ed-ak6NoX_4Aeg_-739754788")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader2.ControlSum"/>
    [IsoId("_PvCw4tp-Ed-ak6NoX_4Aeg_547367153")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader2.TotalInterbankSettlementAmount"/>
    [IsoId("_PvCw49p-Ed-ak6NoX_4Aeg_65287942")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader2.InterbankSettlementDate"/>
    [IsoId("_PvCw5Np-Ed-ak6NoX_4Aeg_-185452988")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader2.SettlementInformation"/>
    [IsoId("_PvCw5dp-Ed-ak6NoX_4Aeg_1600410984")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader2.PaymentTypeInformation"/>
    [IsoId("_PvCw5tp-Ed-ak6NoX_4Aeg_-342847539")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation3? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader2.InstructingAgent"/>
    [IsoId("_PvCw59p-Ed-ak6NoX_4Aeg_1511874180")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader2.InstructedAgent"/>
    [IsoId("_PvCw6Np-Ed-ak6NoX_4Aeg_1757529426")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
