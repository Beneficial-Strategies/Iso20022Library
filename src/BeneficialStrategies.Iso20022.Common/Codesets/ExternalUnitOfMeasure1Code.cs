// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nN1oMDNmEe2UWZuK9pqFtg")]
[Description(
    @"Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalUnitOfMeasureCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalUnitOfMeasure1Code>))]
#endif
public enum ExternalUnitOfMeasure1Code
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_nPi4YTNmEe2UWZuK9pqFtg")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = ExternalUnitOfMeasureCode.Kilogram, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as &quot;PIEC&quot;.
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_nPi4YzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Standard length of cloth, wallpaper, as an item for sale or amount of a substance."
    )]
    Piece = ExternalUnitOfMeasureCode.Piece, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;TONS&quot;.
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_nPi4ZTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton)."
    )]
    Ton = ExternalUnitOfMeasureCode.Ton, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;METR&quot;.
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_nPi4ZzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = ExternalUnitOfMeasureCode.Metre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INCH&quot;.
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_nPi4aTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = ExternalUnitOfMeasureCode.Inch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;YARD&quot;.
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_nPi4azNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = ExternalUnitOfMeasureCode.Yard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;GBGA&quot;.
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_nPi4bTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon = ExternalUnitOfMeasureCode.GBGallon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_nPi4bzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = ExternalUnitOfMeasureCode.Gram, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_nPi4cTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre = ExternalUnitOfMeasureCode.Centimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;SMET&quot;.
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_nPjfcTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = ExternalUnitOfMeasureCode.SquareMetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_nPjfczNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = ExternalUnitOfMeasureCode.Foot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_nPjfdTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = ExternalUnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;SQIN&quot;.
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_nPjfdzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = ExternalUnitOfMeasureCode.SquareInch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;SQFO&quot;.
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_nPjfeTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = ExternalUnitOfMeasureCode.SquareFoot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;SQMI&quot;.
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_nPjfezNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = ExternalUnitOfMeasureCode.SquareMile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;GBOU&quot;.
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_nPjffTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce = ExternalUnitOfMeasureCode.GBOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;USOU&quot;.
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_nPjffzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce = ExternalUnitOfMeasureCode.USOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;GBPI&quot;.
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_nPjfgTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = ExternalUnitOfMeasureCode.GBPint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;USPI&quot;.
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_nPjfgzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = ExternalUnitOfMeasureCode.USPint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;GBQA&quot;.
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_nPjfhTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart = ExternalUnitOfMeasureCode.GBQuart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;USQA&quot;.
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_nPjfhzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart = ExternalUnitOfMeasureCode.USQuart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;USGA&quot;.
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_nPjfiTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon = ExternalUnitOfMeasureCode.USGallon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMET&quot;.
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_nPjfizNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = ExternalUnitOfMeasureCode.Millimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_nPjfjTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = ExternalUnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;SQYA&quot;.
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_nPjfjzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = ExternalUnitOfMeasureCode.SquareYard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as &quot;ACRE&quot;.
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_nPjfkTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre = ExternalUnitOfMeasureCode.Acre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_nPjfkzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are = ExternalUnitOfMeasureCode.Are, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;SMIL&quot;.
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_nPjflTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = ExternalUnitOfMeasureCode.SquareMillimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;SCMT&quot;.
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_nPjflzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = ExternalUnitOfMeasureCode.SquareCentimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as &quot;HECT&quot;.
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_nPjfmTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare = ExternalUnitOfMeasureCode.Hectare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;SQKI&quot;.
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_nPjfmzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = ExternalUnitOfMeasureCode.SquareKilometre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MILI&quot;.
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_nPjfnTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre = ExternalUnitOfMeasureCode.MilliLitre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CELI&quot;.
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_nPjfnzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = ExternalUnitOfMeasureCode.Centilitre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LITR&quot;.
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_nPjfoTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = ExternalUnitOfMeasureCode.Litre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;PUND&quot;.
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_nPjfozNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = ExternalUnitOfMeasureCode.Pound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as &quot;ALOW&quot;.
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_nPjfpTNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances = ExternalUnitOfMeasureCode.Allowances, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as &quot;ACCY&quot;.
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_nPjfpzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217."
    )]
    AmountOfCurrency = ExternalUnitOfMeasureCode.AmountOfCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as &quot;BARL&quot;.
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_nPkGgTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels = ExternalUnitOfMeasureCode.Barrels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as &quot;BCUF&quot;.
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_nPkGgzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters."
    )]
    BillionCubicFeet = ExternalUnitOfMeasureCode.BillionCubicFeet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as &quot;BDFT&quot;.
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_nPkGhTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet = ExternalUnitOfMeasureCode.BoardFeet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as &quot;BUSL&quot;.
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_nPkGhzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently."
    )]
    Bushels = ExternalUnitOfMeasureCode.Bushels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as &quot;CEER&quot;.
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_nPkGiTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol."
    )]
    CertifiedEmissionsReduction = ExternalUnitOfMeasureCode.CertifiedEmissionsReduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as &quot;CLRT&quot;.
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_nPkGizNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered."
    )]
    ClimateReserveTonnes = ExternalUnitOfMeasureCode.ClimateReserveTonnes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as &quot;CBME&quot;.
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_nPkGjTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters."
    )]
    CubicMeters = ExternalUnitOfMeasureCode.CubicMeters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_nPkGjzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days = ExternalUnitOfMeasureCode.Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as &quot;DMET&quot;.
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_nPkGkTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of weight that is equal to the same mass value as a metric ton excluding moisture."
    )]
    DryMetricTons = ExternalUnitOfMeasureCode.DryMetricTons, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as &quot;ENVC&quot;.
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_nPkGkzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton)."
    )]
    EnvironmentalCredit = ExternalUnitOfMeasureCode.EnvironmentalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as &quot;ENVO&quot;.
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_nPkGlTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit."
    )]
    EnvironmentalOffset = ExternalUnitOfMeasureCode.EnvironmentalOffset, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as &quot;HUWG&quot;.
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("_nPkGlzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum."
    )]
    Hundredweight = ExternalUnitOfMeasureCode.Hundredweight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as &quot;KWDC&quot;.
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("_nPkGmTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day."
    )]
    KilowattDayCapacity = ExternalUnitOfMeasureCode.KilowattDayCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as &quot;KWHO&quot;.
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_nPkGmzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one kilowatt during one hour."
    )]
    KilowattHours = ExternalUnitOfMeasureCode.KilowattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;KWHC&quot;.
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_nPkGnTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour."
    )]
    KilowattHoursCapacity = ExternalUnitOfMeasureCode.KilowattHoursCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;KMOC&quot;.
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_nPkGnzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute."
    )]
    KilowattMinuteCapacity = ExternalUnitOfMeasureCode.KilowattMinuteCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as &quot;KWMC&quot;.
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_nPkGoTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month."
    )]
    KilowattMonthCapacity = ExternalUnitOfMeasureCode.KilowattMonthCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as &quot;KWYC&quot;.
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_nPkGozNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year."
    )]
    KilowattYearCapacity = ExternalUnitOfMeasureCode.KilowattYearCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as &quot;MWDC&quot;.
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_nPkGpTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day."
    )]
    MegawattDayCapacity = ExternalUnitOfMeasureCode.MegawattDayCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as &quot;MWHO&quot;.
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_nPkGpzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one megawatt during one hour."
    )]
    MegawattHours = ExternalUnitOfMeasureCode.MegawattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;MWHC&quot;.
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_nPkGqTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour."
    )]
    MegawattHoursCapacity = ExternalUnitOfMeasureCode.MegawattHoursCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;MWMC&quot;.
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_nPkGqzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute."
    )]
    MegawattMinuteCapacity = ExternalUnitOfMeasureCode.MegawattMinuteCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as &quot;MMOC&quot;.
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_nPkGrTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month."
    )]
    MegawattMonthCapacity = ExternalUnitOfMeasureCode.MegawattMonthCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as &quot;MWYC&quot;.
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_nPkGrzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year."
    )]
    MegawattYearCapacity = ExternalUnitOfMeasureCode.MegawattYearCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_nPkGsTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial)."
    )]
    MetricTons = ExternalUnitOfMeasureCode.MetricTons, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as &quot;MIBA&quot;.
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_nPkGszNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons."
    )]
    MillionBarrels = ExternalUnitOfMeasureCode.MillionBarrels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as &quot;MBTU&quot;.
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_nPkGtTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU = ExternalUnitOfMeasureCode.OneMillionBTU, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as &quot;OZTR&quot;.
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_nPkGtzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces = ExternalUnitOfMeasureCode.TroyOunces, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as &quot;UCWT&quot;.
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_nPkGuTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs."
    )]
    USHundredweight = ExternalUnitOfMeasureCode.USHundredweight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as &quot;IPNT&quot;.
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_nPkGuzNmEe2UWZuK9pqFtg")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint = ExternalUnitOfMeasureCode.IndexPoint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as &quot;PWRD&quot;.
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_nPkGvTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest)."
    )]
    PrincipalWithRelationToDebtInstrument =
        ExternalUnitOfMeasureCode.PrincipalWithRelationToDebtInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as &quot;DGEU&quot;.
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_nPkGvzNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent = ExternalUnitOfMeasureCode.DieselGallonEquivalent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as &quot;GGEU&quot;.
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_nPkGwTNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent = ExternalUnitOfMeasureCode.GasolineGallonEquivalent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as &quot;TOCD&quot;.
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_nPkGwzNmEe2UWZuK9pqFtg")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide = ExternalUnitOfMeasureCode.TonsOfCarbonDioxide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.
    /// Encoded/decoded by serializers as &quot;SHAS&quot;.
    /// </summary>
    [EnumMember(Value = "SHAS")]
    [IsoId("_nPkGxTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy."
    )]
    Shares = ExternalUnitOfMeasureCode.Shares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of heat, often used a unit of measure for natural gas in the UK.
    /// Encoded/decoded by serializers as &quot;THMS&quot;.
    /// </summary>
    [EnumMember(Value = "THMS")]
    [IsoId("_nPkGxzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of heat, often used a unit of measure for natural gas in the UK.")]
    Therms = ExternalUnitOfMeasureCode.Therms, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_nPkGyTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future."
    )]
    Future = ExternalUnitOfMeasureCode.Future, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one Gigawatt during one hour.
    /// Encoded/decoded by serializers as &quot;GWHO&quot;.
    /// </summary>
    [EnumMember(Value = "GWHO")]
    [IsoId("_nPkGyzNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one Gigawatt during one hour."
    )]
    GigawattHours = ExternalUnitOfMeasureCode.GigawattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit.
    /// Encoded/decoded by serializers as &quot;BRTU&quot;.
    /// </summary>
    [EnumMember(Value = "BRTU")]
    [IsoId("_nPkGzTNmEe2UWZuK9pqFtg")]
    [Description(
        @"Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit."
    )]
    BritishThermalUnit = ExternalUnitOfMeasureCode.BritishThermalUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication of the unit of measurement.
    /// Encoded/decoded by serializers as &quot;LOTS&quot;.
    /// </summary>
    [EnumMember(Value = "LOTS")]
    [IsoId("_nPkGzzNmEe2UWZuK9pqFtg")]
    [Description(@"Indication of the unit of measurement.")]
    Lot = ExternalUnitOfMeasureCode.Lot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_nPkG0TNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bag.")]
    Bag = ExternalUnitOfMeasureCode.Bag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BALE&quot;.
    /// </summary>
    [EnumMember(Value = "BALE")]
    [IsoId("_nPkG0zNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bale.")]
    Bale = ExternalUnitOfMeasureCode.Bale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BOTL&quot;.
    /// </summary>
    [EnumMember(Value = "BOTL")]
    [IsoId("_nPkG1TNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bottle.")]
    Bottle = ExternalUnitOfMeasureCode.Bottle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BOXX&quot;.
    /// </summary>
    [EnumMember(Value = "BOXX")]
    [IsoId("_nPkG1zNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a box.")]
    Box = ExternalUnitOfMeasureCode.Box, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_nPkG2TNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a carton.")]
    Carton = ExternalUnitOfMeasureCode.Carton, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_nPkG2zNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a container.")]
    Container = ExternalUnitOfMeasureCode.Container, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CRAT&quot;.
    /// </summary>
    [EnumMember(Value = "CRAT")]
    [IsoId("_nPkG3TNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a crate.")]
    Crate = ExternalUnitOfMeasureCode.Crate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_nPkG3zNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch = ExternalUnitOfMeasureCode.CubicInch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;CBML&quot;.
    /// </summary>
    [EnumMember(Value = "CBML")]
    [IsoId("_nPktkTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre = ExternalUnitOfMeasureCode.CubicMillimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;GBFO&quot;.
    /// </summary>
    [EnumMember(Value = "GBFO")]
    [IsoId("_nPktkzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFuildOunce = ExternalUnitOfMeasureCode.GBFuildOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in Britain 2240 lb (long ton).
    /// Encoded/decoded by serializers as &quot;GBTN&quot;.
    /// </summary>
    [EnumMember(Value = "GBTN")]
    [IsoId("_nPktlTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of weight, in Britain 2240 lb (long ton).")]
    GBTon = ExternalUnitOfMeasureCode.GBTon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;USBA&quot;.
    /// </summary>
    [EnumMember(Value = "USBA")]
    [IsoId("_nPktlzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel = ExternalUnitOfMeasureCode.USBarrel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 2, 957353 centilitre.
    /// Encoded/decoded by serializers as &quot;USFO&quot;.
    /// </summary>
    [EnumMember(Value = "USFO")]
    [IsoId("_nPktmTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 2, 957353 centilitre.")]
    USFluidOunce = ExternalUnitOfMeasureCode.USFluidOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_nPktmzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon = ExternalUnitOfMeasureCode.USTon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cooling degree day
    /// Encoded/decoded by serializers as &quot;CDDA&quot;.
    /// </summary>
    [EnumMember(Value = "CDDA")]
    [IsoId("_nPktnTNmEe2UWZuK9pqFtg")]
    [Description(@"Cooling degree day")]
    CoolingDegreeDay = ExternalUnitOfMeasureCode.CoolingDegreeDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Heating degree day
    /// Encoded/decoded by serializers as &quot;HDDA&quot;.
    /// </summary>
    [EnumMember(Value = "HDDA")]
    [IsoId("_nPktnzNmEe2UWZuK9pqFtg")]
    [Description(@"Heating degree day")]
    HeatingDegreeDay = ExternalUnitOfMeasureCode.HeatingDegreeDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Critical precipitation day
    /// Encoded/decoded by serializers as &quot;CPDA&quot;.
    /// </summary>
    [EnumMember(Value = "CPDA")]
    [IsoId("_nPktoTNmEe2UWZuK9pqFtg")]
    [Description(@"Critical precipitation day")]
    CriticalPrecipitationDay = ExternalUnitOfMeasureCode.CriticalPrecipitationDay, // same ordinal as derivation source for type conversions
}
