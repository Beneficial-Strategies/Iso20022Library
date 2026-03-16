// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Dry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_clWEkFuVEeWyucVx3N7tNg")]
[Description(@"Further sub product code list for commodity derivative Dry.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType14Code
{
    /// <summary>
    /// Commodity attribute of type dry bulk carrier.
    /// Encoded/decoded by serializers as &quot;DBCR&quot;.
    /// </summary>
    [EnumMember(Value = "DBCR")]
    [IsoId("_fntCUFuVEeWyucVx3N7tNg")]
    [Description(@"Commodity attribute of type dry bulk carrier.")]
    DryBulkCarrier = AssetClassDetailedSubProductTypeCode.DryBulkCarrier, // same ordinal as derivation source for type conversions
}
