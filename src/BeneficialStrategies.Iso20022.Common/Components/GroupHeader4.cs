// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader4"/>
[IsoId("_Puc7Btp-Ed-ak6NoX_4Aeg_549642778")]
[DisplayName("Group Header")]
public partial record GroupHeader4
{
    /// <inheritdoc cref="IGroupHeader4.MessageIdentification"/>
    [IsoId("_Puc7B9p-Ed-ak6NoX_4Aeg_550565447")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader4.CreationDateTime"/>
    [IsoId("_Puc7CNp-Ed-ak6NoX_4Aeg_551487927")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader4.BatchBooking"/>
    [IsoId("_PumsANp-Ed-ak6NoX_4Aeg_552410536")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader4.NumberOfTransactions"/>
    [IsoId("_PumsAdp-Ed-ak6NoX_4Aeg_551489029")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader4.ControlSum"/>
    [IsoId("_PumsAtp-Ed-ak6NoX_4Aeg_551489943")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader4.TotalInterbankSettlementAmount"/>
    [IsoId("_PumsA9p-Ed-ak6NoX_4Aeg_552411579")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader4.InterbankSettlementDate"/>
    [IsoId("_PumsBNp-Ed-ak6NoX_4Aeg_552412829")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader4.SettlementInformation"/>
    [IsoId("_PumsBdp-Ed-ak6NoX_4Aeg_-1368923120")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader4.PaymentTypeInformation"/>
    [IsoId("_PumsBtp-Ed-ak6NoX_4Aeg_1441753936")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation5? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader4.InstructingAgent"/>
    [IsoId("_PumsB9p-Ed-ak6NoX_4Aeg_565340855")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader4.InstructedAgent"/>
    [IsoId("_PumsCNp-Ed-ak6NoX_4Aeg_567187943")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
