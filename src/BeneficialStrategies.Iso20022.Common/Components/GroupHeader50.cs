// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader50"/>
[IsoId("_s53d0FkyEeGeoaLUQk__nA_1710000299")]
[DisplayName("Group Header")]
public partial record GroupHeader50
{
    /// <inheritdoc cref="IGroupHeader50.MessageIdentification"/>
    [IsoId("_s53d0VkyEeGeoaLUQk__nA_-424500861")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader50.CreationDateTime"/>
    [IsoId("_s53d0lkyEeGeoaLUQk__nA_102495082")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader50.Authorisation"/>
    [IsoId("_s53d01kyEeGeoaLUQk__nA_-1558277363")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader50.BatchBooking"/>
    [IsoId("_s6AnwFkyEeGeoaLUQk__nA_856384293")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader50.NumberOfTransactions"/>
    [IsoId("_s6AnwVkyEeGeoaLUQk__nA_-1569376140")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader50.ControlSum"/>
    [IsoId("_s6AnwlkyEeGeoaLUQk__nA_845285516")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader50.TotalInterbankSettlementAmount"/>
    [IsoId("_s6Anw1kyEeGeoaLUQk__nA_548614403")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader50.InterbankSettlementDate"/>
    [IsoId("_s6AnxFkyEeGeoaLUQk__nA_1075610346")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader50.SettlementInformation"/>
    [IsoId("_s6KYwFkyEeGeoaLUQk__nA_715634298")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction2 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader50.PaymentTypeInformation"/>
    [IsoId("_s6KYwVkyEeGeoaLUQk__nA_301208426")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader50.InstructingAgent"/>
    [IsoId("_s6KYwlkyEeGeoaLUQk__nA_1352341498")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader50.InstructedAgent"/>
    [IsoId("_s6UJwFkyEeGeoaLUQk__nA_1008781041")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
