// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Energy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VDR90AnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Energy.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType2Code
{
    /// <summary>
    /// Commodity of type energy.
    /// Encoded/decoded by serializers as &quot;NRGY&quot;.
    /// </summary>
    [EnumMember(Value = "NRGY")]
    [IsoId("_fVAFQQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type energy.")]
    Energy = AssetClassProductTypeCode.Energy, // same ordinal as derivation source for type conversions
}
