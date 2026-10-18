// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader3"/>
[IsoId("_Puv189p-Ed-ak6NoX_4Aeg_1445763661")]
[DisplayName("Group Header")]
public partial record GroupHeader3
{
    /// <inheritdoc cref="IGroupHeader3.MessageIdentification"/>
    [IsoId("_Puv19Np-Ed-ak6NoX_4Aeg_1445763680")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader3.CreationDateTime"/>
    [IsoId("_Puv19dp-Ed-ak6NoX_4Aeg_1445763799")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader3.Authorisation"/>
    [IsoId("_Puv19tp-Ed-ak6NoX_4Aeg_1445764082")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader3.BatchBooking"/>
    [IsoId("_Puv199p-Ed-ak6NoX_4Aeg_1445764124")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader3.NumberOfTransactions"/>
    [IsoId("_Puv1-Np-Ed-ak6NoX_4Aeg_1445764159")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader3.ControlSum"/>
    [IsoId("_Puv1-dp-Ed-ak6NoX_4Aeg_-1932144351")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader3.TotalInterbankSettlementAmount"/>
    [IsoId("_Puv1-tp-Ed-ak6NoX_4Aeg_1445764177")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader3.InterbankSettlementDate"/>
    [IsoId("_Pu5m8Np-Ed-ak6NoX_4Aeg_1445764262")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader3.SettlementInformation"/>
    [IsoId("_Pu5m8dp-Ed-ak6NoX_4Aeg_-1429748960")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation2 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader3.PaymentTypeInformation"/>
    [IsoId("_Pu5m8tp-Ed-ak6NoX_4Aeg_-454582771")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation4? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader3.InstructingAgent"/>
    [IsoId("_Pu5m89p-Ed-ak6NoX_4Aeg_1445764610")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader3.InstructedAgent"/>
    [IsoId("_Pu5m9Np-Ed-ak6NoX_4Aeg_1445764341")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
