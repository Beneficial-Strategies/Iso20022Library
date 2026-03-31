// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of the collateral substitution, either returned or released.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yb5zU9p-Ed-ak6NoX_4Aeg_33978882")]
[Description(@"Provides the status of the collateral substitution, either returned or released.")]
[Derivations(typeof(CollateralSubstitutionConfirmation1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralSubstitutionConfirmationCode>))]
#endif
public enum CollateralSubstitutionConfirmationCode
{
    /// <summary>
    /// Notification that the collateral substitution, that is new piece(s) of collateral, have been released.
    /// Encoded/decoded by serializers as &quot;CREL&quot;.
    /// </summary>
    [EnumMember(Value = "CREL")]
    [IsoId("_Yb5zVNp-Ed-ak6NoX_4Aeg_-808634352")]
    [Description(
        @"Notification that the collateral substitution, that is new piece(s) of collateral, have been released."
    )]
    CollateralSubstitutionReleased,

    /// <summary>
    /// Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.
    /// Encoded/decoded by serializers as &quot;CRET&quot;.
    /// </summary>
    [EnumMember(Value = "CRET")]
    [IsoId("_Yb5zVdp-Ed-ak6NoX_4Aeg_-760306748")]
    [Description(
        @"Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received."
    )]
    CollateralSubstitutionReturned,
}
