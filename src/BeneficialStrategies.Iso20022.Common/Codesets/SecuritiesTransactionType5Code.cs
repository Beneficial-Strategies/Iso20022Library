// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZIwSQNp-Ed-ak6NoX_4Aeg_1800982665")]
[Description(@"Specifies underlying information regarding the type of transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
public enum SecuritiesTransactionType5Code
{
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZIwSQdp-Ed-ak6NoX_4Aeg_2040871426")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV2Code.Trade, // same ordinal as derivation source for type conversions
}
