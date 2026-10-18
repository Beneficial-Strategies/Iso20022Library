// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransactionInformation2"/>
[IsoId("_PsXQU9p-Ed-ak6NoX_4Aeg_-1190214356")]
[DisplayName("Payment Transaction Information")]
public partial record PaymentTransactionInformation2
{
    /// <inheritdoc cref="IPaymentTransactionInformation2.ReturnIdentification"/>
    [IsoId("_PsXQVNp-Ed-ak6NoX_4Aeg_-1190213875")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalGroupInformation"/>
    [IsoId("_PsXQVdp-Ed-ak6NoX_4Aeg_-2131644084")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalInstructionIdentification"/>
    [IsoId("_PsXQVtp-Ed-ak6NoX_4Aeg_-1551043273")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalEndToEndIdentification"/>
    [IsoId("_PsXQV9p-Ed-ak6NoX_4Aeg_-1190213970")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalTransactionIdentification"/>
    [IsoId("_PsXQWNp-Ed-ak6NoX_4Aeg_511775997")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalInterbankSettlementAmount"/>
    [IsoId("_PshBUNp-Ed-ak6NoX_4Aeg_-1190213840")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public CurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ReturnedInterbankSettlementAmount"/>
    [IsoId("_PshBUdp-Ed-ak6NoX_4Aeg_-1190213331")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public required CurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.InterbankSettlementDate"/>
    [IsoId("_PshBUtp-Ed-ak6NoX_4Aeg_-1190213763")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ReturnedInstructedAmount"/>
    [IsoId("_PshBU9p-Ed-ak6NoX_4Aeg_1617271903")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public CurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ExchangeRate"/>
    [IsoId("_PshBVNp-Ed-ak6NoX_4Aeg_-1190213443")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.CompensationAmount"/>
    [IsoId("_PshBVdp-Ed-ak6NoX_4Aeg_-1190213720")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    public CurrencyAndAmount? CompensationAmount { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ChargeBearer"/>
    [IsoId("_PshBVtp-Ed-ak6NoX_4Aeg_-1190213408")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ChargesInformation"/>
    [IsoId("_PshBV9p-Ed-ak6NoX_4Aeg_-2132608256")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation2.InstructingAgent"/>
    [IsoId("_PshBWNp-Ed-ak6NoX_4Aeg_-710385882")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.InstructedAgent"/>
    [IsoId("_PshBWdp-Ed-ak6NoX_4Aeg_-710387311")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransactionInformation2.ReturnReasonInformation"/>
    [IsoId("_PsqLQNp-Ed-ak6NoX_4Aeg_-1111192957")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<ReturnReasonInformation1> ReturnReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransactionInformation2.OriginalTransactionReference"/>
    [IsoId("_PsqLQdp-Ed-ak6NoX_4Aeg_-405283210")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; }
}
