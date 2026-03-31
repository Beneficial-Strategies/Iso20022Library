// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a confirmation is cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e0ShUFM7EeaOrcVOcDJQkA")]
[Description(@"Specifies the reason why a confirmation is cancelled.")]
[DerivedFrom(typeof(ConfirmationCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConfirmationCancellationReason1Code>))]
#endif
public enum ConfirmationCancellationReason1Code
{
    /// <summary>
    /// Confirmation is cancelled because the cash has not been received.
    /// Encoded/decoded by serializers as &quot;CSHN&quot;.
    /// </summary>
    [EnumMember(Value = "CSHN")]
    [IsoId("_hDs_MVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the cash has not been received.")]
    CashNotReceived = ConfirmationCancellationReasonCode.CashNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because it will be replaced.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_hNE9oVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because it will be replaced.")]
    ConfirmationReplacement = ConfirmationCancellationReasonCode.ConfirmationReplacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the back end load amount is incorrect.
    /// Encoded/decoded by serializers as &quot;BENA&quot;.
    /// </summary>
    [EnumMember(Value = "BENA")]
    [IsoId("_hWmtEVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the back end load amount is incorrect.")]
    IncorrectBackEndLoadAmount = ConfirmationCancellationReasonCode.IncorrectBackEndLoadAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the cash amount is incorrect.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_hf-rgVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the cash amount is incorrect.")]
    IncorrectCashAmount = ConfirmationCancellationReasonCode.IncorrectCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the discount amount is incorrect.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_hppk4VM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the discount amount is incorrect.")]
    IncorrectDiscountAmount = ConfirmationCancellationReasonCode.IncorrectDiscountAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the discount amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_hzUeQVM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the discount amount has an incorrect currency."
    )]
    IncorrectDiscountAmountCurrency =
        ConfirmationCancellationReasonCode.IncorrectDiscountAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the exchange rate is incorrect.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_h2cDsVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the exchange rate is incorrect.")]
    IncorrectExchangeRate = ConfirmationCancellationReasonCode.IncorrectExchangeRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because a fee or commission amount is incorrect.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_h_0CIVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because a fee or commission amount is incorrect.")]
    IncorrectFeeOrCommission = ConfirmationCancellationReasonCode.IncorrectFeeOrCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the financial instrument quantity is incorrect.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_iJosgVM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the financial instrument quantity is incorrect."
    )]
    IncorrectFinancialInstrumentQuantity =
        ConfirmationCancellationReasonCode.IncorrectFinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the front end load amount is incorrect.
    /// Encoded/decoded by serializers as &quot;FENA&quot;.
    /// </summary>
    [EnumMember(Value = "FENA")]
    [IsoId("_iTJ04VM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the front end load amount is incorrect.")]
    IncorrectFrontEndLoadAmount = ConfirmationCancellationReasonCode.IncorrectFrontEndLoadAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the gross amount is incorrect.
    /// Encoded/decoded by serializers as &quot;GROA&quot;.
    /// </summary>
    [EnumMember(Value = "GROA")]
    [IsoId("_icrkUVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the gross amount is incorrect.")]
    IncorrectGrossAmount = ConfirmationCancellationReasonCode.IncorrectGrossAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the gross amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;GROC&quot;.
    /// </summary>
    [EnumMember(Value = "GROC")]
    [IsoId("_igGEsVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the gross amount has an incorrect currency.")]
    IncorrectGrossAmountCurrency = ConfirmationCancellationReasonCode.IncorrectGrossAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the net amount is incorrect.
    /// Encoded/decoded by serializers as &quot;NETA&quot;.
    /// </summary>
    [EnumMember(Value = "NETA")]
    [IsoId("_ipeDIVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the net amount is incorrect.")]
    IncorrectNetAmount = ConfirmationCancellationReasonCode.IncorrectNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the net amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;NETC&quot;.
    /// </summary>
    [EnumMember(Value = "NETC")]
    [IsoId("_i5sQcVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the net amount has an incorrect currency.")]
    IncorrectNetAmountCurrency = ConfirmationCancellationReasonCode.IncorrectNetAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because of an incorrect operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_jDNY0VM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because of an incorrect operation.")]
    IncorrectOperation = ConfirmationCancellationReasonCode.IncorrectOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because of an incorrect minimum traded quantity or cash amount.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_jMbmQVM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because of an incorrect minimum traded quantity or cash amount."
    )]
    IncorrectQuantityUnitsOrCash = ConfirmationCancellationReasonCode.IncorrectQuantityUnitsOrCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the settlement amount is incorrect.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_jWQQoVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement amount is incorrect.")]
    IncorrectSettlementAmount = ConfirmationCancellationReasonCode.IncorrectSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the settlement amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_jf7KAVM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the settlement amount has an incorrect currency."
    )]
    IncorrectSettlementAmountCurrency =
        ConfirmationCancellationReasonCode.IncorrectSettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the settlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_jpmDYVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement date is incorrect.")]
    IncorrectSettlementDate = ConfirmationCancellationReasonCode.IncorrectSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the settlement method is incorrect.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_jzHLwVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement method is incorrect.")]
    IncorrectSettlementMethod = ConfirmationCancellationReasonCode.IncorrectSettlementMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is cancelled because the trade date is incorrect.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_j872IVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the trade date is incorrect.")]
    IncorrectTradeDate = ConfirmationCancellationReasonCode.IncorrectTradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation contains an invalid business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_kGmvgVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation contains an invalid business reference.")]
    InvalidReference = ConfirmationCancellationReasonCode.InvalidReference, // same ordinal as derivation source for type conversions
}
