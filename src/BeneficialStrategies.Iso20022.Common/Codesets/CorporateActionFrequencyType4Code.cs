// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the frequency type of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sm9LEKFUEeSK_vfd3NHBGg")]
[Description(@"Specifies the frequency type of a corporate action event.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeV2Code))]
public enum CorporateActionFrequencyType4Code
{
    /// <summary>
    /// Special Dividend with reinvestment component.
    /// Encoded/decoded by serializers as &quot;SPRE&quot;.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_udHZoaFUEeSK_vfd3NHBGg")]
    [Description(@"Special Dividend with reinvestment component.")]
    SpecialDividendWithReinvestment = CorporateActionFrequencyTypeV2Code.SpecialDividendWithReinvestment, // same ordinal as derivation source for type conversions
    
}
