// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the cash debit for the subscription charge is made immediately or accumulated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10dH5TL3EeKU9IrkkToqcw_-294723543")]
[Description(
    @"Indicates whether the cash debit for the subscription charge is made immediately or accumulated."
)]
[DerivedFrom(typeof(SubscriptionChargeApplicationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SubscriptionChargeApplicationType1Code>))]
#endif
public enum SubscriptionChargeApplicationType1Code
{
    /// <summary>
    /// Charges are accumulated and charged later.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_10dH5jL3EeKU9IrkkToqcw_800343679")]
    [Description(@"Charges are accumulated and charged later.")]
    Accumulated = SubscriptionChargeApplicationTypeCode.Accumulated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges are charged when instructed.
    /// Encoded/decoded by serializers as &quot;IMDT&quot;.
    /// </summary>
    [EnumMember(Value = "IMDT")]
    [IsoId("_10mR0DL3EeKU9IrkkToqcw_-2027474854")]
    [Description(@"Charges are charged when instructed.")]
    Immediate = SubscriptionChargeApplicationTypeCode.Immediate, // same ordinal as derivation source for type conversions
}
