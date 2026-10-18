// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader9"/>
[IsoId("_PtaZMNp-Ed-ak6NoX_4Aeg_-472629694")]
[DisplayName("Group Header")]
public partial record GroupHeader9
{
    /// <inheritdoc cref="IGroupHeader9.MessageIdentification"/>
    [IsoId("_PtaZMdp-Ed-ak6NoX_4Aeg_-1557438436")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader9.CreationDateTime"/>
    [IsoId("_PtaZMtp-Ed-ak6NoX_4Aeg_-1557438366")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader9.Authorisation"/>
    [IsoId("_PtaZM9p-Ed-ak6NoX_4Aeg_-1557438341")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader9.BatchBooking"/>
    [IsoId("_PtaZNNp-Ed-ak6NoX_4Aeg_-1557438016")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader9.NumberOfTransactions"/>
    [IsoId("_PtaZNdp-Ed-ak6NoX_4Aeg_-1557437981")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader9.ControlSum"/>
    [IsoId("_PtaZNtp-Ed-ak6NoX_4Aeg_-1557437903")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader9.GroupReversal"/>
    [IsoId("_PtaZN9p-Ed-ak6NoX_4Aeg_-1055967010")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader9.TotalReversedInterbankSettlementAmount"/>
    [IsoId("_PtaZONp-Ed-ak6NoX_4Aeg_-1557437826")]
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader9.InterbankSettlementDate"/>
    [IsoId("_PtaZOdp-Ed-ak6NoX_4Aeg_-1557437783")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader9.SettlementInformation"/>
    [IsoId("_PtjjINp-Ed-ak6NoX_4Aeg_1834386927")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader9.InstructingAgent"/>
    [IsoId("_PtjjIdp-Ed-ak6NoX_4Aeg_-471705044")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader9.InstructedAgent"/>
    [IsoId("_PtjjItp-Ed-ak6NoX_4Aeg_-471705523")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
