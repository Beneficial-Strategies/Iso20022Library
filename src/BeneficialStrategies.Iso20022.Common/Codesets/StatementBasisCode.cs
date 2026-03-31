// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQD0Itp-Ed-ak6NoX_4Aeg_836087748")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[Derivations(typeof(StatementBasis1Code), typeof(StatementBasis2Code), typeof(StatementBasis3Code))]
public enum StatementBasisCode
{
    /// <summary>
    /// The statement is based on contractual settlement date irrespective of settled data positions.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_ZQD0I9p-Ed-ak6NoX_4Aeg_1099290177")]
    [Description(
        @"The statement is based on contractual settlement date irrespective of settled data positions."
    )]
    Contractual,

    /// <summary>
    /// The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZQD0JNp-Ed-ak6NoX_4Aeg_1099290194")]
    [Description(
        @"The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation."
    )]
    Settled,

    /// <summary>
    /// The statement is based on trade date positions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZQD0Jdp-Ed-ak6NoX_4Aeg_1099290212")]
    [Description(@"The statement is based on trade date positions.")]
    Traded,

    /// <summary>
    /// Mark-to-Market report sent after settlement. All transactions which have been initiated.
    /// Encoded/decoded by serializers as &quot;EOSP&quot;.
    /// </summary>
    [EnumMember(Value = "EOSP")]
    [IsoId("_KGTm0MRxEeij-rSPpvD-Tw")]
    [Description(
        @"Mark-to-Market report sent after settlement. All transactions which have been initiated."
    )]
    EndOfSettlementPositions,

    /// <summary>
    /// Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions.
    /// Encoded/decoded by serializers as &quot;FUTM&quot;.
    /// </summary>
    [EnumMember(Value = "FUTM")]
    [IsoId("_fhZ2cMRxEeij-rSPpvD-Tw")]
    [Description(
        @"Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions."
    )]
    FutureMarkToMarket,
}
