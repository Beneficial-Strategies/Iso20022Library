// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A set of international standard trade terms (delivery terms) used to designate a point at which the costs and risks of transport are divided between the buyer and the seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWGPJNp-Ed-ak6NoX_4Aeg_-492158073")]
[Description(
    @"A set of international standard trade terms (delivery terms) used to designate a point at which the costs and risks of transport are divided between the buyer and the seller."
)]
[DerivedFrom(typeof(IncotermsCode))]
public enum Incoterms1Code
{
    /// <summary>
    /// Ex Works (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;EXW&quot;.
    /// </summary>
    [EnumMember(Value = "EXW")]
    [IsoId("_aWGPJdp-Ed-ak6NoX_4Aeg_-435821229")]
    [Description(@"Ex Works (any mode of transport, including multimodal).")]
    ExWorks = IncotermsCode.ExWorks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Free Carrier (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;FCA&quot;.
    /// </summary>
    [EnumMember(Value = "FCA")]
    [IsoId("_aWGPJtp-Ed-ak6NoX_4Aeg_-435821204")]
    [Description(@"Free Carrier (any mode of transport, including multimodal).")]
    FreeCarrier = IncotermsCode.FreeCarrier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Free Alongside Ship (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;FAS&quot;.
    /// </summary>
    [EnumMember(Value = "FAS")]
    [IsoId("_aWGPJ9p-Ed-ak6NoX_4Aeg_-435821203")]
    [Description(@"Free Alongside Ship (sea and inland waterway transport).")]
    FreeAlongsideShip = IncotermsCode.FreeAlongsideShip, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Free On Board (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;FOB&quot;.
    /// </summary>
    [EnumMember(Value = "FOB")]
    [IsoId("_aWGPKNp-Ed-ak6NoX_4Aeg_-435820952")]
    [Description(@"Free On Board (sea and inland waterway transport).")]
    FreeOnBoard = IncotermsCode.FreeOnBoard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cost and Freight (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;CFR&quot;.
    /// </summary>
    [EnumMember(Value = "CFR")]
    [IsoId("_aWPZENp-Ed-ak6NoX_4Aeg_-435820935")]
    [Description(@"Cost and Freight (sea and inland waterway transport).")]
    CostAndFreight = IncotermsCode.CostAndFreight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cost, Insurance and Freight (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;CIF&quot;.
    /// </summary>
    [EnumMember(Value = "CIF")]
    [IsoId("_aWPZEdp-Ed-ak6NoX_4Aeg_-435820926")]
    [Description(@"Cost, Insurance and Freight (sea and inland waterway transport).")]
    CostInsuranceAndFreight = IncotermsCode.CostInsuranceAndFreight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Carriage Paid To (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;CPT&quot;.
    /// </summary>
    [EnumMember(Value = "CPT")]
    [IsoId("_aWPZEtp-Ed-ak6NoX_4Aeg_-435820892")]
    [Description(@"Carriage Paid To (any mode of transport, including multimodal).")]
    CarriagePaid = IncotermsCode.CarriagePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Carriage and Insurance Paid to (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;CIP&quot;.
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_aWPZE9p-Ed-ak6NoX_4Aeg_-435820875")]
    [Description(@"Carriage and Insurance Paid to (any mode of transport, including multimodal).")]
    CarriageAndInsurancePaid = IncotermsCode.CarriageAndInsurancePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivered At Frontier (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;DAF&quot;.
    /// </summary>
    [EnumMember(Value = "DAF")]
    [IsoId("_aWPZFNp-Ed-ak6NoX_4Aeg_-435820832")]
    [Description(@"Delivered At Frontier (any mode of transport, including multimodal).")]
    DeliveredAtFrontier = IncotermsCode.DeliveredAtFrontier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivered Ex Ship (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;DES&quot;.
    /// </summary>
    [EnumMember(Value = "DES")]
    [IsoId("_aWPZFdp-Ed-ak6NoX_4Aeg_-435820831")]
    [Description(@"Delivered Ex Ship (sea and inland waterway transport).")]
    DeliveredExShip = IncotermsCode.DeliveredExShip, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivered Ex Quay (sea and inland waterway transport).
    /// Encoded/decoded by serializers as &quot;DEQ&quot;.
    /// </summary>
    [EnumMember(Value = "DEQ")]
    [IsoId("_aWPZFtp-Ed-ak6NoX_4Aeg_-434900826")]
    [Description(@"Delivered Ex Quay (sea and inland waterway transport).")]
    DeliveredExQuay = IncotermsCode.DeliveredExQuay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivered Duty Unpaid (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;DDU&quot;.
    /// </summary>
    [EnumMember(Value = "DDU")]
    [IsoId("_aWPZF9p-Ed-ak6NoX_4Aeg_-434900825")]
    [Description(@"Delivered Duty Unpaid (any mode of transport, including multimodal).")]
    DeliveredDutyUnpaid = IncotermsCode.DeliveredDutyUnpaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivered Duty Paid (any mode of transport, including multimodal).
    /// Encoded/decoded by serializers as &quot;DDP&quot;.
    /// </summary>
    [EnumMember(Value = "DDP")]
    [IsoId("_aWPZGNp-Ed-ak6NoX_4Aeg_-434900808")]
    [Description(@"Delivered Duty Paid (any mode of transport, including multimodal).")]
    DeliveredDutyPaid = IncotermsCode.DeliveredDutyPaid, // same ordinal as derivation source for type conversions
}
