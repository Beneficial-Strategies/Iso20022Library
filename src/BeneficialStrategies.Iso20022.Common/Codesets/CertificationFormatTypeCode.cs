// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the certification format required, that is, physical or electronic format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a78HI9p-Ed-ak6NoX_4Aeg_-1769527950")]
[Description(
    @"Specifies the certification format required, that is, physical or electronic format."
)]
[Derivations(typeof(CertificationFormatType1Code))]
public enum CertificationFormatTypeCode
{
    /// <summary>
    /// Certification must be provided in electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_a78HJNp-Ed-ak6NoX_4Aeg_-1685487542")]
    [Description(@"Certification must be provided in electronic format.")]
    Electronic,

    /// <summary>
    /// Certification must be provided in physical format.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_a78HJdp-Ed-ak6NoX_4Aeg_-1647625645")]
    [Description(@"Certification must be provided in physical format.")]
    Physical,
}
