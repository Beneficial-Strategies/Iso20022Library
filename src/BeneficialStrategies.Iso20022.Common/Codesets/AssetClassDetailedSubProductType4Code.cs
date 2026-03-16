// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Olive Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6ubbYA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Olive Oil.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType4Code
{
    /// <summary>
    /// Commodity attribute of type lampante.
    /// Encoded/decoded by serializers as &quot;LAMP&quot;.
    /// </summary>
    [EnumMember(Value = "LAMP")]
    [IsoId("_6BOAsVq5EeWN79Bl6BUd3g")]
    [Description(@"Commodity attribute of type lampante.")]
    Lampante = AssetClassDetailedSubProductTypeCode.Lampante, // same ordinal as derivation source for type conversions
}
