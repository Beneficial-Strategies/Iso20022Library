// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZdnvAdp-Ed-ak6NoX_4Aeg_-517887476")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectedStatusReason6Code>))]
#endif
public enum RejectedStatusReason6Code
{
    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZdnvAtp-Ed-ak6NoX_4Aeg_281881272")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ZdnvA9p-Ed-ak6NoX_4Aeg_598649737")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
}
