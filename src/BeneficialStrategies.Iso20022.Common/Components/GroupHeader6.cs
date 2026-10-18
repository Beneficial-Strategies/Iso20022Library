// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader6"/>
[IsoId("_PuKAENp-Ed-ak6NoX_4Aeg_-1660287802")]
[DisplayName("Group Header")]
public partial record GroupHeader6
{
    /// <inheritdoc cref="IGroupHeader6.MessageIdentification"/>
    [IsoId("_PuKAEdp-Ed-ak6NoX_4Aeg_-1660287533")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader6.CreationDateTime"/>
    [IsoId("_PuKAEtp-Ed-ak6NoX_4Aeg_-1660287413")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader6.Authorisation"/>
    [IsoId("_PuKAE9p-Ed-ak6NoX_4Aeg_-1660287378")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader6.BatchBooking"/>
    [IsoId("_PuKAFNp-Ed-ak6NoX_4Aeg_-1660287112")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader6.NumberOfTransactions"/>
    [IsoId("_PuKAFdp-Ed-ak6NoX_4Aeg_-1660287069")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader6.ControlSum"/>
    [IsoId("_PuKAFtp-Ed-ak6NoX_4Aeg_-1660287026")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader6.GroupReturn"/>
    [IsoId("_PuKAF9p-Ed-ak6NoX_4Aeg_1838509189")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReturn { get; init; }

    /// <inheritdoc cref="IGroupHeader6.TotalReturnedInterbankSettlementAmount"/>
    [IsoId("_PuKAGNp-Ed-ak6NoX_4Aeg_-1660286966")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader6.InterbankSettlementDate"/>
    [IsoId("_PuKAGdp-Ed-ak6NoX_4Aeg_-1660286931")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader6.SettlementInformation"/>
    [IsoId("_PuTKANp-Ed-ak6NoX_4Aeg_80997908")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader6.InstructingAgent"/>
    [IsoId("_PuTKAdp-Ed-ak6NoX_4Aeg_-1660286523")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader6.InstructedAgent"/>
    [IsoId("_PuTKAtp-Ed-ak6NoX_4Aeg_-1660286557")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
