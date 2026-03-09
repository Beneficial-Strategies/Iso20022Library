// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQbsBNp-Ed-ak6NoX_4Aeg_1247360713")]
[Description(@"Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).")]
[DerivedFrom(typeof(OptionDefinitionTypeCode))]
public enum OptionTypeCode
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_aQbsBdp-Ed-ak6NoX_4Aeg_-17692338")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call = OptionDefinitionTypeCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;PUTO&quot;.
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("_aQbsBtp-Ed-ak6NoX_4Aeg_22019899")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put = OptionDefinitionTypeCode.Put, // same ordinal as derivation source for type conversions
    
}
