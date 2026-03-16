// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the incoterms, as published in an external incoterms code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9C-cIPeYEee0h5ZXun0VTA")]
[Description(
    @"Specifies the incoterms, as published in an external incoterms code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalIncoterms1Code))]
public enum ExternalIncotermsCode
{
    /// <summary>
    /// Cost and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CFR&quot;.
    /// </summary>
    [EnumMember(Value = "CFR")]
    [IsoId("_uH-6UPRYEeuLhpyIdtJzwg")]
    [Description(@"Cost and Freight (sea and inland waterway transport) - Incoterms 2010")]
    CostAndFreight,

    /// <summary>
    /// Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CIF&quot;.
    /// </summary>
    [EnumMember(Value = "CIF")]
    [IsoId("_uH-6U_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010"
    )]
    CostInsuranceAndFreight,

    /// <summary>
    /// Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CIP&quot;.
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_uIIrUPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010"
    )]
    CarriageAndInsurancePaid,

    /// <summary>
    /// Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CPT&quot;.
    /// </summary>
    [EnumMember(Value = "CPT")]
    [IsoId("_uIIrU_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010"
    )]
    CarriagePaid,

    /// <summary>
    /// Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DAP&quot;.
    /// </summary>
    [EnumMember(Value = "DAP")]
    [IsoId("_uIIrVvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010"
    )]
    DeliveredAtPlace,

    /// <summary>
    /// Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DAT&quot;.
    /// </summary>
    [EnumMember(Value = "DAT")]
    [IsoId("_uIIrWfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010"
    )]
    DeliveredAtTerminal,

    /// <summary>
    /// Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DDP&quot;.
    /// </summary>
    [EnumMember(Value = "DDP")]
    [IsoId("_uIR1QPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010"
    )]
    DeliveredDutyPaid,

    /// <summary>
    /// Ex Works (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;EXW&quot;.
    /// </summary>
    [EnumMember(Value = "EXW")]
    [IsoId("_uIR1Q_RYEeuLhpyIdtJzwg")]
    [Description(@"Ex Works (any mode of transport, including multimodal) - Incoterms 2010")]
    ExWorks,

    /// <summary>
    /// Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FAS&quot;.
    /// </summary>
    [EnumMember(Value = "FAS")]
    [IsoId("_uIR1RvRYEeuLhpyIdtJzwg")]
    [Description(@"Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010")]
    FreeAlongsideShip,

    /// <summary>
    /// Free Carrier (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FCA&quot;.
    /// </summary>
    [EnumMember(Value = "FCA")]
    [IsoId("_uIR1SfRYEeuLhpyIdtJzwg")]
    [Description(@"Free Carrier (any mode of transport, including multimodal) - Incoterms 2010")]
    FreeCarrier,

    /// <summary>
    /// Free On Board (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FOB&quot;.
    /// </summary>
    [EnumMember(Value = "FOB")]
    [IsoId("_uIR1TPRYEeuLhpyIdtJzwg")]
    [Description(@"Free On Board (sea and inland waterway transport) - Incoterms 2010")]
    FreeOnBoard,
}
