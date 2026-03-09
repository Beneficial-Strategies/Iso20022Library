// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash settlement system used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7MgRNp-Ed-ak6NoX_4Aeg_-811883421")]
[Description(@"Specifies the cash settlement system used.")]
[DerivedFrom(typeof(CashSettlementSystemCode))]
public enum CashSettlementSystem1Code
{
    /// <summary>
    /// Settle money through Bank of Korea Wire.
    /// Encoded/decoded by serializers as &quot;BOKW&quot;.
    /// </summary>
    [EnumMember(Value = "BOKW")]
    [IsoId("_a7MgRdp-Ed-ak6NoX_4Aeg_-523743781")]
    [Description(@"Settle money through Bank of Korea Wire.")]
    BankOfKoreaWire = CashSettlementSystemCode.BankOfKoreaWire, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through cheque.
    /// Encoded/decoded by serializers as &quot;CHEC&quot;.
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_a7MgRtp-Ed-ak6NoX_4Aeg_-462790539")]
    [Description(@"Settle money through cheque.")]
    Cheque = CashSettlementSystemCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through UK domestic.
    /// Encoded/decoded by serializers as &quot;GBSC&quot;.
    /// </summary>
    [EnumMember(Value = "GBSC")]
    [IsoId("_a7MgR9p-Ed-ak6NoX_4Aeg_-461866430")]
    [Description(@"Settle money through UK domestic.")]
    UKDomestic = CashSettlementSystemCode.UKDomestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through gross settlement system.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_a7MgSNp-Ed-ak6NoX_4Aeg_-454477927")]
    [Description(@"Settle money through gross settlement system.")]
    GrossSettlementSystem = CashSettlementSystemCode.GrossSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through net settlement system.
    /// Encoded/decoded by serializers as &quot;NETS&quot;.
    /// </summary>
    [EnumMember(Value = "NETS")]
    [IsoId("_a7WRQNp-Ed-ak6NoX_4Aeg_-453554748")]
    [Description(@"Settle money through net settlement system.")]
    NetSettlementSystem = CashSettlementSystemCode.NetSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through CHIPS (US).
    /// Encoded/decoded by serializers as &quot;USCH&quot;.
    /// </summary>
    [EnumMember(Value = "USCH")]
    [IsoId("_a7WRQdp-Ed-ak6NoX_4Aeg_-452631692")]
    [Description(@"Settle money through CHIPS (US).")]
    USChips = CashSettlementSystemCode.USChips, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settle money through Fedwire (US).
    /// Encoded/decoded by serializers as &quot;USFW&quot;.
    /// </summary>
    [EnumMember(Value = "USFW")]
    [IsoId("_a7WRQtp-Ed-ak6NoX_4Aeg_-449859823")]
    [Description(@"Settle money through Fedwire (US).")]
    FedWireUS = CashSettlementSystemCode.FedWireUS, // same ordinal as derivation source for type conversions
    
}
