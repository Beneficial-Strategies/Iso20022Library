// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction81"/>
[IsoId("_VKTHIWXlEeap-P22vGV91g")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction81
{
    /// <inheritdoc cref="IPaymentTransaction81.ReversalIdentification"/>
    [IsoId("_VWH8x2XlEeap-P22vGV91g")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalGroupInformation"/>
    [IsoId("_VWH8yWXlEeap-P22vGV91g")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalInstructionIdentification"/>
    [IsoId("_VWH8y2XlEeap-P22vGV91g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalEndToEndIdentification"/>
    [IsoId("_VWH8zWXlEeap-P22vGV91g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalTransactionIdentification"/>
    [IsoId("_VWH8z2XlEeap-P22vGV91g")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalClearingSystemReference"/>
    [IsoId("_VWH80WXlEeap-P22vGV91g")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.OriginalInterbankSettlementAmount"/>
    [IsoId("_VWH802XlEeap-P22vGV91g")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ReversedInterbankSettlementAmount"/>
    [IsoId("_VWH81WXlEeap-P22vGV91g")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.InterbankSettlementDate"/>
    [IsoId("_VWH812XlEeap-P22vGV91g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.SettlementPriority"/>
    [IsoId("_VWH82WXlEeap-P22vGV91g")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ReversedInstructedAmount"/>
    [IsoId("_VWH822XlEeap-P22vGV91g")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ExchangeRate"/>
    [IsoId("_VWH83WXlEeap-P22vGV91g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.CompensationAmount"/>
    [IsoId("_VWH832XlEeap-P22vGV91g")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ChargeBearer"/>
    [IsoId("_VWH84WXlEeap-P22vGV91g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ChargesInformation"/>
    [IsoId("_VWH842XlEeap-P22vGV91g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction81.InstructingAgent"/>
    [IsoId("_VWH85WXlEeap-P22vGV91g")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.InstructedAgent"/>
    [IsoId("_VWH852XlEeap-P22vGV91g")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.ReversalReasonInformation"/>
    [IsoId("_VWH86WXlEeap-P22vGV91g")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction81.OriginalTransactionReference"/>
    [IsoId("_VWH862XlEeap-P22vGV91g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference24? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction81.SupplementaryData"/>
    [IsoId("_VWH87WXlEeap-P22vGV91g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
