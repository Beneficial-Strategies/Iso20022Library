// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0dI9wJX5EeWMQt4mOczoDw")]
[Description(@"Indicates the type of integration of the POI terminal in the sale environment.")]
[DerivedFrom(typeof(LocationCategoryCode))]
public enum LocationCategory3Code
{
    /// <summary>
    /// Indoor terminal.
    /// Encoded/decoded by serializers as &quot;INDR&quot;.
    /// </summary>
    [EnumMember(Value = "INDR")]
    [IsoId("_3wtnUZX5EeWMQt4mOczoDw")]
    [Description(@"Indoor terminal.")]
    Indoor = LocationCategoryCode.Indoor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal incorporated in the pump dispensing petrol.
    /// Encoded/decoded by serializers as &quot;IPMP&quot;.
    /// </summary>
    [EnumMember(Value = "IPMP")]
    [IsoId("_34m_EZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal incorporated in the pump dispensing petrol.")]
    InsidePump = LocationCategoryCode.InsidePump, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;MPOI&quot;.
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_4HaQEZX5EeWMQt4mOczoDw")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal = LocationCategoryCode.MultiplePOITerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Outdoor terminal serving several petrol pumps.
    /// Encoded/decoded by serializers as &quot;MPMP&quot;.
    /// </summary>
    [EnumMember(Value = "MPMP")]
    [IsoId("_4QWwsZX5EeWMQt4mOczoDw")]
    [Description(@"Outdoor terminal serving several petrol pumps.")]
    MultiplePump = LocationCategoryCode.MultiplePump, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as &quot;MSLE&quot;.
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_4ZllMZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal = LocationCategoryCode.MultipleSaleTerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;SSLE&quot;.
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_4oC38ZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal = LocationCategoryCode.SingleSaleTerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal integrated in a vending machine.
    /// Encoded/decoded by serializers as &quot;VNDG&quot;.
    /// </summary>
    [EnumMember(Value = "VNDG")]
    [IsoId("_4up2QZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal integrated in a vending machine.")]
    VendingMachine = LocationCategoryCode.VendingMachine, // same ordinal as derivation source for type conversions
}
