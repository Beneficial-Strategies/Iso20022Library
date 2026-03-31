// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information regarding the non eligibility of the outturn resources.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNcpdtp-Ed-ak6NoX_4Aeg_1631723636")]
[Description(@"Specifies information regarding the non eligibility of the outturn resources.")]
[DerivedFrom(typeof(NonEligibleProceedsIndicatorCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NonEligibleProceedsIndicator1Code>))]
#endif
public enum NonEligibleProceedsIndicator1Code
{
    /// <summary>
    /// Currency not eligible for settlement in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NELC&quot;.
    /// </summary>
    [EnumMember(Value = "NELC")]
    [IsoId("_aNcpd9p-Ed-ak6NoX_4Aeg_-1557787681")]
    [Description(
        @"Currency not eligible for settlement in the Central Securities Depository (CSD)."
    )]
    NonEligibleCurrency = NonEligibleProceedsIndicatorCode.NonEligibleCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant&apos;s account limitation.
    /// Encoded/decoded by serializers as &quot;ACLI&quot;.
    /// </summary>
    [EnumMember(Value = "ACLI")]
    [IsoId("_aNmacNp-Ed-ak6NoX_4Aeg_-1557787656")]
    [Description(@"Participant's account limitation.")]
    AccountLimitation = NonEligibleProceedsIndicatorCode.AccountLimitation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other source of non eligibility.
    /// Encoded/decoded by serializers as &quot;ONEL&quot;.
    /// </summary>
    [EnumMember(Value = "ONEL")]
    [IsoId("_aNmacdp-Ed-ak6NoX_4Aeg_-1557787373")]
    [Description(@"Other source of non eligibility.")]
    OtherNonEligibility = NonEligibleProceedsIndicatorCode.OtherNonEligibility, // same ordinal as derivation source for type conversions
}
