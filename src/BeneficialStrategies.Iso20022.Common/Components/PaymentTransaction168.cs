// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction168"/>
[Description(@"Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.")]
[IsoId("fccbf899-2453-42a4-ac0e-594ac02c735b")]
[DisplayName("Payment Transaction168")]
public partial record PaymentTransaction168
{
    /// <inheritdoc cref="IPaymentTransaction168.ReturnIdentification"/>
    [IsoId("4c987f69-9a7b-4f81-83c5-b0378bd43dd3")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalGroupInformation"/>
    [IsoId("4946ad7b-d90f-40d2-92d2-f8e2996c19cb")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalInstructionIdentification"/>
    [IsoId("cad28827-3b8e-496d-b7e4-b44348fceee2")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalEndToEndIdentification"/>
    [IsoId("0cd7bfd0-ed9e-470a-85b8-035e162b766e")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalTransactionIdentification"/>
    [IsoId("276721ce-d648-4f9d-9e41-6685b356d9c2")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalUETR"/>
    [IsoId("93a93262-2766-4b3e-bb9e-46ff5a9a2242")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalClearingSystemReference"/>
    [IsoId("ce62726f-ca2f-46a1-b254-b53a323e1407")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalInterbankSettlementAmount"/>
    [IsoId("79258e90-4d9c-4e19-a647-16b7a0bcd638")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.OriginalInterbankSettlementDate"/>
    [IsoId("33131e4e-9c19-4e58-9c67-956b6629e43c")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.PaymentTypeInformation"/>
    [IsoId("4f0b0c43-8dbb-4180-b996-469f0af2e03a")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ReturnedInterbankSettlementAmount"/>
    [IsoId("369bcaf9-9cba-4aab-82e9-6b6ef9fe43a8")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.InterbankSettlementDate"/>
    [IsoId("9b7c1ccb-7bb5-4480-9a32-32ff02e77181")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.SettlementPriority"/>
    [IsoId("172b9204-ec43-48da-94c2-c0be38c581c4")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.SettlementTimeIndication"/>
    [IsoId("c2579d35-e28a-4c49-a82c-cefcded3eb3b")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.SettlementTimeRequest"/>
    [IsoId("b1e40a94-ab4d-41a9-a09e-681fbe16221d")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ReturnedInstructedAmount"/>
    [IsoId("aeb90ce5-0f12-4ebf-a575-d8f1e089ce76")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ExchangeRate"/>
    [IsoId("33696d94-acd9-48e8-a770-205ca8a203c0")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.AgreedRate"/>
    [IsoId("3ea28b9b-1b0b-4a7d-8bbd-ce302deae8a5")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public CurrencyExchange26? AgreedRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.CompensationAmount"/>
    [IsoId("b6bf18ae-de7e-412a-a9dd-a46b7f3c6bde")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ChargeBearer"/>
    [IsoId("736eb249-1277-411b-9f1f-42a4e35c2409")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ChargesInformation"/>
    [IsoId("152678df-a752-452b-984e-f3db1c93d499")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction168.ClearingSystemReference"/>
    [IsoId("98cc7917-ce35-475c-83be-adf3d36b55b8")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.InstructingAgent"/>
    [IsoId("6c18325d-111b-418c-8c63-673d125abb24")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.InstructedAgent"/>
    [IsoId("b8ad727b-1cf4-4fb7-886e-588a33249c9b")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ReturnChain"/>
    [IsoId("a90b593c-36a1-4a18-ba00-acbbb0049a2c")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties11? ReturnChain { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.ReturnReasonInformation"/>
    [IsoId("39cbcde2-104b-497b-9cb1-50899d277d03")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason7> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction168.OriginalTransactionReference"/>
    [IsoId("725431dc-719c-4af2-a96a-ed3ed23a9272")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference45? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction168.SupplementaryData"/>
    [IsoId("2e114227-40f7-49c5-b025-24b9ab3692b0")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
