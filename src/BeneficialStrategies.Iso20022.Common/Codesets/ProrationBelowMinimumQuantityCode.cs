// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proration when below the minimum quantity to instruct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__9T08IC_Ee-eGe8fbP3Zug")]
[Description(@"Specifies the type of proration when below the minimum quantity to instruct.")]
[Derivations(typeof(ProrationBelowMinimumQuantity1Code))]
public enum ProrationBelowMinimumQuantityCode
{
    /// <summary>
    /// Instructions will be accepted in full (with their original quantity of securities).
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted in full (with their original quantity of securities)."
    )]
    AcceptedInFull,

    /// <summary>
    /// Instructions will be accepted but prorated to the minimum quantity to instruct.
    /// Encoded/decoded by serializers as &quot;MIEX&quot;.
    /// </summary>
    [EnumMember(Value = "MIEX")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted but prorated to the minimum quantity to instruct."
    )]
    MinimumQuantity,

    /// <summary>
    /// Instructions will be accepted but rounded up or down to the specified minimum multiple quantity.
    /// Encoded/decoded by serializers as &quot;MILT&quot;.
    /// </summary>
    [EnumMember(Value = "MILT")]
    [IsoId("")]
    [Description(
        @"Instructions will be accepted but rounded up or down to the specified minimum multiple quantity."
    )]
    MultipleQuantity,

    /// <summary>
    /// Instructions will be rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("")]
    [Description(@"Instructions will be rejected.")]
    Rejected,

    /// <summary>
    /// Processing of instructions prorated below the minimum quantity to instruct is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("")]
    [Description(
        @"Processing of instructions prorated below the minimum quantity to instruct is unknown."
    )]
    Unknown,
}
