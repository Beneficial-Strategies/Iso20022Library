// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader54"/>
[IsoId("_s7gckVkyEeGeoaLUQk__nA_-1547025335")]
[DisplayName("Group Header")]
public partial record GroupHeader54
{
    /// <inheritdoc cref="IGroupHeader54.MessageIdentification"/>
    [IsoId("_s7gcklkyEeGeoaLUQk__nA_457126142")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader54.CreationDateTime"/>
    [IsoId("_s7gck1kyEeGeoaLUQk__nA_984122085")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader54.Authorisation"/>
    [IsoId("_s7gclFkyEeGeoaLUQk__nA_624146037")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader54.BatchBooking"/>
    [IsoId("_s7pmgFkyEeGeoaLUQk__nA_-1256159603")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader54.NumberOfTransactions"/>
    [IsoId("_s7pmgVkyEeGeoaLUQk__nA_1927896274")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader54.ControlSum"/>
    [IsoId("_s7pmglkyEeGeoaLUQk__nA_1938124897")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader54.GroupReturn"/>
    [IsoId("_s7zXgFkyEeGeoaLUQk__nA_1046262542")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReturn { get; init; }

    /// <inheritdoc cref="IGroupHeader54.TotalReturnedInterbankSettlementAmount"/>
    [IsoId("_s7zXgVkyEeGeoaLUQk__nA_-834043098")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader54.InterbankSettlementDate"/>
    [IsoId("_s7zXglkyEeGeoaLUQk__nA_-1944954517")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader54.SettlementInformation"/>
    [IsoId("_s7zXg1kyEeGeoaLUQk__nA_-963694316")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader54.InstructingAgent"/>
    [IsoId("_s79IgFkyEeGeoaLUQk__nA_-974793093")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader54.InstructedAgent"/>
    [IsoId("_s8GScFkyEeGeoaLUQk__nA_439443529")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
