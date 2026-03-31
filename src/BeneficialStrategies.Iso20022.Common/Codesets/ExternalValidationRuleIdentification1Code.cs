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
[IsoId("_SwXA8djGEeSD0e0ybx5L5Q")]
[Description(
    @"Specifies the external validation rule identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalValidationRuleIdentificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalValidationRuleIdentification1Code>))]
#endif
public enum ExternalValidationRuleIdentification1Code
{
    /// <summary>
    /// Identifies the validation rules related to the Russian Cross-border Transactions Currency Control Reporting
    /// Encoded/decoded by serializers as &quot;CCTR&quot;.
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_uTdKjvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rules related to the Russian Cross-border Transactions Currency Control Reporting"
    )]
    CrossborderTransactionsCurrencyControlReporting =
        ExternalValidationRuleIdentificationCode.CrossborderTransactionsCurrencyControlReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the validation rules related to the invoice tax reporting
    /// Encoded/decoded by serializers as &quot;ITRP&quot;.
    /// </summary>
    [EnumMember(Value = "ITRP")]
    [IsoId("_uTm7gvRYEeuLhpyIdtJzwg")]
    [Description(@"Identifies the validation rules related to the invoice tax reporting ")]
    InvoiceTaxReporting = ExternalValidationRuleIdentificationCode.InvoiceTaxReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the validation rule scheme related to the ECB Euro Money Market Statistical Reporting
    /// Encoded/decoded by serializers as &quot;MMSR&quot;.
    /// </summary>
    [EnumMember(Value = "MMSR")]
    [IsoId("_uTm7hfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rule scheme related to the ECB Euro Money Market Statistical Reporting"
    )]
    MoneyMarketStatisticalReporting =
        ExternalValidationRuleIdentificationCode.MoneyMarketStatisticalReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the validation rules related to the Bank Of England Sterling Money Market Daily Reporting
    /// Encoded/decoded by serializers as &quot;SMMD&quot;.
    /// </summary>
    [EnumMember(Value = "SMMD")]
    [IsoId("_uTwFcvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identifies the validation rules related to the Bank Of England Sterling Money Market Daily Reporting"
    )]
    SterlingMoneyMarketDaily = ExternalValidationRuleIdentificationCode.SterlingMoneyMarketDaily, // same ordinal as derivation source for type conversions
}
