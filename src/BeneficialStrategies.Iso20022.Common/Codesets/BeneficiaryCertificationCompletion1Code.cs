// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification completion required for a beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bdn349p-Ed-ak6NoX_4Aeg_-737437637")]
[Description(@"Specifies the type of certification completion required for a beneficiary.")]
[DerivedFrom(typeof(BeneficiaryCertificationCompletionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BeneficiaryCertificationCompletion1Code>))]
#endif
public enum BeneficiaryCertificationCompletion1Code
{
    /// <summary>
    /// Certification is not required for this fund.
    /// Encoded/decoded by serializers as &quot;NCER&quot;.
    /// </summary>
    [EnumMember(Value = "NCER")]
    [IsoId("_bdn35Np-Ed-ak6NoX_4Aeg_-737437594")]
    [Description(@"Certification is not required for this fund.")]
    CertificationNotRequired = BeneficiaryCertificationCompletionCode.CertificationNotRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic certification is acceptable.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_bdn35dp-Ed-ak6NoX_4Aeg_-737437577")]
    [Description(@"Electronic certification is acceptable.")]
    ElectronicCertification = BeneficiaryCertificationCompletionCode.ElectronicCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic certification is not acceptable and is required in physical form.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_bdn35tp-Ed-ak6NoX_4Aeg_-737437559")]
    [Description(@"Electronic certification is not acceptable and is required in physical form.")]
    PhysicalCertification = BeneficiaryCertificationCompletionCode.PhysicalCertification, // same ordinal as derivation source for type conversions
}
