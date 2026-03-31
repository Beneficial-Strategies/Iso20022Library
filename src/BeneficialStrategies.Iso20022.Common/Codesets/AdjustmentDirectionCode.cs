// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the adjustment is added or substracted to the total amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnKOY9p-Ed-ak6NoX_4Aeg_-700576555")]
[Description(@"Specifies whether the adjustment is added or substracted to the total amount.")]
[Derivations(typeof(AdjustmentDirection1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdjustmentDirectionCode>))]
#endif
public enum AdjustmentDirectionCode
{
    /// <summary>
    /// Adjustment amount must be added to the total amount.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_bnKOZNp-Ed-ak6NoX_4Aeg_-644239632")]
    [Description(@"Adjustment amount must be added to the total amount.")]
    Added,

    /// <summary>
    /// Adjustment amount must be substracted from the total amount.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bnKOZdp-Ed-ak6NoX_4Aeg_-614687103")]
    [Description(@"Adjustment amount must be substracted from the total amount.")]
    Substracted,
}
