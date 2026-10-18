// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation5"/>
[IsoId("_Prnpetp-Ed-ak6NoX_4Aeg_1832543398")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation5
{
    /// <inheritdoc cref="IPaymentTransactionInformation5.ReversalIdentification"/>
    [IsoId("_Prnpe9p-Ed-ak6NoX_4Aeg_1833463637")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalPaymentInformationIdentification"/>
    [IsoId("_PrnpfNp-Ed-ak6NoX_4Aeg_1833463949")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalInstructionIdentification"/>
    [IsoId("_PrxacNp-Ed-ak6NoX_4Aeg_1833464026")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalEndToEndIdentification"/>
    [IsoId("_Prxacdp-Ed-ak6NoX_4Aeg_1833464069")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalTransactionIdentification"/>
    [IsoId("_Prxactp-Ed-ak6NoX_4Aeg_1833464430")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalInterbankSettlementAmount"/>
    [IsoId("_Prxac9p-Ed-ak6NoX_4Aeg_1833464905")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ReversedInterbankSettlementAmount"/>
    [IsoId("_PrxadNp-Ed-ak6NoX_4Aeg_1833466463")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    public required CurrencyAndAmount ReversedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.InterbankSettlementDate"/>
    [IsoId("_Prxaddp-Ed-ak6NoX_4Aeg_1833465325")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ReversedInstructedAmount"/>
    [IsoId("_Prxadtp-Ed-ak6NoX_4Aeg_-918387251")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public CurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ExchangeRate"/>
    [IsoId("_Prxad9p-Ed-ak6NoX_4Aeg_1833465887")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.CompensationAmount"/>
    [IsoId("_PrxaeNp-Ed-ak6NoX_4Aeg_1833465533")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public CurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ChargeBearer"/>
    [IsoId("_Prxaedp-Ed-ak6NoX_4Aeg_1833466308")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ChargesInformation"/>
    [IsoId("_Pr6kYNp-Ed-ak6NoX_4Aeg_1834388055")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation5.InstructingAgent"/>
    [IsoId("_Pr6kYdp-Ed-ak6NoX_4Aeg_1835312473")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.InstructedAgent"/>
    [IsoId("_Pr6kYtp-Ed-ak6NoX_4Aeg_1835311079")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation5.ReversalReasonInformation"/>
    [IsoId("_Pr6kY9p-Ed-ak6NoX_4Aeg_14128664")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation1> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation5.OriginalTransactionReference"/>
    [IsoId("_Pr6kZNp-Ed-ak6NoX_4Aeg_1834389873")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
