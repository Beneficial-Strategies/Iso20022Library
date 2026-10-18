// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction36"/>
[IsoId("_tLTMFFkyEeGeoaLUQk__nA_-226815089")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction36
{
    /// <inheritdoc cref="IPaymentTransaction36.ReversalIdentification"/>
    [IsoId("_tLc9EFkyEeGeoaLUQk__nA_-1110048376")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.OriginalInstructionIdentification"/>
    [IsoId("_tLc9EVkyEeGeoaLUQk__nA_-2107120729")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.OriginalEndToEndIdentification"/>
    [IsoId("_tLc9ElkyEeGeoaLUQk__nA_1190774214")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.OriginalTransactionIdentification"/>
    [IsoId("_tLc9E1kyEeGeoaLUQk__nA_193701861")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.OriginalClearingSystemReference"/>
    [IsoId("_tLc9FFkyEeGeoaLUQk__nA_-803370492")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.OriginalInterbankSettlementAmount"/>
    [IsoId("_tLmHAFkyEeGeoaLUQk__nA_-1800442845")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ReversedInterbankSettlementAmount"/>
    [IsoId("_tLmHAVkyEeGeoaLUQk__nA_1497452098")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.InterbankSettlementDate"/>
    [IsoId("_tLmHAlkyEeGeoaLUQk__nA_1383613032")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ReversedInstructedAmount"/>
    [IsoId("_tLmHA1kyEeGeoaLUQk__nA_386540679")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ExchangeRate"/>
    [IsoId("_tLmHBFkyEeGeoaLUQk__nA_-610531674")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.CompensationAmount"/>
    [IsoId("_tLv4AFkyEeGeoaLUQk__nA_-1607604027")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ChargeBearer"/>
    [IsoId("_tLv4AVkyEeGeoaLUQk__nA_1690290916")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ChargesInformation"/>
    [IsoId("_tLv4AlkyEeGeoaLUQk__nA_693218563")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction36.InstructingAgent"/>
    [IsoId("_tLv4A1kyEeGeoaLUQk__nA_-303853790")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.InstructedAgent"/>
    [IsoId("_tLv4BFkyEeGeoaLUQk__nA_-1300926143")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction36.ReversalReasonInformation"/>
    [IsoId("_tMMj8FkyEeGeoaLUQk__nA_1996968800")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction36.OriginalTransactionReference"/>
    [IsoId("_tMMj8VkyEeGeoaLUQk__nA_999896447")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }
}
