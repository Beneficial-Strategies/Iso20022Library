// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction44"/>
[IsoId("_TOBE4SHLEeK1OvoXgbVMNg")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction44
{
    /// <inheritdoc cref="IPaymentTransaction44.ReturnIdentification"/>
    [IsoId("_Tik_sSHLEeK1OvoXgbVMNg")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalGroupInformation"/>
    [IsoId("_Tik_tSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalInstructionIdentification"/>
    [IsoId("_Tik_vSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalEndToEndIdentification"/>
    [IsoId("_Tik_wSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalTransactionIdentification"/>
    [IsoId("_Tik_xSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalClearingSystemReference"/>
    [IsoId("_Tik_ySHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.OriginalInterbankSettlementAmount"/>
    [IsoId("_Tik_zSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ReturnedInterbankSettlementAmount"/>
    [IsoId("_Tik_0SHLEeK1OvoXgbVMNg")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.InterbankSettlementDate"/>
    [IsoId("_Tik_2SHLEeK1OvoXgbVMNg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ReturnedInstructedAmount"/>
    [IsoId("_Tik_4SHLEeK1OvoXgbVMNg")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ExchangeRate"/>
    [IsoId("_Tik_5SHLEeK1OvoXgbVMNg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.CompensationAmount"/>
    [IsoId("_Tik_7SHLEeK1OvoXgbVMNg")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ChargeBearer"/>
    [IsoId("_Tik_8SHLEeK1OvoXgbVMNg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ChargesInformation"/>
    [IsoId("_Tik_9SHLEeK1OvoXgbVMNg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction44.InstructingAgent"/>
    [IsoId("_Tik_-SHLEeK1OvoXgbVMNg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.InstructedAgent"/>
    [IsoId("_TilAASHLEeK1OvoXgbVMNg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.ReturnReasonInformation"/>
    [IsoId("_TilACSHLEeK1OvoXgbVMNg")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason1> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction44.OriginalTransactionReference"/>
    [IsoId("_TilADSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction44.SupplementaryData"/>
    [IsoId("_XNubuiHLEeK1OvoXgbVMNg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
