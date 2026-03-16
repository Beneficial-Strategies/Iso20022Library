// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzX8ldp-Ed-ak6NoX_4Aeg_-191357927")]
[Description(@"Specifies the type of transaction that resulted in the payment.")]
[Derivations(typeof(PaymentCategoryPurpose1Code))]
public enum PaymentCategoryPurposeCode
{
    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_ZzX8ltp-Ed-ak6NoX_4Aeg_-190437316")]
    [Description(
        @"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group."
    )]
    IntraCompanyPayment,

    /// <summary>
    /// Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_ZzX8l9p-Ed-ak6NoX_4Aeg_-190436818")]
    [Description(
        @"Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction."
    )]
    TradeSettlementPayment,

    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_ZzX8mNp-Ed-ak6NoX_4Aeg_-190436663")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment,

    /// <summary>
    /// Transaction is related to treasury operations.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_ZzX8mdp-Ed-ak6NoX_4Aeg_-190436309")]
    [Description(@"Transaction is related to treasury operations.")]
    TreasuryPayment,

    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZzhtkNp-Ed-ak6NoX_4Aeg_-189512305")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer,

    /// <summary>
    /// Transaction is the payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_Zzhtkdp-Ed-ak6NoX_4Aeg_-187666304")]
    [Description(@"Transaction is the payment of dividends.")]
    Dividend,

    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_Zzhtktp-Ed-ak6NoX_4Aeg_-187664846")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment,

    /// <summary>
    /// Transaction is the payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Zzhtk9p-Ed-ak6NoX_4Aeg_-187663898")]
    [Description(@"Transaction is the payment of interest.")]
    Interest,

    /// <summary>
    /// Transaction is related to the transfer of a loan to a borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZzhtlNp-Ed-ak6NoX_4Aeg_-186742816")]
    [Description(@"Transaction is related to the transfer of a loan to a borrower.")]
    Loan,

    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_Zzhtldp-Ed-ak6NoX_4Aeg_-186741203")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment,

    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Zzhtltp-Ed-ak6NoX_4Aeg_-185818653")]
    [Description(@"Transaction is the payment of securities.")]
    Securities,

    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_Zzhtl9p-Ed-ak6NoX_4Aeg_-185818165")]
    [Description(
        @"Transaction is a social security benefit, ie payment made by a government to support individuals."
    )]
    SocialSecurityBenefit,

    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_ZzhtmNp-Ed-ak6NoX_4Aeg_-185817338")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment,

    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_Zzhtmdp-Ed-ak6NoX_4Aeg_-185817200")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment,

    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_Zzq3gNp-Ed-ak6NoX_4Aeg_-185816793")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment,

    /// <summary>
    /// Transaction is related to the payment of a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_Zzq3gdp-Ed-ak6NoX_4Aeg_-184896546")]
    [Description(@"Transaction is related to the payment of a hedging operation.")]
    Hedging,

    /// <summary>
    /// Transaction is related to the payment of a trade transaction.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_Zzq3gtp-Ed-ak6NoX_4Aeg_-184896191")]
    [Description(@"Transaction is related to the payment of a trade transaction.")]
    Trade,

    /// <summary>
    /// Transaction is the payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHLD&quot;.
    /// </summary>
    [EnumMember(Value = "WHLD")]
    [IsoId("_Zzq3g9p-Ed-ak6NoX_4Aeg_-87003494")]
    [Description(@"Transaction is the payment of withholding tax.")]
    WithHolding,
}
