// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ah3aQNp-Ed-ak6NoX_4Aeg_-672768404")]
[Description(
    @"Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility."
)]
[Derivations(typeof(ERISAEligibility1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ERISAEligibilityCode>))]
#endif
public enum ERISAEligibilityCode
{
    /// <summary>
    /// Investor is subject to an ERISA declaration.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ah3aQdp-Ed-ak6NoX_4Aeg_-672768064")]
    [Description(@"Investor is subject to an ERISA declaration.")]
    ERISAEligible,

    /// <summary>
    /// Investment is not subject to an ERISA declaration.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_ah3aQtp-Ed-ak6NoX_4Aeg_-672768034")]
    [Description(@"Investment is not subject to an ERISA declaration.")]
    NotERISAEligible,

    /// <summary>
    /// Eligibility is unknown at the time the order is sent, and the instructing party will confirm later.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ah3aQ9p-Ed-ak6NoX_4Aeg_-672768003")]
    [Description(
        @"Eligibility is unknown at the time the order is sent, and the instructing party will confirm later."
    )]
    ERISAEligibilityUnknown,
}
