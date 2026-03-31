// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NGryILu7EeSXxOgurgHGgw")]
[Description(@"Specifies the type of securities transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesTransactionType15Code>))]
#endif
public enum SecuritiesTransactionType15Code
{
    /// <summary>
    /// Transaction is a purchase of financial instrument.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_U6o2obu7EeSXxOgurgHGgw")]
    [Description(@"Transaction is a purchase of financial instrument.")]
    Buy = SecuritiesTransactionTypeV3Code.Buy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a sale of financial instrument.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_XDPh4bu7EeSXxOgurgHGgw")]
    [Description(@"Transaction is a sale of financial instrument.")]
    Sell = SecuritiesTransactionTypeV3Code.Sell, // same ordinal as derivation source for type conversions
}
