// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash settlement system used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7WRRtp-Ed-ak6NoX_4Aeg_-901576222")]
[Description(@"Specifies the cash settlement system used.")]
[Derivations(typeof(CashSettlementSystem2Code), typeof(CashSettlementSystem1Code))]
public enum CashSettlementSystemCode
{
    /// <summary>
    /// Settle money through Bank of Korea Wire.
    /// Encoded/decoded by serializers as &quot;BOKW&quot;.
    /// </summary>
    [EnumMember(Value = "BOKW")]
    [IsoId("_a7WRR9p-Ed-ak6NoX_4Aeg_-901576197")]
    [Description(@"Settle money through Bank of Korea Wire.")]
    BankOfKoreaWire,

    /// <summary>
    /// Settle money through cheque.
    /// Encoded/decoded by serializers as &quot;CHEC&quot;.
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_a7WRSNp-Ed-ak6NoX_4Aeg_-901576196")]
    [Description(@"Settle money through cheque.")]
    Cheque,

    /// <summary>
    /// Settle money through UK domestic.
    /// Encoded/decoded by serializers as &quot;GBSC&quot;.
    /// </summary>
    [EnumMember(Value = "GBSC")]
    [IsoId("_a7fbMNp-Ed-ak6NoX_4Aeg_-901576180")]
    [Description(@"Settle money through UK domestic.")]
    UKDomestic,

    /// <summary>
    /// Settle money through gross settlement system.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_a7fbMdp-Ed-ak6NoX_4Aeg_-901576179")]
    [Description(@"Settle money through gross settlement system.")]
    GrossSettlementSystem,

    /// <summary>
    /// Settle money through net settlement system.
    /// Encoded/decoded by serializers as &quot;NETS&quot;.
    /// </summary>
    [EnumMember(Value = "NETS")]
    [IsoId("_a7fbMtp-Ed-ak6NoX_4Aeg_-901576162")]
    [Description(@"Settle money through net settlement system.")]
    NetSettlementSystem,

    /// <summary>
    /// Settle money through CHIPS (US).
    /// Encoded/decoded by serializers as &quot;USCH&quot;.
    /// </summary>
    [EnumMember(Value = "USCH")]
    [IsoId("_a7fbM9p-Ed-ak6NoX_4Aeg_-901576137")]
    [Description(@"Settle money through CHIPS (US).")]
    USChips,

    /// <summary>
    /// Settle money through Fedwire (US).
    /// Encoded/decoded by serializers as &quot;USFW&quot;.
    /// </summary>
    [EnumMember(Value = "USFW")]
    [IsoId("_a7fbNNp-Ed-ak6NoX_4Aeg_-901576136")]
    [Description(@"Settle money through Fedwire (US).")]
    FedWireUS,
}
