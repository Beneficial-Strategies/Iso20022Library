// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwKzJdp-Ed-ak6NoX_4Aeg_159326277")]
[Description(
    @"Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect."
)]
[DerivedFrom(typeof(TriggerTypeCode))]
public enum TriggerType1Code
{
    /// <summary>
    /// Trigger Instructions come into effect in case of partial execution.
    /// Encoded/decoded by serializers as &quot;PAEX&quot;.
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_YwKzJtp-Ed-ak6NoX_4Aeg_256297454")]
    [Description(@"Trigger Instructions come into effect in case of partial execution.")]
    PartialExecution = TriggerTypeCode.PartialExecution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger Instructions come into effect at specified trading session.
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_YwKzJ9p-Ed-ak6NoX_4Aeg_256297489")]
    [Description(@"Trigger Instructions come into effect at specified trading session.")]
    SpecifiedTradingSession = TriggerTypeCode.SpecifiedTradingSession, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger Instructions come into effect at next auction.
    /// Encoded/decoded by serializers as &quot;NEAU&quot;.
    /// </summary>
    [EnumMember(Value = "NEAU")]
    [IsoId("_YwKzKNp-Ed-ak6NoX_4Aeg_256297531")]
    [Description(@"Trigger Instructions come into effect at next auction.")]
    NextAuction = TriggerTypeCode.NextAuction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger Instructions come into effect in case of price movement.
    /// Encoded/decoded by serializers as &quot;PRMO&quot;.
    /// </summary>
    [EnumMember(Value = "PRMO")]
    [IsoId("_YwUkINp-Ed-ak6NoX_4Aeg_256297814")]
    [Description(@"Trigger Instructions come into effect in case of price movement.")]
    PriceMovement = TriggerTypeCode.PriceMovement, // same ordinal as derivation source for type conversions
}
