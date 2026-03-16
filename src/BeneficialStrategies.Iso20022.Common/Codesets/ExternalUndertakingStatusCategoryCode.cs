// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-M07BW7iEeKo25nLKvGr8w_-365959647")]
[Description(
    @"Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUndertakingStatusCategory1Code))]
public enum ExternalUndertakingStatusCategoryCode
{
    /// <summary>
    /// Status is related to an undertaking amendment.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uRhQ2fRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment.")]
    Amendment,

    /// <summary>
    /// Status is related to a counter-undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTC&quot;.
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_uRrB0PRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to a counter-undertaking amount.")]
    CounterUndertakingAmountStatus,

    /// <summary>
    /// Status is related to an undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTU&quot;.
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_uRrB0_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amount.")]
    UndertakingAmountStatus,

    /// <summary>
    /// Status is related to an undertaking application.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uRrB1vRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking application.")]
    Application,

    /// <summary>
    /// Status is related to an undertaking amendment requested by the beneficiary.
    /// Encoded/decoded by serializers as &quot;BAMD&quot;.
    /// </summary>
    [EnumMember(Value = "BAMD")]
    [IsoId("_uRrB2fRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment requested by the beneficiary.")]
    BeneficiaryAmendment,

    /// <summary>
    /// Status is related to an undertaking confirmation.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uRrB3PRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking confirmation.")]
    Confirmation,

    /// <summary>
    /// Status is related to an undertaking demand.
    /// Encoded/decoded by serializers as &quot;DEMD&quot;.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uR0LwPRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking demand.")]
    Demand,

    /// <summary>
    /// Status is related to an undertaking non-extension request.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_uR0Lw_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking non-extension request.")]
    NonExtension,

    /// <summary>
    /// Status is related to an undertaking termination.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_uR0LxvRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking termination.")]
    Termination,
}
