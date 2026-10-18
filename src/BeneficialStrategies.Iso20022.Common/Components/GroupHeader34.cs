// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader34"/>
[IsoId("_P0tUCdp-Ed-ak6NoX_4Aeg_1899367216")]
[DisplayName("Group Header")]
public partial record GroupHeader34
{
    /// <inheritdoc cref="IGroupHeader34.MessageIdentification"/>
    [IsoId("_P0tUCtp-Ed-ak6NoX_4Aeg_1899367465")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader34.CreationDateTime"/>
    [IsoId("_P0tUC9p-Ed-ak6NoX_4Aeg_1899367518")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader34.Authorisation"/>
    [IsoId("_P0tUDNp-Ed-ak6NoX_4Aeg_1899367549")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader34.BatchBooking"/>
    [IsoId("_P0tUDdp-Ed-ak6NoX_4Aeg_1900287589")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader34.NumberOfTransactions"/>
    [IsoId("_P0tUDtp-Ed-ak6NoX_4Aeg_1900287620")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader34.ControlSum"/>
    [IsoId("_P03FANp-Ed-ak6NoX_4Aeg_1900287673")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader34.TotalInterbankSettlementAmount"/>
    [IsoId("_P03FAdp-Ed-ak6NoX_4Aeg_1900287682")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader34.InterbankSettlementDate"/>
    [IsoId("_P03FAtp-Ed-ak6NoX_4Aeg_1900287704")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader34.SettlementInformation"/>
    [IsoId("_P03FA9p-Ed-ak6NoX_4Aeg_1900287780")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation14 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader34.PaymentTypeInformation"/>
    [IsoId("_P03FBNp-Ed-ak6NoX_4Aeg_1900288105")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader34.InstructingAgent"/>
    [IsoId("_P03FBdp-Ed-ak6NoX_4Aeg_1900287796")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader34.InstructedAgent"/>
    [IsoId("_P03FBtp-Ed-ak6NoX_4Aeg_1900287858")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
