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
[IsoId("_TRd1lgEcEeCQm6a_G2yO_w_-958842910")]
[Description(@"Specifies the incoterms, as published in an external incoterms code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalIncotermsCode))]
public enum ExternalIncoterms1Code
{
    /// <summary>
    /// Cost and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CFR&quot;.
    /// </summary>
    [EnumMember(Value = "CFR")]
    [IsoId("_uH-6UvRYEeuLhpyIdtJzwg")]
    [Description(@"Cost and Freight (sea and inland waterway transport) - Incoterms 2010")]
    CostAndFreight = ExternalIncotermsCode.CostAndFreight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CIF&quot;.
    /// </summary>
    [EnumMember(Value = "CIF")]
    [IsoId("_uH-6VfRYEeuLhpyIdtJzwg")]
    [Description(@"Cost, Insurance and Freight (sea and inland waterway transport) - Incoterms 2010")]
    CostInsuranceAndFreight = ExternalIncotermsCode.CostInsuranceAndFreight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CIP&quot;.
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_uIIrUvRYEeuLhpyIdtJzwg")]
    [Description(@"Carriage and Insurance Paid To (any mode of transport, including multimodal) - Incoterms 2010")]
    CarriageAndInsurancePaid = ExternalIncotermsCode.CarriageAndInsurancePaid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;CPT&quot;.
    /// </summary>
    [EnumMember(Value = "CPT")]
    [IsoId("_uIIrVfRYEeuLhpyIdtJzwg")]
    [Description(@"Carriage Paid To (any mode of transport, including multimodal) - Incoterms 2010")]
    CarriagePaid = ExternalIncotermsCode.CarriagePaid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DAP&quot;.
    /// </summary>
    [EnumMember(Value = "DAP")]
    [IsoId("_uIIrWPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivered at Place (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredAtPlace = ExternalIncotermsCode.DeliveredAtPlace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DAT&quot;.
    /// </summary>
    [EnumMember(Value = "DAT")]
    [IsoId("_uIIrW_RYEeuLhpyIdtJzwg")]
    [Description(@"Delivered at Terminal (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredAtTerminal = ExternalIncotermsCode.DeliveredAtTerminal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;DDP&quot;.
    /// </summary>
    [EnumMember(Value = "DDP")]
    [IsoId("_uIR1QvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivered Duty Paid (any mode of transport, including multimodal) - Incoterms 2010")]
    DeliveredDutyPaid = ExternalIncotermsCode.DeliveredDutyPaid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ex Works (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;EXW&quot;.
    /// </summary>
    [EnumMember(Value = "EXW")]
    [IsoId("_uIR1RfRYEeuLhpyIdtJzwg")]
    [Description(@"Ex Works (any mode of transport, including multimodal) - Incoterms 2010")]
    ExWorks = ExternalIncotermsCode.ExWorks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FAS&quot;.
    /// </summary>
    [EnumMember(Value = "FAS")]
    [IsoId("_uIR1SPRYEeuLhpyIdtJzwg")]
    [Description(@"Free Alongside Ship (sea and inland waterway transport) - Incoterms 2010")]
    FreeAlongsideShip = ExternalIncotermsCode.FreeAlongsideShip, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Free Carrier (any mode of transport, including multimodal) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FCA&quot;.
    /// </summary>
    [EnumMember(Value = "FCA")]
    [IsoId("_uIR1S_RYEeuLhpyIdtJzwg")]
    [Description(@"Free Carrier (any mode of transport, including multimodal) - Incoterms 2010")]
    FreeCarrier = ExternalIncotermsCode.FreeCarrier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Free On Board (sea and inland waterway transport) - Incoterms 2010
    /// Encoded/decoded by serializers as &quot;FOB&quot;.
    /// </summary>
    [EnumMember(Value = "FOB")]
    [IsoId("_uIR1TvRYEeuLhpyIdtJzwg")]
    [Description(@"Free On Board (sea and inland waterway transport) - Incoterms 2010")]
    FreeOnBoard = ExternalIncotermsCode.FreeOnBoard, // same ordinal as derivation source for type conversions
    
}
