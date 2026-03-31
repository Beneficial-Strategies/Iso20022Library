// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ADxVkLcQEeKuGrOch6U_ZQ_1001230530")]
[Description(
    @"Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset)."
)]
[Derivations(typeof(OptionType1Code), typeof(OptionTypeCode), typeof(OptionType2Code))]
public enum OptionDefinitionTypeCode
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_AD7GkLcQEeKuGrOch6U_ZQ_-1963859091")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call,

    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as &quot;PUTO&quot;.
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("_AD7GkbcQEeKuGrOch6U_ZQ_1096309774")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put,

    /// <summary>
    /// Right where the holder of the option decides whether the option is put or call.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_q5GEIAjtEeW36pGcc5RpFw")]
    [Description(
        @"Right where the holder of the option decides whether the option is put or call."
    )]
    Other,
}
