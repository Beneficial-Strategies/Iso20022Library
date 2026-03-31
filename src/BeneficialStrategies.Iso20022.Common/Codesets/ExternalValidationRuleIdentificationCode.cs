// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external validation rule identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iwUTAGKIEeiw8ufheDd6MA")]
[Description(
    @"Specifies the external validation rule identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalValidationRuleIdentification1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalValidationRuleIdentificationCode>))]
#endif
public enum ExternalValidationRuleIdentificationCode
{
    /// <summary>
    /// Identifies the validation rules related to the Russian Cross-border Transactions Currency Control Reporting
    /// Encoded/decoded by serializers as &quot;CCTR&quot;.
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_uTdKjPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rules related to the Russian Cross-border Transactions Currency Control Reporting"
    )]
    CrossborderTransactionsCurrencyControlReporting,

    /// <summary>
    /// Identifies the validation rules related to the invoice tax reporting
    /// Encoded/decoded by serializers as &quot;ITRP&quot;.
    /// </summary>
    [EnumMember(Value = "ITRP")]
    [IsoId("_uTm7gPRYEeuLhpyIdtJzwg")]
    [Description(@"Identifies the validation rules related to the invoice tax reporting ")]
    InvoiceTaxReporting,

    /// <summary>
    /// Identifies the validation rule scheme related to the ECB Euro Money Market Statistical Reporting
    /// Encoded/decoded by serializers as &quot;MMSR&quot;.
    /// </summary>
    [EnumMember(Value = "MMSR")]
    [IsoId("_uTm7g_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rule scheme related to the ECB Euro Money Market Statistical Reporting"
    )]
    MoneyMarketStatisticalReporting,

    /// <summary>
    /// Identifies the validation rules related to the Bank Of England Sterling Money Market Daily Reporting
    /// Encoded/decoded by serializers as &quot;SMMD&quot;.
    /// </summary>
    [EnumMember(Value = "SMMD")]
    [IsoId("_uTwFcPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rules related to the Bank Of England Sterling Money Market Daily Reporting"
    )]
    SterlingMoneyMarketDaily,
}
