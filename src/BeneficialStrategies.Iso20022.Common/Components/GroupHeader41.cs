// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader41"/>
[IsoId("_P0aZFdp-Ed-ak6NoX_4Aeg_-586018147")]
[DisplayName("Group Header")]
public partial record GroupHeader41
{
    /// <inheritdoc cref="IGroupHeader41.MessageIdentification"/>
    [IsoId("_P0aZFtp-Ed-ak6NoX_4Aeg_-586018145")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader41.CreationDateTime"/>
    [IsoId("_P0aZF9p-Ed-ak6NoX_4Aeg_-586018094")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader41.Authorisation"/>
    [IsoId("_P0aZGNp-Ed-ak6NoX_4Aeg_-586018063")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader41.BatchBooking"/>
    [IsoId("_P0kKENp-Ed-ak6NoX_4Aeg_-586017815")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader41.NumberOfTransactions"/>
    [IsoId("_P0kKEdp-Ed-ak6NoX_4Aeg_-586017754")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader41.ControlSum"/>
    [IsoId("_P0kKEtp-Ed-ak6NoX_4Aeg_-586017723")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader41.GroupReversal"/>
    [IsoId("_P0kKE9p-Ed-ak6NoX_4Aeg_-586017693")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader41.TotalReversedInterbankSettlementAmount"/>
    [IsoId("_P0kKFNp-Ed-ak6NoX_4Aeg_-586017662")]
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader41.InterbankSettlementDate"/>
    [IsoId("_P0kKFdp-Ed-ak6NoX_4Aeg_-586017384")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader41.SettlementInformation"/>
    [IsoId("_P0kKFtp-Ed-ak6NoX_4Aeg_-586017260")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation13 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader41.InstructingAgent"/>
    [IsoId("_P0kKF9p-Ed-ak6NoX_4Aeg_-586017320")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader41.InstructedAgent"/>
    [IsoId("_P0kKGNp-Ed-ak6NoX_4Aeg_-586017291")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
