// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzFBo9p-Ed-ak6NoX_4Aeg_11813322")]
[Description(@"Specifies the type of transaction that resulted in the payment.")]
[DerivedFrom(typeof(PaymentCategoryPurposeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentCategoryPurpose1Code>))]
#endif
public enum PaymentCategoryPurpose1Code
{
    /// <summary>
    /// Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_ZzFBpNp-Ed-ak6NoX_4Aeg_11813796")]
    [Description(
        @"Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction."
    )]
    TradeSettlementPayment = PaymentCategoryPurposeCode.TradeSettlementPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_ZzFBpdp-Ed-ak6NoX_4Aeg_11813831")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment = PaymentCategoryPurposeCode.SalaryPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is related to treasury operations.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_ZzFBptp-Ed-ak6NoX_4Aeg_11813874")]
    [Description(@"Transaction is related to treasury operations.")]
    TreasuryPayment = PaymentCategoryPurposeCode.TreasuryPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZzOLkNp-Ed-ak6NoX_4Aeg_11814294")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer = PaymentCategoryPurposeCode.CashManagementTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_ZzOLkdp-Ed-ak6NoX_4Aeg_11814432")]
    [Description(@"Transaction is the payment of dividends.")]
    Dividend = PaymentCategoryPurposeCode.Dividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_ZzOLktp-Ed-ak6NoX_4Aeg_11814840")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment = PaymentCategoryPurposeCode.GovernmentPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZzOLk9p-Ed-ak6NoX_4Aeg_11815657")]
    [Description(@"Transaction is the payment of interest.")]
    Interest = PaymentCategoryPurposeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is related to the transfer of a loan to a borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZzOLlNp-Ed-ak6NoX_4Aeg_11815735")]
    [Description(@"Transaction is related to the transfer of a loan to a borrower.")]
    Loan = PaymentCategoryPurposeCode.Loan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_ZzOLldp-Ed-ak6NoX_4Aeg_11816173")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment = PaymentCategoryPurposeCode.PensionPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZzOLltp-Ed-ak6NoX_4Aeg_11816275")]
    [Description(@"Transaction is the payment of securities.")]
    Securities = PaymentCategoryPurposeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_ZzOLl9p-Ed-ak6NoX_4Aeg_11816605")]
    [Description(
        @"Transaction is a social security benefit, ie payment made by a government to support individuals."
    )]
    SocialSecurityBenefit = PaymentCategoryPurposeCode.SocialSecurityBenefit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_ZzOLmNp-Ed-ak6NoX_4Aeg_12736929")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment = PaymentCategoryPurposeCode.SupplierPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_ZzOLmdp-Ed-ak6NoX_4Aeg_12737259")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment = PaymentCategoryPurposeCode.TaxPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is related to the payment of a trade transaction.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZzX8kNp-Ed-ak6NoX_4Aeg_12737379")]
    [Description(@"Transaction is related to the payment of a trade transaction.")]
    Trade = PaymentCategoryPurposeCode.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_ZzX8kdp-Ed-ak6NoX_4Aeg_12737800")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment = PaymentCategoryPurposeCode.ValueAddedTaxPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is related to the payment of a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_ZzX8ktp-Ed-ak6NoX_4Aeg_12738232")]
    [Description(@"Transaction is related to the payment of a hedging operation.")]
    Hedging = PaymentCategoryPurposeCode.Hedging, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_ZzX8k9p-Ed-ak6NoX_4Aeg_12738747")]
    [Description(
        @"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group."
    )]
    IntraCompanyPayment = PaymentCategoryPurposeCode.IntraCompanyPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHLD&quot;.
    /// </summary>
    [EnumMember(Value = "WHLD")]
    [IsoId("_ZzX8lNp-Ed-ak6NoX_4Aeg_26591144")]
    [Description(@"Transaction is the payment of withholding tax.")]
    WithHolding = PaymentCategoryPurposeCode.WithHolding, // same ordinal as derivation source for type conversions
}
