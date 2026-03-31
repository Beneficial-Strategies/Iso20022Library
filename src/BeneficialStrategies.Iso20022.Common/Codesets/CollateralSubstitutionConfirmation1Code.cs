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
[IsoId("_Yb5zUNp-Ed-ak6NoX_4Aeg_-794314773")]
[Description(@"Provides the status of the collateral substitution, either returned or released.")]
[DerivedFrom(typeof(CollateralSubstitutionConfirmationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralSubstitutionConfirmation1Code>))]
#endif
public enum CollateralSubstitutionConfirmation1Code
{
    /// <summary>
    /// Notification that the collateral substitution, that is new piece(s) of collateral, have been released.
    /// Encoded/decoded by serializers as &quot;CREL&quot;.
    /// </summary>
    [EnumMember(Value = "CREL")]
    [IsoId("_Yb5zUdp-Ed-ak6NoX_4Aeg_434936971")]
    [Description(
        @"Notification that the collateral substitution, that is new piece(s) of collateral, have been released."
    )]
    CollateralSubstitutionReleased =
        CollateralSubstitutionConfirmationCode.CollateralSubstitutionReleased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.
    /// Encoded/decoded by serializers as &quot;CRET&quot;.
    /// </summary>
    [EnumMember(Value = "CRET")]
    [IsoId("_Yb5zUtp-Ed-ak6NoX_4Aeg_-1408932018")]
    [Description(
        @"Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received."
    )]
    CollateralSubstitutionReturned =
        CollateralSubstitutionConfirmationCode.CollateralSubstitutionReturned, // same ordinal as derivation source for type conversions
}
