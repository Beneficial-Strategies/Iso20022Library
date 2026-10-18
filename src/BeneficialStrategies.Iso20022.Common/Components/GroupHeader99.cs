// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader99"/>
[IsoId("_g-JF4dcZEeqRFcf2R4bPBw")]
[DisplayName("Group Header")]
public partial record GroupHeader99
{
    /// <inheritdoc cref="IGroupHeader99.MessageIdentification"/>
    [IsoId("_g_r-B9cZEeqRFcf2R4bPBw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader99.CreationDateTime"/>
    [IsoId("_g_r-CdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader99.Authorisation"/>
    [IsoId("_g_r-C9cZEeqRFcf2R4bPBw")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader99.BatchBooking"/>
    [IsoId("_g_r-DdcZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader99.NumberOfTransactions"/>
    [IsoId("_g_r-D9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader99.ControlSum"/>
    [IsoId("_g_r-EdcZEeqRFcf2R4bPBw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader99.GroupReturn"/>
    [IsoId("_g_r-E9cZEeqRFcf2R4bPBw")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReturn { get; init; }

    /// <inheritdoc cref="IGroupHeader99.TotalReturnedInterbankSettlementAmount"/>
    [IsoId("_g_r-FdcZEeqRFcf2R4bPBw")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader99.InterbankSettlementDate"/>
    [IsoId("_g_r-F9cZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader99.SettlementInformation"/>
    [IsoId("_g_r-GdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction11 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader99.PaymentTypeInformation"/>
    [IsoId("_uH_acNitEeq5MfBBxQig1Q")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader99.InstructingAgent"/>
    [IsoId("_g_r-G9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader99.InstructedAgent"/>
    [IsoId("_g_r-HdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }
}
