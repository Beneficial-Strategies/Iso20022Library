// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proration when below the minimum quantity to instruct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MQkg4IDBEe-eGe8fbP3Zug")]
[Description(@"Specifies the type of proration when below the minimum quantity to instruct.")]
[DerivedFrom(typeof(ProrationBelowMinimumQuantityCode))]
public enum ProrationBelowMinimumQuantity1Code
{
    /// <summary>
    /// Instructions will be accepted in full (with their original quantity of securities instructed).
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted in full (with their original quantity of securities instructed)."
    )]
    AcceptedInFull = ProrationBelowMinimumQuantityCode.AcceptedInFull, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be accepted but prorated to the minimum quantity to instruct.
    /// Encoded/decoded by serializers as &quot;MIEX&quot;.
    /// </summary>
    [EnumMember(Value = "MIEX")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted but prorated to the minimum quantity to instruct."
    )]
    MinimumQuantity = ProrationBelowMinimumQuantityCode.MinimumQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be accepted but rounded up or down to the specified minimum multiple quantity to instruct according to the value of the disposition of fraction indicator.
    /// Encoded/decoded by serializers as &quot;MILT&quot;.
    /// </summary>
    [EnumMember(Value = "MILT")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted but rounded up or down to the specified minimum multiple quantity to instruct according to the value of the disposition of fraction indicator."
    )]
    MultipleQuantity = ProrationBelowMinimumQuantityCode.MultipleQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("")]
    [Description(@"Instructions will be rejected.")]
    Rejected = ProrationBelowMinimumQuantityCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of instructions prorated below the minimum quantity to instruct is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("")]
    [Description(
        @"Processing of instructions prorated below the minimum quantity to instruct is unknown."
    )]
    Unknown = ProrationBelowMinimumQuantityCode.Unknown, // same ordinal as derivation source for type conversions
}
