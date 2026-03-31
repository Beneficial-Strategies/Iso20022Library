// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the transaction is arranged via a third party broker or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TXL5MHvREeWrWYBng3OpVw")]
[Description(@"Specifies whether the transaction is arranged via a third party broker or not.")]
[Derivations(typeof(BrokeredDeal1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BrokeredDealCode>))]
#endif
public enum BrokeredDealCode
{
    /// <summary>
    /// Transaction was arranged by a third party broking agent.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_WQ54UHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged by a third party broking agent.||")]
    BrokeredTransaction,

    /// <summary>
    /// Transaction was arranged directly by the reporting agent.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_WXrOsHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged directly by the reporting agent.")]
    BilateralTransaction,
}
