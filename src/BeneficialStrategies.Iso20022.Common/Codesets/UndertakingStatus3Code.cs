// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XI5XMH1VEeGlwNeVP9egyg")]
[Description(@"Specifies the undertaking status.")]
[DerivedFrom(typeof(UndertakingStatusCode))]
public enum UndertakingStatus3Code
{
    /// <summary>
    /// Accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_e_hVNn1VEeGlwNeVP9egyg")]
    [Description(@"Accepted.")]
    Accepted = UndertakingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking not confirmed.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_fUrs5n1VEeGlwNeVP9egyg")]
    [Description(@"Undertaking not confirmed.")]
    NonConfirmation = UndertakingStatusCode.NonConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_fr7INn1VEeGlwNeVP9egyg")]
    [Description(@"Rejected.")]
    Rejected = UndertakingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Demand has been withdrawn.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_fyVSNn1VEeGlwNeVP9egyg")]
    [Description(@"Demand has been withdrawn.")]
    Withdrawn = UndertakingStatusCode.Withdrawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change to counter-undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTC&quot;.
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_Emv1Fq-yEeGNi5z8K_XPKQ")]
    [Description(@"Change to counter-undertaking amount.")]
    CounterUndertakingAmountChange = UndertakingStatusCode.CounterUndertakingAmountChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change to undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTU&quot;.
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_FA0h9q-yEeGNi5z8K_XPKQ")]
    [Description(@"Change to undertaking amount.")]
    UndertakingAmountChange = UndertakingStatusCode.UndertakingAmountChange, // same ordinal as derivation source for type conversions
}
