// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction133"/>
[IsoId("_buMPMdcZEeqRFcf2R4bPBw")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction133
{
    /// <inheritdoc cref="IPaymentTransaction133.ReturnIdentification"/>
    [IsoId("_bvqO19cZEeqRFcf2R4bPBw")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalGroupInformation"/>
    [IsoId("_bvqO2dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalInstructionIdentification"/>
    [IsoId("_bvqO29cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalEndToEndIdentification"/>
    [IsoId("_bvqO3dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalTransactionIdentification"/>
    [IsoId("_bvqO39cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalUETR"/>
    [IsoId("_bvqO4dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalClearingSystemReference"/>
    [IsoId("_bvqO49cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalInterbankSettlementAmount"/>
    [IsoId("_bvqO5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.OriginalInterbankSettlementDate"/>
    [IsoId("_bvqO59cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.PaymentTypeInformation"/>
    [IsoId("_pV2nkdfxEeqoweZZxm4TPQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ReturnedInterbankSettlementAmount"/>
    [IsoId("_bvqO6dcZEeqRFcf2R4bPBw")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.InterbankSettlementDate"/>
    [IsoId("_bvqO69cZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.SettlementPriority"/>
    [IsoId("_bvqO7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.SettlementTimeIndication"/>
    [IsoId("_bvqO79cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.SettlementTimeRequest"/>
    [IsoId("_kAhdcdf4EeqoweZZxm4TPQ")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ReturnedInstructedAmount"/>
    [IsoId("_bvqO8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ExchangeRate"/>
    [IsoId("_bvqO89cZEeqRFcf2R4bPBw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.CompensationAmount"/>
    [IsoId("_bvqO9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ChargeBearer"/>
    [IsoId("_bvqO99cZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ChargesInformation"/>
    [IsoId("_bvqO-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction133.ClearingSystemReference"/>
    [IsoId("_bvqO-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.InstructingAgent"/>
    [IsoId("_bvqO_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.InstructedAgent"/>
    [IsoId("_bvqO_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ReturnChain"/>
    [IsoId("_bvqPAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties10? ReturnChain { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.ReturnReasonInformation"/>
    [IsoId("_bvqPA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason6> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction133.OriginalTransactionReference"/>
    [IsoId("_bvqPBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference36? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction133.SupplementaryData"/>
    [IsoId("_bvqPB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
