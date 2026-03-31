// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bm4kgOXuEemUbdOm9aOvMg")]
[Description(@"Identifies the unit of measure by means of a code.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnitOfMeasure12Code>))]
#endif
public enum UnitOfMeasure12Code
{
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as &quot;ACRE&quot;.
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_tVQiQexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre = UnitOfMeasureCode.Acre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as &quot;ALOW&quot;.
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_tdxlEexmEemioJdkOVFBdw")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances = UnitOfMeasureCode.Allowances, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as &quot;ACCY&quot;.
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_tjfykexmEemioJdkOVFBdw")]
    [Description(
        @"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217."
    )]
    AmountOfCurrency = UnitOfMeasureCode.AmountOfCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_tpwLkexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are = UnitOfMeasureCode.Are, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_tzv1EexmEemioJdkOVFBdw")]
    [Description(@"Code for a bag.")]
    Bag = UnitOfMeasureCode.Bag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BALE&quot;.
    /// </summary>
    [EnumMember(Value = "BALE")]
    [IsoId("_t5i7EexmEemioJdkOVFBdw")]
    [Description(@"Code for a bale.")]
    Bale = UnitOfMeasureCode.Bale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as &quot;BARL&quot;.
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_uAVfkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels = UnitOfMeasureCode.Barrels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as &quot;BCUF&quot;.
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_uHbmEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters."
    )]
    BillionCubicFeet = UnitOfMeasureCode.BillionCubicFeet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as &quot;BDFT&quot;.
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_uPmDkexmEemioJdkOVFBdw")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet = UnitOfMeasureCode.BoardFeet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BOTL&quot;.
    /// </summary>
    [EnumMember(Value = "BOTL")]
    [IsoId("_uWTvkexmEemioJdkOVFBdw")]
    [Description(@"Code for a bottle.")]
    Bottle = UnitOfMeasureCode.Bottle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BOXX&quot;.
    /// </summary>
    [EnumMember(Value = "BOXX")]
    [IsoId("_udLMkexmEemioJdkOVFBdw")]
    [Description(@"Code for a box.")]
    Box = UnitOfMeasureCode.Box, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit.
    /// Encoded/decoded by serializers as &quot;BRTU&quot;.
    /// </summary>
    [EnumMember(Value = "BRTU")]
    [IsoId("_umaBEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit."
    )]
    BritishThermalUnit = UnitOfMeasureCode.BritishThermalUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as &quot;BUSL&quot;.
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_utp4kexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently."
    )]
    Bushels = UnitOfMeasureCode.Bushels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_uzEkEexmEemioJdkOVFBdw")]
    [Description(@"Code for a carton.")]
    Carton = UnitOfMeasureCode.Carton, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CELI&quot;.
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_u5euEexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = UnitOfMeasureCode.Centilitre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_vWxuEexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre = UnitOfMeasureCode.Centimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;YARD&quot;.
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_v0ryEexmEemioJdkOVFBdw")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = UnitOfMeasureCode.Yard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_v-OIkexmEemioJdkOVFBdw")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon = UnitOfMeasureCode.USTon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;USQA&quot;.
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_wFAtEexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart = UnitOfMeasureCode.USQuart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;USPI&quot;.
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_wM3okexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = UnitOfMeasureCode.USPint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;USOU&quot;.
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_wT-WIexmEemioJdkOVFBdw")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce = UnitOfMeasureCode.USOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as &quot;UCWT&quot;.
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_wdHrEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs."
    )]
    USHundredweight = UnitOfMeasureCode.USHundredweight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;USGA&quot;.
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_wm9jkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon = UnitOfMeasureCode.USGallon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 2, 957353 centilitre.
    /// Encoded/decoded by serializers as &quot;USFO&quot;.
    /// </summary>
    [EnumMember(Value = "USFO")]
    [IsoId("_wvgbkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume equal to 2, 957353 centilitre.")]
    USFluidOunce = UnitOfMeasureCode.USFluidOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;USBA&quot;.
    /// </summary>
    [EnumMember(Value = "USBA")]
    [IsoId("_w2EWkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel = UnitOfMeasureCode.USBarrel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as &quot;OZTR&quot;.
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_w-TskexmEemioJdkOVFBdw")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces = UnitOfMeasureCode.TroyOunces, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as &quot;TOCD&quot;.
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_xQisEexmEemioJdkOVFBdw")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide = UnitOfMeasureCode.TonsOfCarbonDioxide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MILI&quot;.
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_xml0kexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre = UnitOfMeasureCode.MilliLitre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMET&quot;.
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_xrx2kexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = UnitOfMeasureCode.Millimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as &quot;MIBA&quot;.
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_xw0HkexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons."
    )]
    MillionBarrels = UnitOfMeasureCode.MillionBarrels, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as &quot;MBTU&quot;.
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_x36OEexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU = UnitOfMeasureCode.OneMillionBTU, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as &quot;PIEC&quot;.
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_x-FukexmEemioJdkOVFBdw")]
    [Description(
        @"Standard length of cloth, wallpaper, as an item for sale or amount of a substance."
    )]
    Piece = UnitOfMeasureCode.Piece, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;PUND&quot;.
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_yGLTkexmEemioJdkOVFBdw")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = UnitOfMeasureCode.Pound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as &quot;PWRD&quot;.
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_yLNkkexmEemioJdkOVFBdw")]
    [Description(
        @"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest)."
    )]
    PrincipalWithRelationToDebtInstrument = UnitOfMeasureCode.PrincipalWithRelationToDebtInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.
    /// Encoded/decoded by serializers as &quot;SHAS&quot;.
    /// </summary>
    [EnumMember(Value = "SHAS")]
    [IsoId("_yWp_kexmEemioJdkOVFBdw")]
    [Description(
        @"Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy."
    )]
    Shares = UnitOfMeasureCode.Shares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;SCMT&quot;.
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_yfz7kexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = UnitOfMeasureCode.SquareCentimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;SQFO&quot;.
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_ypCwEexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = UnitOfMeasureCode.SquareFoot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;SQIN&quot;.
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_yyRkkexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = UnitOfMeasureCode.SquareInch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;SQKI&quot;.
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_y5-vEexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = UnitOfMeasureCode.SquareKilometre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;SMET&quot;.
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_zA7EkexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = UnitOfMeasureCode.SquareMetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;SQMI&quot;.
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_zGkZkexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = UnitOfMeasureCode.SquareMile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;SMIL&quot;.
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_zL_FEexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = UnitOfMeasureCode.SquareMillimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;SQYA&quot;.
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_zSeHkexmEemioJdkOVFBdw")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = UnitOfMeasureCode.SquareYard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of heat, often used a unit of measure for natural gas in the UK.
    /// Encoded/decoded by serializers as &quot;THMS&quot;.
    /// </summary>
    [EnumMember(Value = "THMS")]
    [IsoId("_zZCCkexmEemioJdkOVFBdw")]
    [Description(@"Unit of heat, often used a unit of measure for natural gas in the UK.")]
    Therms = UnitOfMeasureCode.Therms, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;TONS&quot;.
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_zkBKkexmEemioJdkOVFBdw")]
    [Description(
        @"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton)."
    )]
    Ton = UnitOfMeasureCode.Ton, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_z61IEexmEemioJdkOVFBdw")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_0AjVkexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial)."
    )]
    MetricTons = UnitOfMeasureCode.MetricTons, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;METR&quot;.
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_0F5IkexmEemioJdkOVFBdw")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = UnitOfMeasureCode.Metre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as &quot;MWYC&quot;.
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_0KZOEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year."
    )]
    MegawattYearCapacity = UnitOfMeasureCode.MegawattYearCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as &quot;MMOC&quot;.
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_0V1pEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month."
    )]
    MegawattMonthCapacity = UnitOfMeasureCode.MegawattMonthCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;MWMC&quot;.
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_0aHFEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute."
    )]
    MegawattMinuteCapacity = UnitOfMeasureCode.MegawattMinuteCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;MWHC&quot;.
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_0fmpEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour."
    )]
    MegawattHoursCapacity = UnitOfMeasureCode.MegawattHoursCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as &quot;MWHO&quot;.
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_0kLnEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one megawatt during one hour."
    )]
    MegawattHours = UnitOfMeasureCode.MegawattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as &quot;MWDC&quot;.
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_0qSPEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day."
    )]
    MegawattDayCapacity = UnitOfMeasureCode.MegawattDayCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication of the unit of measurement.
    /// Encoded/decoded by serializers as &quot;LOTS&quot;.
    /// </summary>
    [EnumMember(Value = "LOTS")]
    [IsoId("_0wAckexmEemioJdkOVFBdw")]
    [Description(@"Indication of the unit of measurement.")]
    Lot = UnitOfMeasureCode.Lot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LITR&quot;.
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_06nKEexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = UnitOfMeasureCode.Litre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as &quot;KWYC&quot;.
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_1DTzEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year."
    )]
    KilowattYearCapacity = UnitOfMeasureCode.KilowattYearCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as &quot;KWMC&quot;.
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_1KL3IexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month."
    )]
    KilowattMonthCapacity = UnitOfMeasureCode.KilowattMonthCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;KMOC&quot;.
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_1TaroexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute."
    )]
    KilowattMinuteCapacity = UnitOfMeasureCode.KilowattMinuteCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;KWHC&quot;.
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_1mf_sexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour."
    )]
    KilowattHoursCapacity = UnitOfMeasureCode.KilowattHoursCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as &quot;KWDC&quot;.
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("_2DPmEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day."
    )]
    KilowattDayCapacity = UnitOfMeasureCode.KilowattDayCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as &quot;KWHO&quot;.
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_2OE9EexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one kilowatt during one hour."
    )]
    KilowattHours = UnitOfMeasureCode.KilowattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_2f3QoexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_2mVsEexmEemioJdkOVFBdw")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = UnitOfMeasureCode.Kilogram, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as &quot;IPNT&quot;.
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_2wBzkexmEemioJdkOVFBdw")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint = UnitOfMeasureCode.IndexPoint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INCH&quot;.
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_23gUkexmEemioJdkOVFBdw")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = UnitOfMeasureCode.Inch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as &quot;HUWG&quot;.
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("_3ADMkexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum."
    )]
    Hundredweight = UnitOfMeasureCode.Hundredweight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as &quot;HECT&quot;.
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_3KbQkexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare = UnitOfMeasureCode.Hectare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_3RcekexmEemioJdkOVFBdw")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = UnitOfMeasureCode.Gram, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one Gigawatt during one hour.
    /// Encoded/decoded by serializers as &quot;GWHO&quot;.
    /// </summary>
    [EnumMember(Value = "GWHO")]
    [IsoId("_3awLkexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one Gigawatt during one hour."
    )]
    GigawattHours = UnitOfMeasureCode.GigawattHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of weight, in Britain 2240 lb (long ton).
    /// Encoded/decoded by serializers as &quot;GBTN&quot;.
    /// </summary>
    [EnumMember(Value = "GBTN")]
    [IsoId("_3j1PEexmEemioJdkOVFBdw")]
    [Description(@"Measure of weight, in Britain 2240 lb (long ton).")]
    GBTon = UnitOfMeasureCode.GBTon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;GBQA&quot;.
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_3sc_kexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart = UnitOfMeasureCode.GBQuart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;GBPI&quot;.
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_4J-pEexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = UnitOfMeasureCode.GBPint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;GBOU&quot;.
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_4QYzEexmEemioJdkOVFBdw")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce = UnitOfMeasureCode.GBOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;GBGA&quot;.
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_4jYnkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon = UnitOfMeasureCode.GBGallon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;GBFO&quot;.
    /// </summary>
    [EnumMember(Value = "GBFO")]
    [IsoId("_4pG1EexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFuildOunce = UnitOfMeasureCode.GBFuildOunce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as &quot;GGEU&quot;.
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_4urRkexmEemioJdkOVFBdw")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent = UnitOfMeasureCode.GasolineGallonEquivalent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_44NoEexmEemioJdkOVFBdw")]
    [Description(
        @"Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future."
    )]
    Future = UnitOfMeasureCode.Future, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_5AJcEexmEemioJdkOVFBdw")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = UnitOfMeasureCode.Foot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as &quot;ENVO&quot;.
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_5FyxEexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit."
    )]
    EnvironmentalOffset = UnitOfMeasureCode.EnvironmentalOffset, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as &quot;ENVC&quot;.
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_-wC-IexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton)."
    )]
    EnvironmentalCredit = UnitOfMeasureCode.EnvironmentalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as &quot;DMET&quot;.
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_-4H8EexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of weight that is equal to the same mass value as a metric ton excluding moisture."
    )]
    DryMetricTons = UnitOfMeasureCode.DryMetricTons, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as &quot;DGEU&quot;.
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_-9xREexmEemioJdkOVFBdw")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent = UnitOfMeasureCode.DieselGallonEquivalent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("__HJ2kexmEemioJdkOVFBdw")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days = UnitOfMeasureCode.Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;CBML&quot;.
    /// </summary>
    [EnumMember(Value = "CBML")]
    [IsoId("__NaPkexmEemioJdkOVFBdw")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre = UnitOfMeasureCode.CubicMillimetre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as &quot;CBME&quot;.
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("__iKXkexmEemioJdkOVFBdw")]
    [Description(
        @"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters."
    )]
    CubicMeters = UnitOfMeasureCode.CubicMeters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("__nzskexmEemioJdkOVFBdw")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch = UnitOfMeasureCode.CubicInch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CRAT&quot;.
    /// </summary>
    [EnumMember(Value = "CRAT")]
    [IsoId("__9BHkexmEemioJdkOVFBdw")]
    [Description(@"Code for a crate.")]
    Crate = UnitOfMeasureCode.Crate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_AC0NkexnEemioJdkOVFBdw")]
    [Description(@"Code for a container.")]
    Container = UnitOfMeasureCode.Container, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as &quot;CLRT&quot;.
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_AJh5kexnEemioJdkOVFBdw")]
    [Description(
        @"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered."
    )]
    ClimateReserveTonnes = UnitOfMeasureCode.ClimateReserveTonnes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as &quot;CEER&quot;.
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_AQe2IexnEemioJdkOVFBdw")]
    [Description(
        @"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol."
    )]
    CertifiedEmissionsReduction = UnitOfMeasureCode.CertifiedEmissionsReduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cooling degree day
    /// Encoded/decoded by serializers as &quot;CDDA&quot;.
    /// </summary>
    [EnumMember(Value = "CDDA")]
    [IsoId("_ubU7AVfpEeqfKIw9ojIoIw")]
    [Description(@"Cooling degree day")]
    CoolingDegreeDay = UnitOfMeasureCode.CoolingDegreeDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Critical precipitation day
    /// Encoded/decoded by serializers as &quot;CPDA&quot;.
    /// </summary>
    [EnumMember(Value = "CPDA")]
    [IsoId("_ukjvgVfpEeqfKIw9ojIoIw")]
    [Description(@"Critical precipitation day")]
    CriticalPrecipitationDay = UnitOfMeasureCode.CriticalPrecipitationDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Heating degree day
    /// Encoded/decoded by serializers as &quot;HDDA&quot;.
    /// </summary>
    [EnumMember(Value = "HDDA")]
    [IsoId("_vfUuoVfpEeqfKIw9ojIoIw")]
    [Description(@"Heating degree day")]
    HeatingDegreeDay = UnitOfMeasureCode.HeatingDegreeDay, // same ordinal as derivation source for type conversions
}
