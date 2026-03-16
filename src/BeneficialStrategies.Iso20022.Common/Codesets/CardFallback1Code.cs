// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about card entry mode fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kkfWMGkCEeS7zPBpvm732w")]
[Description(@"Information about card entry mode fallback.")]
[DerivedFrom(typeof(CardFallbackCode))]
public enum CardFallback1Code
{
    /// <summary>
    /// Card fall-back occurred during the transaction in progress. The previous transaction on the terminal failed.
    /// Encoded/decoded by serializers as &quot;FFLB&quot;.
    /// </summary>
    [EnumMember(Value = "FFLB")]
    [IsoId("_p94cwWkCEeS7zPBpvm732w")]
    [Description(
        @"Card fall-back occurred during the transaction in progress. The previous transaction on the terminal failed."
    )]
    FallbackAfterFailure = CardFallbackCode.FallbackAfterFailure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card fall-back occurred during the transaction in progress. The previous transaction on the terminal was successful.
    /// Encoded/decoded by serializers as &quot;SFLB&quot;.
    /// </summary>
    [EnumMember(Value = "SFLB")]
    [IsoId("_qEHnoWkCEeS7zPBpvm732w")]
    [Description(
        @"Card fall-back occurred during the transaction in progress. The previous transaction on the terminal was successful."
    )]
    FallbackAfterSuccess = CardFallbackCode.FallbackAfterSuccess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No card fall-back during the transaction in progress.
    /// Encoded/decoded by serializers as &quot;NFLB&quot;.
    /// </summary>
    [EnumMember(Value = "NFLB")]
    [IsoId("_qKU9UWkCEeS7zPBpvm732w")]
    [Description(@"No card fall-back during the transaction in progress.")]
    NoFallback = CardFallbackCode.NoFallback, // same ordinal as derivation source for type conversions
}
