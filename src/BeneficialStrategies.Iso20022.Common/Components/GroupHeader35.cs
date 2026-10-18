// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader35"/>
[IsoId("_Pz9tKNp-Ed-ak6NoX_4Aeg_-1416527618")]
[DisplayName("Group Header")]
public partial record GroupHeader35
{
    /// <inheritdoc cref="IGroupHeader35.MessageIdentification"/>
    [IsoId("_Pz9tKdp-Ed-ak6NoX_4Aeg_-1416527609")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader35.CreationDateTime"/>
    [IsoId("_Pz9tKtp-Ed-ak6NoX_4Aeg_-1416527557")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader35.BatchBooking"/>
    [IsoId("_Pz9tK9p-Ed-ak6NoX_4Aeg_-1416527496")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader35.NumberOfTransactions"/>
    [IsoId("_Pz9tLNp-Ed-ak6NoX_4Aeg_-1416527217")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader35.ControlSum"/>
    [IsoId("_P0HeINp-Ed-ak6NoX_4Aeg_-1416527156")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader35.TotalInterbankSettlementAmount"/>
    [IsoId("_P0HeIdp-Ed-ak6NoX_4Aeg_-1416527095")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader35.InterbankSettlementDate"/>
    [IsoId("_P0HeItp-Ed-ak6NoX_4Aeg_-1416527064")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader35.SettlementInformation"/>
    [IsoId("_P0HeI9p-Ed-ak6NoX_4Aeg_-1416527002")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation13 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader35.PaymentTypeInformation"/>
    [IsoId("_P0HeJNp-Ed-ak6NoX_4Aeg_-1416526662")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation23? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader35.InstructingAgent"/>
    [IsoId("_P0HeJdp-Ed-ak6NoX_4Aeg_-1416526693")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader35.InstructedAgent"/>
    [IsoId("_P0HeJtp-Ed-ak6NoX_4Aeg_-1416526971")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
