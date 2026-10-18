// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader38"/>
[IsoId("_P1J_8tp-Ed-ak6NoX_4Aeg_1809638367")]
[DisplayName("Group Header")]
public partial record GroupHeader38
{
    /// <inheritdoc cref="IGroupHeader38.MessageIdentification"/>
    [IsoId("_P1J_89p-Ed-ak6NoX_4Aeg_1809638369")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader38.CreationDateTime"/>
    [IsoId("_P1J_9Np-Ed-ak6NoX_4Aeg_1809638398")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader38.Authorisation"/>
    [IsoId("_P1J_9dp-Ed-ak6NoX_4Aeg_1809638700")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader38.BatchBooking"/>
    [IsoId("_P1J_9tp-Ed-ak6NoX_4Aeg_1809638731")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader38.NumberOfTransactions"/>
    [IsoId("_P1J_99p-Ed-ak6NoX_4Aeg_1809638792")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader38.ControlSum"/>
    [IsoId("_P1J_-Np-Ed-ak6NoX_4Aeg_1809638822")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader38.GroupReturn"/>
    [IsoId("_P1Tw8Np-Ed-ak6NoX_4Aeg_1809638853")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReturn { get; init; }

    /// <inheritdoc cref="IGroupHeader38.TotalReturnedInterbankSettlementAmount"/>
    [IsoId("_P1Tw8dp-Ed-ak6NoX_4Aeg_1809638884")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader38.InterbankSettlementDate"/>
    [IsoId("_P1Tw8tp-Ed-ak6NoX_4Aeg_1809638914")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader38.SettlementInformation"/>
    [IsoId("_P1Tw89p-Ed-ak6NoX_4Aeg_1809638946")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation13 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader38.InstructingAgent"/>
    [IsoId("_P1Tw9Np-Ed-ak6NoX_4Aeg_1809639236")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader38.InstructedAgent"/>
    [IsoId("_P1Tw9dp-Ed-ak6NoX_4Aeg_1809639255")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
