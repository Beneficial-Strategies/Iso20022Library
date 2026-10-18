// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction50"/>
[IsoId("_hLYzERmHEeS15voCZPa1ZA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction50
{
    /// <inheritdoc cref="IPaymentTransaction50.ReturnIdentification"/>
    [IsoId("_ha3ZiRmHEeS15voCZPa1ZA")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalGroupInformation"/>
    [IsoId("_ha3ZixmHEeS15voCZPa1ZA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalInstructionIdentification"/>
    [IsoId("_ha3ZjRmHEeS15voCZPa1ZA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalEndToEndIdentification"/>
    [IsoId("_ha3ZjxmHEeS15voCZPa1ZA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalTransactionIdentification"/>
    [IsoId("_ha3ZkRmHEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalClearingSystemReference"/>
    [IsoId("_ha3ZkxmHEeS15voCZPa1ZA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.OriginalInterbankSettlementAmount"/>
    [IsoId("_ha3ZlRmHEeS15voCZPa1ZA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ReturnedInterbankSettlementAmount"/>
    [IsoId("_ha3ZlxmHEeS15voCZPa1ZA")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.InterbankSettlementDate"/>
    [IsoId("_ha3ZmRmHEeS15voCZPa1ZA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.SettlementPriority"/>
    [IsoId("_XTGfURmHEeS15voCZPa1ZA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ReturnedInstructedAmount"/>
    [IsoId("_ha3ZmxmHEeS15voCZPa1ZA")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ExchangeRate"/>
    [IsoId("_ha3ZnRmHEeS15voCZPa1ZA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.CompensationAmount"/>
    [IsoId("_ha3ZnxmHEeS15voCZPa1ZA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ChargeBearer"/>
    [IsoId("_ha3ZoRmHEeS15voCZPa1ZA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ChargesInformation"/>
    [IsoId("_ha3ZoxmHEeS15voCZPa1ZA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction50.InstructingAgent"/>
    [IsoId("_ha3ZpRmHEeS15voCZPa1ZA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.InstructedAgent"/>
    [IsoId("_ha3ZpxmHEeS15voCZPa1ZA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.ReturnReasonInformation"/>
    [IsoId("_ha3ZqRmHEeS15voCZPa1ZA")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason1> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction50.OriginalTransactionReference"/>
    [IsoId("_ha3ZqxmHEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference20? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction50.SupplementaryData"/>
    [IsoId("_ha3ZrRmHEeS15voCZPa1ZA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
