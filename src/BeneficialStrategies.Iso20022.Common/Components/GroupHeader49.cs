// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader49"/>
[IsoId("_s4rLAlkyEeGeoaLUQk__nA_-650190179")]
[DisplayName("Group Header")]
public partial record GroupHeader49
{
    /// <inheritdoc cref="IGroupHeader49.MessageIdentification"/>
    [IsoId("_s4rLA1kyEeGeoaLUQk__nA_1977894367")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader49.CreationDateTime"/>
    [IsoId("_s4-F8FkyEeGeoaLUQk__nA_-1790076986")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader49.BatchBooking"/>
    [IsoId("_s5RA4FkyEeGeoaLUQk__nA_-1013322692")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader49.NumberOfTransactions"/>
    [IsoId("_s5RA4VkyEeGeoaLUQk__nA_-1684866988")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader49.ControlSum"/>
    [IsoId("_s5RA4lkyEeGeoaLUQk__nA_729794668")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader49.TotalInterbankSettlementAmount"/>
    [IsoId("_s5RA41kyEeGeoaLUQk__nA_-1695965765")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IGroupHeader49.InterbankSettlementDate"/>
    [IsoId("_s5ax4FkyEeGeoaLUQk__nA_718695891")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IGroupHeader49.SettlementInformation"/>
    [IsoId("_s5j70FkyEeGeoaLUQk__nA_-338154809")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction1 SettlementInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader49.PaymentTypeInformation"/>
    [IsoId("_s5j70VkyEeGeoaLUQk__nA_-2129026367")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IGroupHeader49.InstructingAgent"/>
    [IsoId("_s5ts0FkyEeGeoaLUQk__nA_-1368261214")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader49.InstructedAgent"/>
    [IsoId("_s5ts0VkyEeGeoaLUQk__nA_2091940249")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
