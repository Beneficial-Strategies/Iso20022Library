// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwUkIdp-Ed-ak6NoX_4Aeg_-70363813")]
[Description(@"Defines when the trigger will hit, i.e. the action specified by the trigger instructions will come into effect.")]
[Derivations(typeof(TriggerType1Code))]
public enum TriggerTypeCode
{
    /// <summary>
    /// Trigger Instructions come into effect in case of partial execution.
    /// Encoded/decoded by serializers as &quot;PAEX&quot;.
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_YwUkItp-Ed-ak6NoX_4Aeg_45075403")]
    [Description(@"Trigger Instructions come into effect in case of partial execution.")]
    PartialExecution,
    
    /// <summary>
    /// Trigger Instructions come into effect at specified trading session.
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_YwUkI9p-Ed-ak6NoX_4Aeg_140198154")]
    [Description(@"Trigger Instructions come into effect at specified trading session.")]
    SpecifiedTradingSession,
    
    /// <summary>
    /// Trigger Instructions come into effect at next auction.
    /// Encoded/decoded by serializers as &quot;NEAU&quot;.
    /// </summary>
    [EnumMember(Value = "NEAU")]
    [IsoId("_YwUkJNp-Ed-ak6NoX_4Aeg_359997608")]
    [Description(@"Trigger Instructions come into effect at next auction.")]
    NextAuction,
    
    /// <summary>
    /// Trigger Instructions come into effect in case of price movement.
    /// Encoded/decoded by serializers as &quot;PRMO&quot;.
    /// </summary>
    [EnumMember(Value = "PRMO")]
    [IsoId("_YwUkJdp-Ed-ak6NoX_4Aeg_383086593")]
    [Description(@"Trigger Instructions come into effect in case of price movement.")]
    PriceMovement,
    
}
