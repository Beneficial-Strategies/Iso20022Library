// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation27"/>
[IsoId("_P5VVUdp-Ed-ak6NoX_4Aeg_225114103")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation27
{
    /// <inheritdoc cref="IPaymentTransactionInformation27.ReturnIdentification"/>
    [IsoId("_P5VVUtp-Ed-ak6NoX_4Aeg_225114352")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalGroupInformation"/>
    [IsoId("_P5VVU9p-Ed-ak6NoX_4Aeg_225115792")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalInstructionIdentification"/>
    [IsoId("_P5VVVNp-Ed-ak6NoX_4Aeg_225114412")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalEndToEndIdentification"/>
    [IsoId("_P5VVVdp-Ed-ak6NoX_4Aeg_225114473")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalTransactionIdentification"/>
    [IsoId("_P5VVVtp-Ed-ak6NoX_4Aeg_225114783")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalClearingSystemReference"/>
    [IsoId("_P5VVV9p-Ed-ak6NoX_4Aeg_537745721")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalInterbankSettlementAmount"/>
    [IsoId("_P5VVWNp-Ed-ak6NoX_4Aeg_225114813")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ReturnedInterbankSettlementAmount"/>
    [IsoId("_P5VVWdp-Ed-ak6NoX_4Aeg_225115028")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.InterbankSettlementDate"/>
    [IsoId("_P5efQNp-Ed-ak6NoX_4Aeg_225114874")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ReturnedInstructedAmount"/>
    [IsoId("_P5efQdp-Ed-ak6NoX_4Aeg_225115050")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ExchangeRate"/>
    [IsoId("_P5efQtp-Ed-ak6NoX_4Aeg_225114936")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.CompensationAmount"/>
    [IsoId("_P5efQ9p-Ed-ak6NoX_4Aeg_225114905")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ChargeBearer"/>
    [IsoId("_P5efRNp-Ed-ak6NoX_4Aeg_225114966")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ChargesInformation"/>
    [IsoId("_P5efRdp-Ed-ak6NoX_4Aeg_225115360")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation27.InstructingAgent"/>
    [IsoId("_P5efRtp-Ed-ak6NoX_4Aeg_225115421")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.InstructedAgent"/>
    [IsoId("_P5efR9p-Ed-ak6NoX_4Aeg_225115452")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation27.ReturnReasonInformation"/>
    [IsoId("_P5efSNp-Ed-ak6NoX_4Aeg_225115761")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<ReturnReasonInformation9> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation27.OriginalTransactionReference"/>
    [IsoId("_P5efSdp-Ed-ak6NoX_4Aeg_225115329")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
