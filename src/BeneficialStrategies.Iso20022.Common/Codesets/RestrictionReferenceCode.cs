// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Restriction References applied on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s_iqUNarEei60tlze8Pqbw")]
[Description(@"Restriction References applied on a transaction.")]
[Derivations(typeof(RestrictionReference1Code))]
public enum RestrictionReferenceCode
{
    /// <summary>
    /// Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_zLkuwNarEei60tlze8Pqbw")]
    [Description(
        @"Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities."
    )]
    AddSecuritiesRestrictionReference,

    /// <summary>
    /// Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as &quot;REMS&quot;.
    /// </summary>
    [EnumMember(Value = "REMS")]
    [IsoId("_zR-RsNarEei60tlze8Pqbw")]
    [Description(
        @"Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. "
    )]
    RemoveSecuritiesRestrictionReference,

    /// <summary>
    /// Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as &quot;ADDC&quot;.
    /// </summary>
    [EnumMember(Value = "ADDC")]
    [IsoId("_zYODoNarEei60tlze8Pqbw")]
    [Description(
        @"Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash."
    )]
    AddCashRestrictionReference,

    /// <summary>
    /// Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as &quot;REMC&quot;.
    /// </summary>
    [EnumMember(Value = "REMC")]
    [IsoId("_zdRiwNarEei60tlze8Pqbw")]
    [Description(
        @"Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash."
    )]
    RemoveCashRestrictionReference,
}
