// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the transaction is arranged via a third party broker or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jreAAHvREeWrWYBng3OpVw")]
[Description(@"Specifies whether the transaction is arranged via a third party broker or not.")]
[DerivedFrom(typeof(BrokeredDealCode))]
public enum BrokeredDeal1Code
{
    /// <summary>
    /// Transaction was arranged directly by the reporting agent.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_kvdzoXvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged directly by the reporting agent.")]
    BilateralTransaction = BrokeredDealCode.BilateralTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was arranged by a third party broking agent.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_k2VQoXvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged by a third party broking agent.||")]
    BrokeredTransaction = BrokeredDealCode.BrokeredTransaction, // same ordinal as derivation source for type conversions
}
