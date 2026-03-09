// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the certification format required, that is, physical or electronic format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a78HINp-Ed-ak6NoX_4Aeg_-1603295237")]
[Description(@"Specifies the certification format required, that is, physical or electronic format.")]
[DerivedFrom(typeof(CertificationFormatTypeCode))]
public enum CertificationFormatType1Code
{
    /// <summary>
    /// Certification must be provided in electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_a78HIdp-Ed-ak6NoX_4Aeg_-1559890547")]
    [Description(@"Certification must be provided in electronic format.")]
    Electronic = CertificationFormatTypeCode.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification must be provided in physical format.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_a78HItp-Ed-ak6NoX_4Aeg_-1559890529")]
    [Description(@"Certification must be provided in physical format.")]
    Physical = CertificationFormatTypeCode.Physical, // same ordinal as derivation source for type conversions
    
}
