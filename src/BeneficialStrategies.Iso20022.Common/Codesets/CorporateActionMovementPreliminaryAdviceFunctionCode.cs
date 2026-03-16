// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EHaIYDQTEe2o-K1dwNg8Gg")]
[Description(
    @"Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message."
)]
[Derivations(typeof(CorporateActionMovementPreliminaryAdviceFunction1Code))]
public enum CorporateActionMovementPreliminaryAdviceFunctionCode
{
    /// <summary>
    /// Message is an entitlement.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_u2ONQDQTEe2o-K1dwNg8Gg")]
    [Description(@"Message is an entitlement.")]
    Entitlement,

    /// <summary>
    /// Message is a preadvice of movement.
    /// Encoded/decoded by serializers as &quot;CAPA&quot;.
    /// </summary>
    [EnumMember(Value = "CAPA")]
    [IsoId("_2oqO0DQTEe2o-K1dwNg8Gg")]
    [Description(@"Message is a preadvice of movement.")]
    PreadviceOfMovement,
}
