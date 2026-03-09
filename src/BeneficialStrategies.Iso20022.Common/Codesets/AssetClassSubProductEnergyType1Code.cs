// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for energy related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WAAh8M5AEeSc85GUbgBycw")]
[Description(@"Code list for energy related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductEnergyType1Code
{
    /// <summary>
    /// Commodity of type coal.
    /// Encoded/decoded by serializers as &quot;COAL&quot;.
    /// </summary>
    [EnumMember(Value = "COAL")]
    [IsoId("_flKPkc5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type coal.")]
    Coal = AssetClassSubProductTypeCode.Coal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type electricity.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_fuNd4c5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type electricity.")]
    Electricity = AssetClassSubProductTypeCode.Electricity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type oil.
    /// Encoded/decoded by serializers as &quot;OILP&quot;.
    /// </summary>
    [EnumMember(Value = "OILP")]
    [IsoId("_gLvucc5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type oil.")]
    Oil = AssetClassSubProductTypeCode.Oil, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type inter energy.
    /// Encoded/decoded by serializers as &quot;INRG&quot;.
    /// </summary>
    [EnumMember(Value = "INRG")]
    [IsoId("_gzJFoc5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type inter energy.")]
    InterEnergy = AssetClassSubProductTypeCode.InterEnergy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type natural gas.
    /// Encoded/decoded by serializers as &quot;NGAS&quot;.
    /// </summary>
    [EnumMember(Value = "NGAS")]
    [IsoId("_USGZAUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type natural gas.")]
    NaturalGas = AssetClassSubProductTypeCode.NaturalGas, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_UhRdcUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
