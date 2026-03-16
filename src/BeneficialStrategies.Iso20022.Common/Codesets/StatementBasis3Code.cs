// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the basis on which the statement is prepared expressed as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qaaAUMRxEeij-rSPpvD-Tw")]
[Description(@"Specifies the basis on which the statement is prepared expressed as a code.")]
[DerivedFrom(typeof(StatementBasisCode))]
public enum StatementBasis3Code
{
    /// <summary>
    /// Mark-to-Market report sent after settlement. All transactions which have been initiated.
    /// Encoded/decoded by serializers as &quot;EOSP&quot;.
    /// </summary>
    [EnumMember(Value = "EOSP")]
    [IsoId("_s7hSMcRxEeij-rSPpvD-Tw")]
    [Description(
        @"Mark-to-Market report sent after settlement. All transactions which have been initiated."
    )]
    EndOfSettlementPositions = StatementBasisCode.EndOfSettlementPositions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions.
    /// Encoded/decoded by serializers as &quot;FUTM&quot;.
    /// </summary>
    [EnumMember(Value = "FUTM")]
    [IsoId("_tDs90cRxEeij-rSPpvD-Tw")]
    [Description(
        @"Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions."
    )]
    FutureMarkToMarket = StatementBasisCode.FutureMarkToMarket, // same ordinal as derivation source for type conversions
}
