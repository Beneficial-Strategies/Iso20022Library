// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZP6DKNp-Ed-ak6NoX_4Aeg_-1755152860")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementBasisCode))]
public enum StatementBasis2Code
{
    /// <summary>
    /// The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZQD0INp-Ed-ak6NoX_4Aeg_-1755151069")]
    [Description(
        @"The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation."
    )]
    Settled = StatementBasisCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The statement is based on trade date positions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZQD0Idp-Ed-ak6NoX_4Aeg_-1755150482")]
    [Description(@"The statement is based on trade date positions.")]
    Traded = StatementBasisCode.Traded, // same ordinal as derivation source for type conversions
}
