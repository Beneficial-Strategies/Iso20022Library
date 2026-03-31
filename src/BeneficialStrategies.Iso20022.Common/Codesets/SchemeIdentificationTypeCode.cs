// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Domain of an identifier.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JJT9wLh0Eea3PLWeF1tJsQ")]
[Description(@"Domain of an identifier.")]
[Derivations(typeof(SchemeIdentificationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SchemeIdentificationTypeCode>))]
#endif
public enum SchemeIdentificationTypeCode
{
    /// <summary>
    /// Construct under a CCP rulebook where the losses of all positions registered to the account can be used to offset losses of any other position on that account upon the default of the clearing member guaranteeing the performance of such account.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_aEFc0Lh0Eea3PLWeF1tJsQ")]
    [Description(
        @"Construct under a CCP rulebook where the losses of all positions registered to the account can be used to offset losses of any other position on that account upon the default of the clearing member guaranteeing the performance of such account."
    )]
    Account,

    /// <summary>
    /// Legal entity that is a participant in a clearing service of a central counterparty, that is the legal counterparty to all novated trades for all the accounts associated with such counterparty.
    /// Encoded/decoded by serializers as &quot;CLIM&quot;.
    /// </summary>
    [EnumMember(Value = "CLIM")]
    [IsoId("_xccDULh0Eea3PLWeF1tJsQ")]
    [Description(
        @"Legal entity that is a participant in a clearing service of a central counterparty, that is the legal counterparty to all novated trades for all the accounts associated with such counterparty."
    )]
    ClearingMemberAccount,

    /// <summary>
    /// Legal entity that clears trades through a client account of a clearing member of a central counterparty.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_8NHXoLh0Eea3PLWeF1tJsQ")]
    [Description(
        @"Legal entity that clears trades through a client account of a clearing member of a central counterparty."
    )]
    Client,

    /// <summary>
    /// Replay of historical events or other set of hypothetical conditions designed to assess the performance of a portfolio of financial instruments.
    /// Encoded/decoded by serializers as &quot;SCEN&quot;.
    /// </summary>
    [EnumMember(Value = "SCEN")]
    [IsoId("_CQOJkLh1Eea3PLWeF1tJsQ")]
    [Description(
        @"Replay of historical events or other set of hypothetical conditions designed to assess the performance of a portfolio of financial instruments."
    )]
    Scenario,

    /// <summary>
    /// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
    /// Encoded/decoded by serializers as &quot;POSI&quot;.
    /// </summary>
    [EnumMember(Value = "POSI")]
    [IsoId("_QHoakHa9Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy."
    )]
    PositionAccount,

    /// <summary>
    /// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_VhKEAHa9Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty."
    )]
    CollateralAccount,

    /// <summary>
    /// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Y62jsHa9Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis."
    )]
    MarginAccount,
}
