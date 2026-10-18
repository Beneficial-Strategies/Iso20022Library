// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader72"/>
[IsoId("_lnRSeTq3EeWZFYSPlduMhw")]
[DisplayName("Group Header")]
public partial record GroupHeader72
{
    /// <inheritdoc cref="IGroupHeader72.MessageIdentification"/>
    [IsoId("_lunQhzq3EeWZFYSPlduMhw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader72.CreationDateTime"/>
    [IsoId("_lunQiTq3EeWZFYSPlduMhw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader72.Authorisation"/>
    [IsoId("_lunQizq3EeWZFYSPlduMhw")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader72.BatchBooking"/>
    [IsoId("_lunQjTq3EeWZFYSPlduMhw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader72.NumberOfTransactions"/>
    [IsoId("_lunQjzq3EeWZFYSPlduMhw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader72.ControlSum"/>
    [IsoId("_lunQkTq3EeWZFYSPlduMhw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader72.GroupReturn"/>
    [IsoId("_lunQkzq3EeWZFYSPlduMhw")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReturn { get; init; }

    /// <inheritdoc cref="IGroupHeader72.TotalReturnedInterbankSettlementAmount"/>
    [IsoId("_lunQlTq3EeWZFYSPlduMhw")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader72.InterbankSettlementDate"/>
    [IsoId("_lunQlzq3EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader72.SettlementInformation"/>
    [IsoId("_lunQmTq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction4 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader72.InstructingAgent"/>
    [IsoId("_lunQmzq3EeWZFYSPlduMhw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader72.InstructedAgent"/>
    [IsoId("_lunQnTq3EeWZFYSPlduMhw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
