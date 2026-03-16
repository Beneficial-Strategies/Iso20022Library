// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when the option contract settles.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218")]
[Description(@"Specifies when the option contract settles.")]
[Derivations(typeof(SettleStyle1Code))]
public enum SettleStyleCode
{
    /// <summary>
    /// Settlement is only allowed on the opening of the future contract.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_ZOa1Y9p-Ed-ak6NoX_4Aeg_1626303304")]
    [Description(@"Settlement is only allowed on the opening of the future contract.")]
    SettleOnOpen,

    /// <summary>
    /// Settlement is only allowed on the closing of the future contract.
    /// Encoded/decoded by serializers as &quot;SETC&quot;.
    /// </summary>
    [EnumMember(Value = "SETC")]
    [IsoId("_ZOa1ZNp-Ed-ak6NoX_4Aeg_1627226825")]
    [Description(@"Settlement is only allowed on the closing of the future contract.")]
    SettleOnClose,
}
