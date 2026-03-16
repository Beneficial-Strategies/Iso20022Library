// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZP6DJNp-Ed-ak6NoX_4Aeg_-957087736")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementBasisCode))]
public enum StatementBasis1Code
{
    /// <summary>
    /// The statement is based on contractual settlement date irrespective of settled data positions.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_ZP6DJdp-Ed-ak6NoX_4Aeg_-926610659")]
    [Description(
        @"The statement is based on contractual settlement date irrespective of settled data positions."
    )]
    Contractual = StatementBasisCode.Contractual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZP6DJtp-Ed-ak6NoX_4Aeg_-2028635093")]
    [Description(
        @"The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation."
    )]
    Settled = StatementBasisCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The statement is based on trade date positions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZP6DJ9p-Ed-ak6NoX_4Aeg_-2014783388")]
    [Description(@"The statement is based on trade date positions.")]
    Traded = StatementBasisCode.Traded, // same ordinal as derivation source for type conversions
}
