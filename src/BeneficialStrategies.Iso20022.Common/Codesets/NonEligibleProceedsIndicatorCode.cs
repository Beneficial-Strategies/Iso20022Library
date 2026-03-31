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
[IsoId("_aNmactp-Ed-ak6NoX_4Aeg_975102968")]
[Description(@"Specifies information regarding the non eligibility of the outturn resources.")]
[Derivations(typeof(NonEligibleProceedsIndicator1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NonEligibleProceedsIndicatorCode>))]
#endif
public enum NonEligibleProceedsIndicatorCode
{
    /// <summary>
    /// Security not eligible in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NELS&quot;.
    /// </summary>
    [EnumMember(Value = "NELS")]
    [IsoId("_aNmac9p-Ed-ak6NoX_4Aeg_-1729563943")]
    [Description(@"Security not eligible in the Central Securities Depository (CSD).")]
    NonEligibleSecurity,

    /// <summary>
    /// Currency not eligible for settlement in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NELC&quot;.
    /// </summary>
    [EnumMember(Value = "NELC")]
    [IsoId("_aNmadNp-Ed-ak6NoX_4Aeg_-1670456685")]
    [Description(
        @"Currency not eligible for settlement in the Central Securities Depository (CSD)."
    )]
    NonEligibleCurrency,

    /// <summary>
    /// Participant&apos;s account limitation.
    /// Encoded/decoded by serializers as &quot;ACLI&quot;.
    /// </summary>
    [EnumMember(Value = "ACLI")]
    [IsoId("_aNmaddp-Ed-ak6NoX_4Aeg_-1627052409")]
    [Description(@"Participant's account limitation.")]
    AccountLimitation,

    /// <summary>
    /// Other source of non eligibility.
    /// Encoded/decoded by serializers as &quot;ONEL&quot;.
    /// </summary>
    [EnumMember(Value = "ONEL")]
    [IsoId("_aNmadtp-Ed-ak6NoX_4Aeg_-1602117129")]
    [Description(@"Other source of non eligibility.")]
    OtherNonEligibility,
}
