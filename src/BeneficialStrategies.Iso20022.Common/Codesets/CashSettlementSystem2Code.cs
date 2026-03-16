// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash settlement system used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7WRQ9p-Ed-ak6NoX_4Aeg_408258420")]
[Description(@"Specifies the cash settlement system used.")]
[DerivedFrom(typeof(CashSettlementSystemCode))]
public enum CashSettlementSystem2Code
{
    /// <summary>
    /// Settle money through gross settlement system.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_a7WRRNp-Ed-ak6NoX_4Aeg_-702652999")]
    [Description(@"Settle money through gross settlement system.")]
    GrossSettlementSystem = CashSettlementSystemCode.GrossSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settle money through net settlement system.
    /// Encoded/decoded by serializers as &quot;NETS&quot;.
    /// </summary>
    [EnumMember(Value = "NETS")]
    [IsoId("_a7WRRdp-Ed-ak6NoX_4Aeg_1056453502")]
    [Description(@"Settle money through net settlement system.")]
    NetSettlementSystem = CashSettlementSystemCode.NetSettlementSystem, // same ordinal as derivation source for type conversions
}
