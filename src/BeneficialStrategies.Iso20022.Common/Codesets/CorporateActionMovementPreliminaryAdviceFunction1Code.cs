// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IQ0_YDQUEe2o-K1dwNg8Gg")]
[Description(
    @"Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message."
)]
[DerivedFrom(typeof(CorporateActionMovementPreliminaryAdviceFunctionCode))]
public enum CorporateActionMovementPreliminaryAdviceFunction1Code
{
    /// <summary>
    /// Message is an entitlement.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_MkWqETQUEe2o-K1dwNg8Gg")]
    [Description(@"Message is an entitlement.")]
    Entitlement = CorporateActionMovementPreliminaryAdviceFunctionCode.Entitlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is a preadvice of movement.
    /// Encoded/decoded by serializers as &quot;CAPA&quot;.
    /// </summary>
    [EnumMember(Value = "CAPA")]
    [IsoId("_MzstojQUEe2o-K1dwNg8Gg")]
    [Description(@"Message is a preadvice of movement.")]
    PreadviceOfMovement = CorporateActionMovementPreliminaryAdviceFunctionCode.PreadviceOfMovement, // same ordinal as derivation source for type conversions
}
