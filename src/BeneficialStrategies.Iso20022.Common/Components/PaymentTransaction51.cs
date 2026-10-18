// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction51"/>
[IsoId("_I9FKERmJEeS15voCZPa1ZA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction51
{
    /// <inheritdoc cref="IPaymentTransaction51.ReversalIdentification"/>
    [IsoId("_JWXz9xmJEeS15voCZPa1ZA")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalGroupInformation"/>
    [IsoId("_Vo0SAWQpEeST4ZKz9hIHPA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalInstructionIdentification"/>
    [IsoId("_JWXz-RmJEeS15voCZPa1ZA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalEndToEndIdentification"/>
    [IsoId("_JWXz-xmJEeS15voCZPa1ZA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalTransactionIdentification"/>
    [IsoId("_JWXz_RmJEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalClearingSystemReference"/>
    [IsoId("_JWXz_xmJEeS15voCZPa1ZA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.OriginalInterbankSettlementAmount"/>
    [IsoId("_JWX0ARmJEeS15voCZPa1ZA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ReversedInterbankSettlementAmount"/>
    [IsoId("_JWX0AxmJEeS15voCZPa1ZA")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.InterbankSettlementDate"/>
    [IsoId("_JWX0BRmJEeS15voCZPa1ZA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.SettlementPriority"/>
    [IsoId("_4oZaoRmIEeS15voCZPa1ZA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ReversedInstructedAmount"/>
    [IsoId("_JWX0BxmJEeS15voCZPa1ZA")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ExchangeRate"/>
    [IsoId("_JWX0CRmJEeS15voCZPa1ZA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.CompensationAmount"/>
    [IsoId("_JWX0CxmJEeS15voCZPa1ZA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ChargeBearer"/>
    [IsoId("_JWX0DRmJEeS15voCZPa1ZA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ChargesInformation"/>
    [IsoId("_JWX0DxmJEeS15voCZPa1ZA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction51.InstructingAgent"/>
    [IsoId("_JWX0ERmJEeS15voCZPa1ZA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.InstructedAgent"/>
    [IsoId("_JWX0ExmJEeS15voCZPa1ZA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.ReversalReasonInformation"/>
    [IsoId("_JWX0FRmJEeS15voCZPa1ZA")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction51.OriginalTransactionReference"/>
    [IsoId("_JWX0FxmJEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference20? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction51.SupplementaryData"/>
    [IsoId("_JWX0GRmJEeS15voCZPa1ZA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
