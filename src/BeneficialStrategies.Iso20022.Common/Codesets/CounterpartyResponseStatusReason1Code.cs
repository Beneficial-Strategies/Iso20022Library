// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of counterparty&apos;s action the response is related to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mWuhAlIEeGATtfOBToyew_-723419449")]
[Description(@"Specifies the type of counterparty's action the response is related to.")]
[DerivedFrom(typeof(CounterpartyResponseStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CounterpartyResponseStatusReason1Code>))]
#endif
public enum CounterpartyResponseStatusReason1Code
{
    /// <summary>
    /// Specifies that the response is related to an allegement from the counterparty.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_0mWuhQlIEeGATtfOBToyew_1912527419")]
    [Description(@"Specifies that the response is related to an allegement from the counterparty.")]
    CounterpartyTransaction = CounterpartyResponseStatusReasonCode.CounterpartyTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the response is related to the cancellation request of the counterparty.
    /// Encoded/decoded by serializers as &quot;CPCX&quot;.
    /// </summary>
    [EnumMember(Value = "CPCX")]
    [IsoId("_0mgfgAlIEeGATtfOBToyew_1029294132")]
    [Description(
        @"Specifies that the response is related to the cancellation request of the counterparty."
    )]
    CounterpartyCancellation = CounterpartyResponseStatusReasonCode.CounterpartyCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the response is related to the modification request of the counterparty.
    /// Encoded/decoded by serializers as &quot;CPMD&quot;.
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_0mgfgQlIEeGATtfOBToyew_2030398404")]
    [Description(
        @"Specifies that the response is related to the modification request of the counterparty."
    )]
    CounterpartyModification = CounterpartyResponseStatusReasonCode.CounterpartyModification, // same ordinal as derivation source for type conversions
}
