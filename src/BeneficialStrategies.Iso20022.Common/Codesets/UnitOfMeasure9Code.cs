// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aSoaEPE_Eee_LsXdoqzkWg")]
[Description(@"Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
public enum UnitOfMeasure9Code
{
    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_TPn04fFAEee_LsXdoqzkWg")]
    [Description(@"Code for a bag.")]
    Bag = UnitOfMeasureCode.Bag, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BALE&quot;.
    /// </summary>
    [EnumMember(Value = "BALE")]
    [IsoId("_X4ox8fFBEee_LsXdoqzkWg")]
    [Description(@"Code for a bale.")]
    Bale = UnitOfMeasureCode.Bale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BOTL&quot;.
    /// </summary>
    [EnumMember(Value = "BOTL")]
    [IsoId("_hNVQcfFBEee_LsXdoqzkWg")]
    [Description(@"Code for a bottle.")]
    Bottle = UnitOfMeasureCode.Bottle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BOXX&quot;.
    /// </summary>
    [EnumMember(Value = "BOXX")]
    [IsoId("_oNrGsfFBEee_LsXdoqzkWg")]
    [Description(@"Code for a box.")]
    Box = UnitOfMeasureCode.Box, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_vPLakfFBEee_LsXdoqzkWg")]
    [Description(@"Code for a carton.")]
    Carton = UnitOfMeasureCode.Carton, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CELI&quot;.
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_wtYd8fFBEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = UnitOfMeasureCode.Centilitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_wzY_UfFBEee_LsXdoqzkWg")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre = UnitOfMeasureCode.Centimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_B0nEofFCEee_LsXdoqzkWg")]
    [Description(@"Code for a container.")]
    Container = UnitOfMeasureCode.Container, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CRAT&quot;.
    /// </summary>
    [EnumMember(Value = "CRAT")]
    [IsoId("_6owrgfFNEee_LsXdoqzkWg")]
    [Description(@"Code for a crate.")]
    Crate = UnitOfMeasureCode.Crate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_LgZ-EfFOEee_LsXdoqzkWg")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch = UnitOfMeasureCode.CubicInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as &quot;CBME&quot;.
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_M_ytMfFOEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.")]
    CubicMeters = UnitOfMeasureCode.CubicMeters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;CBML&quot;.
    /// </summary>
    [EnumMember(Value = "CBML")]
    [IsoId("_vL4jEfFOEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre = UnitOfMeasureCode.CubicMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as &quot;PIEC&quot;.
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_2qAhgfFOEee_LsXdoqzkWg")]
    [Description(@"Standard length of cloth, wallpaper, as an item for sale or amount of a substance.")]
    Piece = UnitOfMeasureCode.Piece, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_9lCZ8fFOEee_LsXdoqzkWg")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = UnitOfMeasureCode.Foot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;GBFO&quot;.
    /// </summary>
    [EnumMember(Value = "GBFO")]
    [IsoId("_R0lccfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFuildOunce = UnitOfMeasureCode.GBFuildOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;GBGA&quot;.
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_TT1BofFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon = UnitOfMeasureCode.GBGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;GBPI&quot;.
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_UQooIfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = UnitOfMeasureCode.GBPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;GBQA&quot;.
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_W3hx4fFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart = UnitOfMeasureCode.GBQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in Britain 2240 lb (long ton).
    /// Encoded/decoded by serializers as &quot;GBTN&quot;.
    /// </summary>
    [EnumMember(Value = "GBTN")]
    [IsoId("_ie754fFPEee_LsXdoqzkWg")]
    [Description(@"Measure of weight, in Britain 2240 lb (long ton).")]
    GBTon = UnitOfMeasureCode.GBTon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_kWlYAfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = UnitOfMeasureCode.Gram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INCH&quot;.
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_lil4IfFPEee_LsXdoqzkWg")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = UnitOfMeasureCode.Inch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_m7lEUfFPEee_LsXdoqzkWg")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = UnitOfMeasureCode.Kilogram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_nCDfwfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LITR&quot;.
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_omqtIfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = UnitOfMeasureCode.Litre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;METR&quot;.
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_pDAq4fFPEee_LsXdoqzkWg")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = UnitOfMeasureCode.Metre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_pHoFIfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).")]
    MetricTons = UnitOfMeasureCode.MetricTons, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_qSTIgfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMET&quot;.
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_qvy80fFPEee_LsXdoqzkWg")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = UnitOfMeasureCode.Millimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MILI&quot;.
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_sR624fFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre = UnitOfMeasureCode.MilliLitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;PUND&quot;.
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_z6B3wfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = UnitOfMeasureCode.Pound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;USOU&quot;.
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_3YJkcfFPEee_LsXdoqzkWg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce = UnitOfMeasureCode.USOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;SCMT&quot;.
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_-SjKwfFPEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = UnitOfMeasureCode.SquareCentimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;SQFO&quot;.
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("__O0lwfFPEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = UnitOfMeasureCode.SquareFoot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;SQIN&quot;.
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("__TGBwfFPEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = UnitOfMeasureCode.SquareInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;SQKI&quot;.
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_ATMz4fFQEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = UnitOfMeasureCode.SquareKilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;SMET&quot;.
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_AXYwUfFQEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = UnitOfMeasureCode.SquareMetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;SQMI&quot;.
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_BcNqYfFQEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = UnitOfMeasureCode.SquareMile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;SMIL&quot;.
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_Bh_iQfFQEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = UnitOfMeasureCode.SquareMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;SQYA&quot;.
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_Bm86wfFQEee_LsXdoqzkWg")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = UnitOfMeasureCode.SquareYard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;USBA&quot;.
    /// </summary>
    [EnumMember(Value = "USBA")]
    [IsoId("_QJiacfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel = UnitOfMeasureCode.USBarrel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume equal to 2, 957353 centilitre.
    /// Encoded/decoded by serializers as &quot;USFO&quot;.
    /// </summary>
    [EnumMember(Value = "USFO")]
    [IsoId("_bO_r8fFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 2, 957353 centilitre.")]
    USFluidOunce = UnitOfMeasureCode.USFluidOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;USGA&quot;.
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_cfuUAfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon = UnitOfMeasureCode.USGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;USPI&quot;.
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_dSFlEfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = UnitOfMeasureCode.USPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;USQA&quot;.
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_ddSIcfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart = UnitOfMeasureCode.USQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_or7LIfFQEee_LsXdoqzkWg")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon = UnitOfMeasureCode.USTon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;YARD&quot;.
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_pwHMAfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = UnitOfMeasureCode.Yard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;GBOU&quot;.
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_3waeAfFQEee_LsXdoqzkWg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce = UnitOfMeasureCode.GBOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as &quot;ACRE&quot;.
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_Phd4YfFREee_LsXdoqzkWg")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre = UnitOfMeasureCode.Acre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_QL8YwfFREee_LsXdoqzkWg")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are = UnitOfMeasureCode.Are, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as &quot;HECT&quot;.
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_Yyq-AfFREee_LsXdoqzkWg")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare = UnitOfMeasureCode.Hectare, // same ordinal as derivation source for type conversions
    
}
