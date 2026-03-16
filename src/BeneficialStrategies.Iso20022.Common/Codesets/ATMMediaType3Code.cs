// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of media items.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Xci-AK4DEeWL1uap3dNhCQ")]
[Description(@"Category of media items.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
public enum ATMMediaType3Code
{
    /// <summary>
    /// Detected counterfeit media.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_dBRK0a4DEeWL1uap3dNhCQ")]
    [Description(@"Detected counterfeit media.")]
    Counterfeit = ATMMediaTypeCode.Counterfeit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fit media.
    /// Encoded/decoded by serializers as &quot;FITN&quot;.
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_dPbio64DEeWL1uap3dNhCQ")]
    [Description(@"Fit media.")]
    Fit = ATMMediaTypeCode.Fit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fit or unfit media, if fitness cannot be determined.
    /// Encoded/decoded by serializers as &quot;FITU&quot;.
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_daqiQ64DEeWL1uap3dNhCQ")]
    [Description(@"Fit or unfit media, if fitness cannot be determined.")]
    FitAndUnfit = ATMMediaTypeCode.FitAndUnfit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspect media.
    /// Encoded/decoded by serializers as &quot;SPCT&quot;.
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_ecYd864DEeWL1uap3dNhCQ")]
    [Description(@"Suspect media.")]
    Suspect = ATMMediaTypeCode.Suspect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unfit media (unacceptable quality).
    /// Encoded/decoded by serializers as &quot;UNFT&quot;.
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_euKxg64DEeWL1uap3dNhCQ")]
    [Description(@"Unfit media (unacceptable quality).")]
    Unfit = ATMMediaTypeCode.Unfit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised media.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_e3j-E64DEeWL1uap3dNhCQ")]
    [Description(@"Unrecognised media.")]
    Unrecognised = ATMMediaTypeCode.Unrecognised, // same ordinal as derivation source for type conversions
}
