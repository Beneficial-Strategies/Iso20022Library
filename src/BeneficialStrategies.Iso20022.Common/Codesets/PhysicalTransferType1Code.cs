// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sXY0QPrqEeCJc7cZxzE2fg")]
[Description(@"Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.")]
[DerivedFrom(typeof(PhysicalTransferTypeCode))]
public enum PhysicalTransferType1Code
{
    /// <summary>
    /// Dematerialised transfer.
    /// Encoded/decoded by serializers as &quot;DEMT&quot;.
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_kzEcnv8vEeCuNd2SpsBr7g")]
    [Description(@"Dematerialised transfer.")]
    Dematerialised = PhysicalTransferTypeCode.Dematerialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_k2gLHv8vEeCuNd2SpsBr7g")]
    [Description(@"Physical transfer.")]
    Physical = PhysicalTransferTypeCode.Physical, // same ordinal as derivation source for type conversions
    
}
