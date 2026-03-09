// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of measure of the item purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C1658Lb8EeabfchHYoktpA")]
[Description(@"Unit of measure of the item purchased.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
public enum UnitOfMeasure8Code
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_ElNGQbb8EeabfchHYoktpA")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = UnitOfMeasureCode.Kilogram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_EqQlYbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as &quot;KWDC&quot;.
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("_EvUrkbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.")]
    KilowattDayCapacity = UnitOfMeasureCode.KilowattDayCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as &quot;KWHO&quot;.
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_E3zSIbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure that is equal to the power consumption of one kilowatt during one hour.")]
    KilowattHours = UnitOfMeasureCode.KilowattHours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;KWHC&quot;.
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_E9wJIbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.")]
    KilowattHoursCapacity = UnitOfMeasureCode.KilowattHoursCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;KMOC&quot;.
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_FCEBYbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.")]
    KilowattMinuteCapacity = UnitOfMeasureCode.KilowattMinuteCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as &quot;KWMC&quot;.
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_FHIHkbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.")]
    KilowattMonthCapacity = UnitOfMeasureCode.KilowattMonthCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as &quot;KWYC&quot;.
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_FMehobb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.")]
    KilowattYearCapacity = UnitOfMeasureCode.KilowattYearCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LITR&quot;.
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_FSSOsbb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = UnitOfMeasureCode.Litre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as &quot;MWDC&quot;.
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_FYrKkbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.")]
    MegawattDayCapacity = UnitOfMeasureCode.MegawattDayCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as &quot;MWHO&quot;.
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_Ff-FYbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure that is equal to the power consumption of one megawatt during one hour.")]
    MegawattHours = UnitOfMeasureCode.MegawattHours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;MWHC&quot;.
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_FmgyQbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.")]
    MegawattHoursCapacity = UnitOfMeasureCode.MegawattHoursCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;MWMC&quot;.
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_Fs6VMbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.")]
    MegawattMinuteCapacity = UnitOfMeasureCode.MegawattMinuteCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as &quot;MMOC&quot;.
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_FyagQbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.")]
    MegawattMonthCapacity = UnitOfMeasureCode.MegawattMonthCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as &quot;MWYC&quot;.
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_F3xhYbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.")]
    MegawattYearCapacity = UnitOfMeasureCode.MegawattYearCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;METR&quot;.
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_F8PKobb8EeabfchHYoktpA")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = UnitOfMeasureCode.Metre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_GBlksbb8EeabfchHYoktpA")]
    [Description(@"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).")]
    MetricTons = UnitOfMeasureCode.MetricTons, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_GLHUIbb8EeabfchHYoktpA")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MILI&quot;.
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_GRELIbb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre = UnitOfMeasureCode.MilliLitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMET&quot;.
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_GxDSwbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = UnitOfMeasureCode.Millimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as &quot;MIBA&quot;.
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_G19n8bb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.")]
    MillionBarrels = UnitOfMeasureCode.MillionBarrels, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as &quot;MBTU&quot;.
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_G9_ikbb8EeabfchHYoktpA")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU = UnitOfMeasureCode.OneMillionBTU, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as &quot;PIEC&quot;.
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_HEGKkbb8EeabfchHYoktpA")]
    [Description(@"Standard length of cloth, wallpaper, as an item for sale or amount of a substance.")]
    Piece = UnitOfMeasureCode.Piece, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;PUND&quot;.
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_HJTasbb8EeabfchHYoktpA")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = UnitOfMeasureCode.Pound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as &quot;PWRD&quot;.
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_HN6N4bb8EeabfchHYoktpA")]
    [Description(@"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).")]
    PrincipalWithRelationToDebtInstrument = UnitOfMeasureCode.PrincipalWithRelationToDebtInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.
    /// Encoded/decoded by serializers as &quot;SHAS&quot;.
    /// </summary>
    [EnumMember(Value = "SHAS")]
    [IsoId("_HS-UEbb8EeabfchHYoktpA")]
    [Description(@"Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.")]
    Shares = UnitOfMeasureCode.Shares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;SCMT&quot;.
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_HdPDUbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = UnitOfMeasureCode.SquareCentimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;SQFO&quot;.
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_H-Qswbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = UnitOfMeasureCode.SquareFoot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;SQIN&quot;.
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_ICuWAbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = UnitOfMeasureCode.SquareInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;SQKI&quot;.
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_IMGUcbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = UnitOfMeasureCode.SquareKilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;SMET&quot;.
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_ISyyUbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = UnitOfMeasureCode.SquareMetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;SQMI&quot;.
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_IYACcbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = UnitOfMeasureCode.SquareMile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;SMIL&quot;.
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_IgVfEbb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = UnitOfMeasureCode.SquareMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;SQYA&quot;.
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_I4uw8bb8EeabfchHYoktpA")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = UnitOfMeasureCode.SquareYard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of heat, often used a unit of measure for natural gas in the UK.
    /// Encoded/decoded by serializers as &quot;THMS&quot;.
    /// </summary>
    [EnumMember(Value = "THMS")]
    [IsoId("_JAK1sbb8EeabfchHYoktpA")]
    [Description(@"Unit of heat, often used a unit of measure for natural gas in the UK.")]
    Therms = UnitOfMeasureCode.Therms, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;TONS&quot;.
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_JHT_gbb8EeabfchHYoktpA")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).")]
    Ton = UnitOfMeasureCode.Ton, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as &quot;TOCD&quot;.
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_JLet0bb8EeabfchHYoktpA")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide = UnitOfMeasureCode.TonsOfCarbonDioxide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as &quot;OZTR&quot;.
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_JPo1Ebb8EeabfchHYoktpA")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces = UnitOfMeasureCode.TroyOunces, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;USGA&quot;.
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_JU_2Mbb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon = UnitOfMeasureCode.USGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as &quot;UCWT&quot;.
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_JaNGUbb8EeabfchHYoktpA")]
    [Description(@"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.")]
    USHundredweight = UnitOfMeasureCode.USHundredweight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;USOU&quot;.
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_JiYx8bb8EeabfchHYoktpA")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce = UnitOfMeasureCode.USOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;USPI&quot;.
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_J01M0bb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = UnitOfMeasureCode.USPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;USQA&quot;.
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_J8IHobb8EeabfchHYoktpA")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart = UnitOfMeasureCode.USQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;YARD&quot;.
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_KBoSsbb8EeabfchHYoktpA")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = UnitOfMeasureCode.Yard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as &quot;ACRE&quot;.
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_myUSocB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre = UnitOfMeasureCode.Acre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as &quot;ALOW&quot;.
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_m6WNQcB6EeaOV5RqxXblNA")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances = UnitOfMeasureCode.Allowances, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as &quot;ACCY&quot;.
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_nCO98cB6EeaOV5RqxXblNA")]
    [Description(@"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.")]
    AmountOfCurrency = UnitOfMeasureCode.AmountOfCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_nJFM0cB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are = UnitOfMeasureCode.Are, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as &quot;BARL&quot;.
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_nQqbgcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels = UnitOfMeasureCode.Barrels, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as &quot;BCUF&quot;.
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_nnlGscB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.")]
    BillionCubicFeet = UnitOfMeasureCode.BillionCubicFeet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as &quot;BDFT&quot;.
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_nylc0cB6EeaOV5RqxXblNA")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet = UnitOfMeasureCode.BoardFeet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as &quot;BUSL&quot;.
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_n54XocB6EeaOV5RqxXblNA")]
    [Description(@"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.")]
    Bushels = UnitOfMeasureCode.Bushels, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CELI&quot;.
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_n_YiscB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = UnitOfMeasureCode.Centilitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_oJ8M4cB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre = UnitOfMeasureCode.Centimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as &quot;CEER&quot;.
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_oPATEcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.")]
    CertifiedEmissionsReduction = UnitOfMeasureCode.CertifiedEmissionsReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as &quot;CLRT&quot;.
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_oTULUcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.")]
    ClimateReserveTonnes = UnitOfMeasureCode.ClimateReserveTonnes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as &quot;CBME&quot;.
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_oXoqocB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.")]
    CubicMeters = UnitOfMeasureCode.CubicMeters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_oc_EscB6EeaOV5RqxXblNA")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days = UnitOfMeasureCode.Days, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as &quot;DGEU&quot;.
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_oiWF0cB6EeaOV5RqxXblNA")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent = UnitOfMeasureCode.DieselGallonEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as &quot;DMET&quot;.
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_oqFFgcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of weight that is equal to the same mass value as a metric ton excluding moisture.")]
    DryMetricTons = UnitOfMeasureCode.DryMetricTons, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as &quot;ENVC&quot;.
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_pNMZocB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).")]
    EnvironmentalCredit = UnitOfMeasureCode.EnvironmentalCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as &quot;ENVO&quot;.
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_pS_focB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.")]
    EnvironmentalOffset = UnitOfMeasureCode.EnvironmentalOffset, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_pYMvwcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = UnitOfMeasureCode.Foot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as &quot;GGEU&quot;.
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_peTXwcB6EeaOV5RqxXblNA")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent = UnitOfMeasureCode.GasolineGallonEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;GBGA&quot;.
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_pjW24cB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon = UnitOfMeasureCode.GBGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;GBOU&quot;.
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_pokHAcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce = UnitOfMeasureCode.GBOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;GBPI&quot;.
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_pu9p8cB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = UnitOfMeasureCode.GBPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;GBQA&quot;.
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_p2P9scB6EeaOV5RqxXblNA")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart = UnitOfMeasureCode.GBQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_qdrKEcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = UnitOfMeasureCode.Gram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as &quot;HECT&quot;.
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_qjxyEcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare = UnitOfMeasureCode.Hectare, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as &quot;HUWG&quot;.
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("_qo1RMcB6EeaOV5RqxXblNA")]
    [Description(@"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.")]
    Hundredweight = UnitOfMeasureCode.Hundredweight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INCH&quot;.
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_qufNQcB6EeaOV5RqxXblNA")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = UnitOfMeasureCode.Inch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as &quot;IPNT&quot;.
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_q2hH4cB6EeaOV5RqxXblNA")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint = UnitOfMeasureCode.IndexPoint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_pdC5ERYlEeelLcgBM3O-Qw")]
    [Description(@"Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.")]
    Future = UnitOfMeasureCode.Future, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_gBQ74UDsEemxGPEh9hU2Xg")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon = UnitOfMeasureCode.USTon, // same ordinal as derivation source for type conversions
    
}
