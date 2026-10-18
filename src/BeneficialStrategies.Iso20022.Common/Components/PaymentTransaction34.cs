// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction34"/>
[IsoId("_tMpP41kyEeGeoaLUQk__nA_1650052580")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction34
{
    /// <inheritdoc cref="IPaymentTransaction34.ReturnIdentification"/>
    [IsoId("_tMpP5FkyEeGeoaLUQk__nA_1536213514")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalGroupInformation"/>
    [IsoId("_tMyZ0FkyEeGeoaLUQk__nA_539141161")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalInstructionIdentification"/>
    [IsoId("_tMyZ0VkyEeGeoaLUQk__nA_-457931192")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalEndToEndIdentification"/>
    [IsoId("_tMyZ0lkyEeGeoaLUQk__nA_-1455003545")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalTransactionIdentification"/>
    [IsoId("_tMyZ01kyEeGeoaLUQk__nA_1842891398")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalClearingSystemReference"/>
    [IsoId("_tMyZ1FkyEeGeoaLUQk__nA_845819045")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.OriginalInterbankSettlementAmount"/>
    [IsoId("_tM8K0FkyEeGeoaLUQk__nA_-151253308")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ReturnedInterbankSettlementAmount"/>
    [IsoId("_tM8K0VkyEeGeoaLUQk__nA_-1148325661")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.InterbankSettlementDate"/>
    [IsoId("_tM8K0lkyEeGeoaLUQk__nA_-2031558948")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ReturnedInstructedAmount"/>
    [IsoId("_tM8K01kyEeGeoaLUQk__nA_1266335995")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ExchangeRate"/>
    [IsoId("_tM8K1FkyEeGeoaLUQk__nA_269263642")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.CompensationAmount"/>
    [IsoId("_tNFUwFkyEeGeoaLUQk__nA_-727808711")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ChargeBearer"/>
    [IsoId("_tNFUwVkyEeGeoaLUQk__nA_-1724881064")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ChargesInformation"/>
    [IsoId("_tNFUwlkyEeGeoaLUQk__nA_1573013879")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction34.InstructingAgent"/>
    [IsoId("_tNFUw1kyEeGeoaLUQk__nA_575941526")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.InstructedAgent"/>
    [IsoId("_tNFUxFkyEeGeoaLUQk__nA_-421130827")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction34.ReturnReasonInformation"/>
    [IsoId("_tNPFwFkyEeGeoaLUQk__nA_-1418203180")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason1> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction34.OriginalTransactionReference"/>
    [IsoId("_tNPFwVkyEeGeoaLUQk__nA_1879691763")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }
}
