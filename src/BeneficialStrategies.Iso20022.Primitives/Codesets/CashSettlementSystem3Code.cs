// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash settlement system used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IY8aMJZyEfC2_67yGLymgA")]
[Description(@"Specifies the cash settlement system used.")]
[DerivedFrom(typeof(CashSettlementSystemCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CashSettlementSystem3Code>))]
public enum CashSettlementSystem3Code
{
    /// <summary>
    /// Digital cash settlement system used for the payment.
    /// Encoded/decoded by serializers as &quot;DCSS&quot;.
    /// </summary>
    [EnumMember(Value = "DCSS")]
    [IsoId("_AS2qgSm3EfGfZ9PfK70MMg")]
    [Description(@"Digital cash settlement system used for the payment.")]
    DigitalCashSettlementSystem = CashSettlementSystemCode.DigitalCashSettlementSystem,

    /// <summary>
    /// Settle money through gross settlement system.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_AS2qgym3EfGfZ9PfK70MMg")]
    [Description(@"Settle money through gross settlement system.")]
    GrossSettlementSystem = CashSettlementSystemCode.GrossSettlementSystem,

    /// <summary>
    /// Settle money through net settlement system.
    /// Encoded/decoded by serializers as &quot;NETS&quot;.
    /// </summary>
    [EnumMember(Value = "NETS")]
    [IsoId("_AS2qhSm3EfGfZ9PfK70MMg")]
    [Description(@"Settle money through net settlement system.")]
    NetSettlementSystem = CashSettlementSystemCode.NetSettlementSystem,
}
