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
[IsoId("_0vxi0WHYEe6yt_d72zQZeQ")]
[Description(@"Specifies information regarding the non eligibility of the outturn resources.")]
[DerivedFrom(typeof(NonEligibleProceedsIndicatorCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<NonEligibleProceedsIndicator2Code>))]
public enum NonEligibleProceedsIndicator2Code
{
    /// <summary>
    /// Participant's account limitation.
    /// Encoded/decoded by serializers as &quot;ACLI&quot;.
    /// </summary>
    [EnumMember(Value = "ACLI")]
    [IsoId("_04YFM2HYEe6yt_d72zQZeQ")]
    [Description(@"Participant's account limitation.")]
    AccountLimitation = NonEligibleProceedsIndicatorCode.AccountLimitation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency not eligible for settlement in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NELC&quot;.
    /// </summary>
    [EnumMember(Value = "NELC")]
    [IsoId("_04YFMWHYEe6yt_d72zQZeQ")]
    [Description(
        @"Currency not eligible for settlement in the Central Securities Depository (CSD)."
    )]
    NonEligibleCurrency = NonEligibleProceedsIndicatorCode.NonEligibleCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security not eligible in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NELS&quot;.
    /// </summary>
    [EnumMember(Value = "NELS")]
    [IsoId("_3MyX0WHYEe6yt_d72zQZeQ")]
    [Description(@"Security not eligible in the Central Securities Depository (CSD).")]
    NonEligibleSecurity = NonEligibleProceedsIndicatorCode.NonEligibleSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other source of non eligibility.
    /// Encoded/decoded by serializers as &quot;ONEL&quot;.
    /// </summary>
    [EnumMember(Value = "ONEL")]
    [IsoId("_04YFNWHYEe6yt_d72zQZeQ")]
    [Description(@"Other source of non eligibility.")]
    OtherNonEligibility = NonEligibleProceedsIndicatorCode.OtherNonEligibility, // same ordinal as derivation source for type conversions
}
