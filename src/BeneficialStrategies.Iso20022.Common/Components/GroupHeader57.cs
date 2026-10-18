// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader57"/>
[IsoId("_s9lgMFkyEeGeoaLUQk__nA_-1173772128")]
[DisplayName("Group Header")]
public partial record GroupHeader57
{
    /// <inheritdoc cref="IGroupHeader57.MessageIdentification"/>
    [IsoId("_s9lgMVkyEeGeoaLUQk__nA_2010283749")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader57.CreationDateTime"/>
    [IsoId("_s9lgMlkyEeGeoaLUQk__nA_512425699")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader57.Authorisation"/>
    [IsoId("_s9lgM1kyEeGeoaLUQk__nA_1289179993")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader57.BatchBooking"/>
    [IsoId("_s9vRMFkyEeGeoaLUQk__nA_-72758772")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader57.NumberOfTransactions"/>
    [IsoId("_s9vRMVkyEeGeoaLUQk__nA_-1953064412")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader57.ControlSum"/>
    [IsoId("_s9vRMlkyEeGeoaLUQk__nA_206510370")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader57.GroupReversal"/>
    [IsoId("_s9vRM1kyEeGeoaLUQk__nA_-1673795270")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader57.TotalReversedInterbankSettlementAmount"/>
    [IsoId("_s9vRNFkyEeGeoaLUQk__nA_-865494689")]
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader57.InterbankSettlementDate"/>
    [IsoId("_s95CMFkyEeGeoaLUQk__nA_1549166967")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader57.SettlementInformation"/>
    [IsoId("_s95CMVkyEeGeoaLUQk__nA_-422506197")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader57.InstructingAgent"/>
    [IsoId("_s-CMIFkyEeGeoaLUQk__nA_1744633256")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader57.InstructedAgent"/>
    [IsoId("_s-CMIVkyEeGeoaLUQk__nA_-1472313702")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
