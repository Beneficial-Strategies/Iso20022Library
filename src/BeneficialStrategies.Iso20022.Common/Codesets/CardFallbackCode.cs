// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about card entry mode fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rr44gGkCEeS7zPBpvm732w")]
[Description(@"Information about card entry mode fallback.")]
[Derivations(typeof(CardFallback1Code))]
public enum CardFallbackCode
{
    /// <summary>
    /// No card fall-back during the transaction in progress.
    /// Encoded/decoded by serializers as &quot;NFLB&quot;.
    /// </summary>
    [EnumMember(Value = "NFLB")]
    [IsoId("_WDZrUGkCEeS7zPBpvm732w")]
    [Description(@"No card fall-back during the transaction in progress.")]
    NoFallback,

    /// <summary>
    /// Card fall-back occurred during the transaction in progress. The previous transaction on the terminal was successful.
    /// Encoded/decoded by serializers as &quot;SFLB&quot;.
    /// </summary>
    [EnumMember(Value = "SFLB")]
    [IsoId("_ZaPEQGkCEeS7zPBpvm732w")]
    [Description(
        @"Card fall-back occurred during the transaction in progress. The previous transaction on the terminal was successful."
    )]
    FallbackAfterSuccess,

    /// <summary>
    /// Card fall-back occurred during the transaction in progress. The previous transaction on the terminal failed.
    /// Encoded/decoded by serializers as &quot;FFLB&quot;.
    /// </summary>
    [EnumMember(Value = "FFLB")]
    [IsoId("_e2q3wGkCEeS7zPBpvm732w")]
    [Description(
        @"Card fall-back occurred during the transaction in progress. The previous transaction on the terminal failed."
    )]
    FallbackAfterFailure,
}
