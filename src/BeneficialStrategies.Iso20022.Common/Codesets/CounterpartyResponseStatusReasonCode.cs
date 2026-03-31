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
[IsoId("_0ldWpQlIEeGATtfOBToyew_2025918018")]
[Description(@"Specifies the type of counterparty's action the response is related to.")]
[Derivations(typeof(CounterpartyResponseStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CounterpartyResponseStatusReasonCode>))]
#endif
public enum CounterpartyResponseStatusReasonCode
{
    /// <summary>
    /// Specifies that the response is related to an allegement from the counterparty.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_0lnHoAlIEeGATtfOBToyew_-1081107811")]
    [Description(@"Specifies that the response is related to an allegement from the counterparty.")]
    CounterpartyTransaction,

    /// <summary>
    /// Specifies that the response is related to the cancellation request of the counterparty.
    /// Encoded/decoded by serializers as &quot;CPCX&quot;.
    /// </summary>
    [EnumMember(Value = "CPCX")]
    [IsoId("_0lnHoQlIEeGATtfOBToyew_-952865823")]
    [Description(
        @"Specifies that the response is related to the cancellation request of the counterparty."
    )]
    CounterpartyCancellation,

    /// <summary>
    /// Specifies that the response is related to the modification request of the counterparty.
    /// Encoded/decoded by serializers as &quot;CPMD&quot;.
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_0lnHoglIEeGATtfOBToyew_-1126679400")]
    [Description(
        @"Specifies that the response is related to the modification request of the counterparty."
    )]
    CounterpartyModification,
}
