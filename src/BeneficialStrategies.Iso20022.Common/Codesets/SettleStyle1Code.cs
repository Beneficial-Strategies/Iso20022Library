// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when the option contract settles.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOREZNp-Ed-ak6NoX_4Aeg_-1482938751")]
[Description(@"Specifies when the option contract settles.")]
[DerivedFrom(typeof(SettleStyleCode))]
public enum SettleStyle1Code
{
    /// <summary>
    /// Settlement is only allowed on the closing of the future contract.
    /// Encoded/decoded by serializers as &quot;SETC&quot;.
    /// </summary>
    [EnumMember(Value = "SETC")]
    [IsoId("_ZOa1YNp-Ed-ak6NoX_4Aeg_-1439531144")]
    [Description(@"Settlement is only allowed on the closing of the future contract.")]
    SettleOnClose = SettleStyleCode.SettleOnClose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is only allowed on the opening of the future contract.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_ZOa1Ydp-Ed-ak6NoX_4Aeg_-1439531109")]
    [Description(@"Settlement is only allowed on the opening of the future contract.")]
    SettleOnOpen = SettleStyleCode.SettleOnOpen, // same ordinal as derivation source for type conversions
}
