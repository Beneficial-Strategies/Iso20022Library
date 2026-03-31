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
[IsoId("_KSiJ8FM6EeaOrcVOcDJQkA")]
[Description(@"Specifies the reason why a confirmation is cancelled.")]
[Derivations(typeof(ConfirmationCancellationReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConfirmationCancellationReasonCode>))]
#endif
public enum ConfirmationCancellationReasonCode
{
    /// <summary>
    /// Confirmation is cancelled because the back end load amount is incorrect.
    /// Encoded/decoded by serializers as &quot;BENA&quot;.
    /// </summary>
    [EnumMember(Value = "BENA")]
    [IsoId("_kXaoIFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the back end load amount is incorrect.")]
    IncorrectBackEndLoadAmount,

    /// <summary>
    /// Confirmation is cancelled because it will be replaced.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_kejK4FM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because it will be replaced.")]
    ConfirmationReplacement,

    /// <summary>
    /// Confirmation is cancelled because the cash has not been received.
    /// Encoded/decoded by serializers as &quot;CSHN&quot;.
    /// </summary>
    [EnumMember(Value = "CSHN")]
    [IsoId("_kjKlIFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the cash has not been received.")]
    CashNotReceived,

    /// <summary>
    /// Confirmation is cancelled because the cash amount is incorrect.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_knoOYFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the cash amount is incorrect.")]
    IncorrectCashAmount,

    /// <summary>
    /// Confirmation is cancelled because the settlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_kr8GoFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement date is incorrect.")]
    IncorrectSettlementDate,

    /// <summary>
    /// Confirmation is cancelled because the trade date is incorrect.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_zO_gYFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the trade date is incorrect.")]
    IncorrectTradeDate,

    /// <summary>
    /// Confirmation is cancelled because the discount amount is incorrect.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_zVP5YFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the discount amount is incorrect.")]
    IncorrectDiscountAmount,

    /// <summary>
    /// Confirmation is cancelled because the discount amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_zbo1QFM6EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the discount amount has an incorrect currency."
    )]
    IncorrectDiscountAmountCurrency,

    /// <summary>
    /// Confirmation is cancelled because the settlement amount is incorrect.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ziCYMFM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement amount is incorrect.")]
    IncorrectSettlementAmount,

    /// <summary>
    /// Confirmation is cancelled because the financial instrument quantity is incorrect.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ziMJMFM6EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the financial instrument quantity is incorrect."
    )]
    IncorrectFinancialInstrumentQuantity,

    /// <summary>
    /// Confirmation is cancelled because the exchange rate is incorrect.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("__wnN4FM6EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the exchange rate is incorrect.")]
    IncorrectExchangeRate,

    /// <summary>
    /// Confirmation is cancelled because a fee or commission amount is incorrect.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ChD8QFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because a fee or commission amount is incorrect.")]
    IncorrectFeeOrCommission,

    /// <summary>
    /// Confirmation is cancelled because the front end load amount is incorrect.
    /// Encoded/decoded by serializers as &quot;FENA&quot;.
    /// </summary>
    [EnumMember(Value = "FENA")]
    [IsoId("_CndfMFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the front end load amount is incorrect.")]
    IncorrectFrontEndLoadAmount,

    /// <summary>
    /// Confirmation is cancelled because the gross amount is incorrect.
    /// Encoded/decoded by serializers as &quot;GROA&quot;.
    /// </summary>
    [EnumMember(Value = "GROA")]
    [IsoId("_CuAMEFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the gross amount is incorrect.")]
    IncorrectGrossAmount,

    /// <summary>
    /// Confirmation is cancelled because the gross amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;GROC&quot;.
    /// </summary>
    [EnumMember(Value = "GROC")]
    [IsoId("_CuAMEVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the gross amount has an incorrect currency.")]
    IncorrectGrossAmountCurrency,

    /// <summary>
    /// Confirmation is cancelled because of an incorrect minimum traded quantity or cash amount.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_C0ZvAFM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because of an incorrect minimum traded quantity or cash amount."
    )]
    IncorrectQuantityUnitsOrCash,

    /// <summary>
    /// Confirmation is cancelled because the settlement amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_PCh4wFM7EeaOrcVOcDJQkA")]
    [Description(
        @"Confirmation is cancelled because the settlement amount has an incorrect currency."
    )]
    IncorrectSettlementAmountCurrency,

    /// <summary>
    /// Confirmation is cancelled because the net amount is incorrect.
    /// Encoded/decoded by serializers as &quot;NETA&quot;.
    /// </summary>
    [EnumMember(Value = "NETA")]
    [IsoId("_PJEloFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the net amount is incorrect.")]
    IncorrectNetAmount,

    /// <summary>
    /// Confirmation is cancelled because the net amount has an incorrect currency.
    /// Encoded/decoded by serializers as &quot;NETC&quot;.
    /// </summary>
    [EnumMember(Value = "NETC")]
    [IsoId("_PJEloVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the net amount has an incorrect currency.")]
    IncorrectNetAmountCurrency,

    /// <summary>
    /// Confirmation is cancelled because of an incorrect operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_PPn5kFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because of an incorrect operation.")]
    IncorrectOperation,

    /// <summary>
    /// Confirmation contains an invalid business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_PPn5kVM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation contains an invalid business reference.")]
    InvalidReference,

    /// <summary>
    /// Confirmation is cancelled because the settlement method is incorrect.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_WKidQFM7EeaOrcVOcDJQkA")]
    [Description(@"Confirmation is cancelled because the settlement method is incorrect.")]
    IncorrectSettlementMethod,
}
