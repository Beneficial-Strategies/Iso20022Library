// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the physical form of the securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKmGliEeGaMcKyqKNRfQ_420935209")]
[Description(@"Indicates the physical form of the securities.")]
[Derivations(typeof(InitialPhysicalForm1Code),typeof(InitialPhysicalForm2Code))]
public enum InitialPhysicalFormCode
{
    /// <summary>
    /// Initial Physical Form is GT.
    /// Encoded/decoded by serializers as &quot;GTGT&quot;.
    /// </summary>
    [EnumMember(Value = "GTGT")]
    [IsoId("_hblKmWliEeGaMcKyqKNRfQ_-939155429")]
    [Description(@"Initial Physical Form is GT.")]
    GT,
    
    /// <summary>
    /// Initial Physical Form is GP.
    /// Encoded/decoded by serializers as &quot;GPGP&quot;.
    /// </summary>
    [EnumMember(Value = "GPGP")]
    [IsoId("_hblKmmliEeGaMcKyqKNRfQ_145243167")]
    [Description(@"Initial Physical Form is GP.")]
    GP,
    
    /// <summary>
    /// Initial Physical Form is definitive.
    /// Encoded/decoded by serializers as &quot;DERN&quot;.
    /// </summary>
    [EnumMember(Value = "DERN")]
    [IsoId("_hblKm2liEeGaMcKyqKNRfQ_1943280310")]
    [Description(@"Initial Physical Form is definitive.")]
    Definitive,
    
}
