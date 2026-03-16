// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the restriction references to be applied to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q1UTcNavEei60tlze8Pqbw")]
[Description(@"Specifies the restriction references to be applied to a transaction.")]
[DerivedFrom(typeof(RestrictionReferenceCode))]
public enum RestrictionReference1Code
{
    /// <summary>
    /// Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as &quot;ADDC&quot;.
    /// </summary>
    [EnumMember(Value = "ADDC")]
    [IsoId("_jGoHcdj7EeiHnvcp3FV_5w")]
    [Description(
        @"Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash."
    )]
    AddCashRestrictionReference = RestrictionReferenceCode.AddCashRestrictionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_jNngQdj7EeiHnvcp3FV_5w")]
    [Description(
        @"Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities."
    )]
    AddSecuritiesRestrictionReference = RestrictionReferenceCode.AddSecuritiesRestrictionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as &quot;REMC&quot;.
    /// </summary>
    [EnumMember(Value = "REMC")]
    [IsoId("_jTuIQdj7EeiHnvcp3FV_5w")]
    [Description(
        @"Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash."
    )]
    RemoveCashRestrictionReference = RestrictionReferenceCode.RemoveCashRestrictionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as &quot;REMS&quot;.
    /// </summary>
    [EnumMember(Value = "REMS")]
    [IsoId("_jdPQodj7EeiHnvcp3FV_5w")]
    [Description(
        @"Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. "
    )]
    RemoveSecuritiesRestrictionReference =
        RestrictionReferenceCode.RemoveSecuritiesRestrictionReference, // same ordinal as derivation source for type conversions
}
