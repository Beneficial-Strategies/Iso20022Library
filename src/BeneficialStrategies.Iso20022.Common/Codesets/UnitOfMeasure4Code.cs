// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y3ne9dp-Ed-ak6NoX_4Aeg_735997635")]
[Description(@"Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.")]
[DerivedFrom(typeof(UnitOfMeasure2Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum UnitOfMeasure4Code
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KGM&quot;.
    /// </summary>
    [EnumMember(Value = "KGM")]
    [IsoId("_Y3ne9tp-Ed-ak6NoX_4Aeg_735997667")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = UnitOfMeasure2Code.Kilogram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of count defining the number of items regarded as separate units.
    /// Encoded/decoded by serializers as &quot;EA&quot;.
    /// </summary>
    [EnumMember(Value = "EA")]
    [IsoId("_Y3ne99p-Ed-ak6NoX_4Aeg_735997668")]
    [Description(@"Unit of count defining the number of items regarded as separate units.")]
    Each = UnitOfMeasure2Code.Each, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton).
    /// Encoded/decoded by serializers as &quot;LTN&quot;.
    /// </summary>
    [EnumMember(Value = "LTN")]
    [IsoId("_Y3ne-Np-Ed-ak6NoX_4Aeg_735997697")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton).")]
    GBTon = UnitOfMeasure2Code.GBTon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;MTR&quot;.
    /// </summary>
    [EnumMember(Value = "MTR")]
    [IsoId("_Y3ne-dp-Ed-ak6NoX_4Aeg_735997975")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = UnitOfMeasure2Code.Metre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INH&quot;.
    /// </summary>
    [EnumMember(Value = "INH")]
    [IsoId("_Y3xP8Np-Ed-ak6NoX_4Aeg_735998006")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = UnitOfMeasure2Code.Inch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;LY&quot;.
    /// </summary>
    [EnumMember(Value = "LY")]
    [IsoId("_Y3xP8dp-Ed-ak6NoX_4Aeg_735998007")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = UnitOfMeasure2Code.Yard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 GB pints.
    /// Encoded/decoded by serializers as &quot;GLI&quot;.
    /// </summary>
    [EnumMember(Value = "GLI")]
    [IsoId("_Y3xP8tp-Ed-ak6NoX_4Aeg_735998036")]
    [Description(@"Unit of volume that is equal to 8 GB pints.")]
    GBGallon = UnitOfMeasure2Code.GBGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRM&quot;.
    /// </summary>
    [EnumMember(Value = "GRM")]
    [IsoId("_Y3xP89p-Ed-ak6NoX_4Aeg_735998037")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = UnitOfMeasure2Code.Gram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One 100th part of a metre.
    /// Encoded/decoded by serializers as &quot;CMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMT")]
    [IsoId("_Y3xP9Np-Ed-ak6NoX_4Aeg_735998067")]
    [Description(@"One 100th part of a metre.")]
    Centimetre = UnitOfMeasure2Code.Centimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;MTK&quot;.
    /// </summary>
    [EnumMember(Value = "MTK")]
    [IsoId("_Y3xP9dp-Ed-ak6NoX_4Aeg_735998098")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = UnitOfMeasure2Code.SquareMetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOT")]
    [IsoId("_Y3xP9tp-Ed-ak6NoX_4Aeg_735998099")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = UnitOfMeasure2Code.Foot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;1A&quot;.
    /// </summary>
    [EnumMember(Value = "1A")]
    [IsoId("_Y3xP99p-Ed-ak6NoX_4Aeg_735998128")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasure2Code.Mile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;INK&quot;.
    /// </summary>
    [EnumMember(Value = "INK")]
    [IsoId("_Y37A8Np-Ed-ak6NoX_4Aeg_735998129")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = UnitOfMeasure2Code.SquareInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;FTK&quot;.
    /// </summary>
    [EnumMember(Value = "FTK")]
    [IsoId("_Y37A8dp-Ed-ak6NoX_4Aeg_735998159")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = UnitOfMeasure2Code.SquareFoot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;MIK&quot;.
    /// </summary>
    [EnumMember(Value = "MIK")]
    [IsoId("_Y37A8tp-Ed-ak6NoX_4Aeg_735998190")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = UnitOfMeasure2Code.SquareMile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;ONZ&quot;.
    /// </summary>
    [EnumMember(Value = "ONZ")]
    [IsoId("_Y37A89p-Ed-ak6NoX_4Aeg_735998191")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    Ounce = UnitOfMeasure2Code.Ounce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;PTI&quot;.
    /// </summary>
    [EnumMember(Value = "PTI")]
    [IsoId("_Y37A9Np-Ed-ak6NoX_4Aeg_735998213")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = UnitOfMeasure2Code.GBPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;PT&quot;.
    /// </summary>
    [EnumMember(Value = "PT")]
    [IsoId("_Y37A9dp-Ed-ak6NoX_4Aeg_735998221")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = UnitOfMeasure2Code.USPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 GB pints.
    /// Encoded/decoded by serializers as &quot;QTI&quot;.
    /// </summary>
    [EnumMember(Value = "QTI")]
    [IsoId("_Y37A9tp-Ed-ak6NoX_4Aeg_735998244")]
    [Description(@"Unit of volume that is equal to 2 GB pints.")]
    GBQuart = UnitOfMeasure2Code.GBQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 US pints.
    /// Encoded/decoded by serializers as &quot;QT&quot;.
    /// </summary>
    [EnumMember(Value = "QT")]
    [IsoId("_Y37A99p-Ed-ak6NoX_4Aeg_735998252")]
    [Description(@"Unit of volume that is equal to 2 US pints.")]
    USQuart = UnitOfMeasure2Code.USQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 US pints.
    /// Encoded/decoded by serializers as &quot;GLL&quot;.
    /// </summary>
    [EnumMember(Value = "GLL")]
    [IsoId("_Y37A-Np-Ed-ak6NoX_4Aeg_735998253")]
    [Description(@"Unit of volume that is equal to 8 US pints.")]
    USGallon = UnitOfMeasure2Code.USGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMT&quot;.
    /// </summary>
    [EnumMember(Value = "MMT")]
    [IsoId("_Y37A-dp-Ed-ak6NoX_4Aeg_735998491")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = UnitOfMeasure2Code.Millimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KTM&quot;.
    /// </summary>
    [EnumMember(Value = "KTM")]
    [IsoId("_Y4EK4Np-Ed-ak6NoX_4Aeg_735998492")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasure2Code.Kilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;YDK&quot;.
    /// </summary>
    [EnumMember(Value = "YDK")]
    [IsoId("_Y4EK4dp-Ed-ak6NoX_4Aeg_735998500")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = UnitOfMeasure2Code.SquareYard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;MMK&quot;.
    /// </summary>
    [EnumMember(Value = "MMK")]
    [IsoId("_Y4EK4tp-Ed-ak6NoX_4Aeg_735998522")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = UnitOfMeasure2Code.SquareMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;CMK&quot;.
    /// </summary>
    [EnumMember(Value = "CMK")]
    [IsoId("_Y4EK49p-Ed-ak6NoX_4Aeg_735998523")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = UnitOfMeasure2Code.SquareCentimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;KMK&quot;.
    /// </summary>
    [EnumMember(Value = "KMK")]
    [IsoId("_Y4EK5Np-Ed-ak6NoX_4Aeg_735998531")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = UnitOfMeasure2Code.SquareKilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MMQ&quot;.
    /// </summary>
    [EnumMember(Value = "MMQ")]
    [IsoId("_Y4EK5dp-Ed-ak6NoX_4Aeg_735998553")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre = UnitOfMeasure2Code.CubicMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CLT&quot;.
    /// </summary>
    [EnumMember(Value = "CLT")]
    [IsoId("_Y4EK5tp-Ed-ak6NoX_4Aeg_735998554")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = UnitOfMeasure2Code.Centilitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LTR&quot;.
    /// </summary>
    [EnumMember(Value = "LTR")]
    [IsoId("_Y4EK59p-Ed-ak6NoX_4Aeg_735998562")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = UnitOfMeasure2Code.Litre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;LBR&quot;.
    /// </summary>
    [EnumMember(Value = "LBR")]
    [IsoId("_Y4EK6Np-Ed-ak6NoX_4Aeg_735998583")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = UnitOfMeasure2Code.Pound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;STN&quot;.
    /// </summary>
    [EnumMember(Value = "STN")]
    [IsoId("_Y4EK6dp-Ed-ak6NoX_4Aeg_735998584")]
    [Description(@"Measure of weight, in the US 2000lb (short ton).")]
    USTon = UnitOfMeasure2Code.USTon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;BLL&quot;.
    /// </summary>
    [EnumMember(Value = "BLL")]
    [IsoId("_Y4EK6tp-Ed-ak6NoX_4Aeg_735998585")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel = UnitOfMeasure2Code.USBarrel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BX&quot;.
    /// </summary>
    [EnumMember(Value = "BX")]
    [IsoId("_Y4N74Np-Ed-ak6NoX_4Aeg_735998614")]
    [Description(@"Code for a box.")]
    Box = UnitOfMeasure2Code.Box, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BO&quot;.
    /// </summary>
    [EnumMember(Value = "BO")]
    [IsoId("_Y4N74dp-Ed-ak6NoX_4Aeg_735998615")]
    [Description(@"Code for a bottle.")]
    Bottle = UnitOfMeasure2Code.Bottle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CT&quot;.
    /// </summary>
    [EnumMember(Value = "CT")]
    [IsoId("_Y4N74tp-Ed-ak6NoX_4Aeg_735998616")]
    [Description(@"Code for a carton.")]
    Carton = UnitOfMeasure2Code.Carton, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CH&quot;.
    /// </summary>
    [EnumMember(Value = "CH")]
    [IsoId("_Y4N749p-Ed-ak6NoX_4Aeg_736918616")]
    [Description(@"Code for a container.")]
    Container = UnitOfMeasure2Code.Container, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CR&quot;.
    /// </summary>
    [EnumMember(Value = "CR")]
    [IsoId("_Y4N75Np-Ed-ak6NoX_4Aeg_736918625")]
    [Description(@"Code for a crate.")]
    Crate = UnitOfMeasure2Code.Crate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;INQ&quot;.
    /// </summary>
    [EnumMember(Value = "INQ")]
    [IsoId("_Y4N75dp-Ed-ak6NoX_4Aeg_736918626")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch = UnitOfMeasure2Code.CubicInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a volume, one meter by one meter by one meter.
    /// Encoded/decoded by serializers as &quot;MTQ&quot;.
    /// </summary>
    [EnumMember(Value = "MTQ")]
    [IsoId("_Y4N75tp-Ed-ak6NoX_4Aeg_736918646")]
    [Description(@"Measure of a volume, one meter by one meter by one meter.")]
    CubicMeter = UnitOfMeasure2Code.CubicMeter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;OZI&quot;.
    /// </summary>
    [EnumMember(Value = "OZI")]
    [IsoId("_Y4N759p-Ed-ak6NoX_4Aeg_736918647")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFluidOunce = UnitOfMeasure2Code.GBFluidOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 2, 957 353 centilitre.
    /// Encoded/decoded by serializers as &quot;OZA&quot;.
    /// </summary>
    [EnumMember(Value = "OZA")]
    [IsoId("_Y4N76Np-Ed-ak6NoX_4Aeg_736918656")]
    [Description(@"Unit of volume equal to 2, 957 353 centilitre.")]
    USFluidOunce = UnitOfMeasure2Code.USFluidOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BG&quot;.
    /// </summary>
    [EnumMember(Value = "BG")]
    [IsoId("_Y4N76dp-Ed-ak6NoX_4Aeg_736918657")]
    [Description(@"Code for a bag.")]
    Bag = UnitOfMeasure2Code.Bag, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BL&quot;.
    /// </summary>
    [EnumMember(Value = "BL")]
    [IsoId("_Y4XF0Np-Ed-ak6NoX_4Aeg_736918677")]
    [Description(@"Code for a bale.")]
    Bale = UnitOfMeasure2Code.Bale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, equal to 1000 kilograms.
    /// Encoded/decoded by serializers as &quot;TNE&quot;.
    /// </summary>
    [EnumMember(Value = "TNE")]
    [IsoId("_Y4XF0dp-Ed-ak6NoX_4Aeg_1231928752")]
    [Description(@"Measure of weight, equal to 1000 kilograms.")]
    MetricTon = UnitOfMeasure2Code.MetricTon, // same ordinal as derivation source for type conversions
    
}
