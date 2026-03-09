// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQbsAdp-Ed-ak6NoX_4Aeg_-835357153")]
[Description(@"Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).")]
[DerivedFrom(typeof(OptionDefinitionTypeCode))]
public enum OptionType1Code
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_aQbsAtp-Ed-ak6NoX_4Aeg_-539829511")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call = OptionDefinitionTypeCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;PUTO&quot;.
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("_aQbsA9p-Ed-ak6NoX_4Aeg_-539829469")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put = OptionDefinitionTypeCode.Put, // same ordinal as derivation source for type conversions
    
}
