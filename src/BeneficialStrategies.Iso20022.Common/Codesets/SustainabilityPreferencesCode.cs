// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the product is compatible with investors that have sustainability preferences. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amB7QM0UEeuAE-cYsQdwHQ")]
[Description(@"Specifies whether the product is compatible with investors that have sustainability preferences. ")]
[Derivations(typeof(SustainabilityPreferences1Code),typeof(SustainabilityPreferences2Code))]
public enum SustainabilityPreferencesCode
{
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_oUmkEM0UEeuAE-cYsQdwHQ")]
    [Description(@"Neutral or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Preference for products having environmental, social and corporate governance (ESG) characteristics.
    /// Encoded/decoded by serializers as &quot;CESG&quot;.
    /// </summary>
    [EnumMember(Value = "CESG")]
    [IsoId("_1SaeUM0UEeuAE-cYsQdwHQ")]
    [Description(@"Preference for products having environmental, social and corporate governance (ESG) characteristics.")]
    ESGPreference,
    
    /// <summary>
    /// Preference for products having sustainable objectives.
    /// Encoded/decoded by serializers as &quot;OSUS&quot;.
    /// </summary>
    [EnumMember(Value = "OSUS")]
    [IsoId("_5kohcM0UEeuAE-cYsQdwHQ")]
    [Description(@"Preference for products having sustainable objectives.")]
    SustainablePreference,

    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("")]
    [Description(@"Yes, is applicable.")]
    InScope,

}
