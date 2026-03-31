// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y4XF0tp-Ed-ak6NoX_4Aeg_385163498")]
[Description(@"Identifies the unit of measure by means of a code.")]
[Derivations(
    typeof(UnitOfMeasure11Code),
    typeof(UnitOfMeasure10Code),
    typeof(UnitOfMeasure8Code),
    typeof(UnitOfMeasure1Code),
    typeof(UnitOfMeasure6Code),
    typeof(UnitOfMeasure12Code),
    typeof(UnitOfMeasure9Code)
)]
public enum UnitOfMeasureCode
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KILO&quot;.
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_Y4XF09p-Ed-ak6NoX_4Aeg_839534438")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram,

    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as &quot;PIEC&quot;.
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_Y4XF1Np-Ed-ak6NoX_4Aeg_882014994")]
    [Description(
        @"Standard length of cloth, wallpaper, as an item for sale or amount of a substance."
    )]
    Piece,

    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;TONS&quot;.
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_Y4XF1dp-Ed-ak6NoX_4Aeg_929116883")]
    [Description(
        @"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton)."
    )]
    Ton,

    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;METR&quot;.
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_Y4XF1tp-Ed-ak6NoX_4Aeg_1184930176")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre,

    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INCH&quot;.
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_Y4XF19p-Ed-ak6NoX_4Aeg_1211714729")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch,

    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;YARD&quot;.
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_Y4XF2Np-Ed-ak6NoX_4Aeg_1241266595")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard,

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;GBGA&quot;.
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_Y4XF2dp-Ed-ak6NoX_4Aeg_1271742682")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon,

    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_Y4g20Np-Ed-ak6NoX_4Aeg_1312377980")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram,

    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_Y4g20dp-Ed-ak6NoX_4Aeg_1339157873")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre,

    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;SMET&quot;.
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_Y4g20tp-Ed-ak6NoX_4Aeg_1395494917")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre,

    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_Y4g209p-Ed-ak6NoX_4Aeg_-1549798210")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot,

    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_Y4g21Np-Ed-ak6NoX_4Aeg_-1188701168")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile,

    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;SQIN&quot;.
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_Y4g21dp-Ed-ak6NoX_4Aeg_-673376427")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch,

    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;SQFO&quot;.
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_Y4g21tp-Ed-ak6NoX_4Aeg_-632740570")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot,

    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;SQMI&quot;.
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_Y4g219p-Ed-ak6NoX_4Aeg_-306738972")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile,

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;GBOU&quot;.
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_Y4g22Np-Ed-ak6NoX_4Aeg_1154157004")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce,

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;USOU&quot;.
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_Y4g22dp-Ed-ak6NoX_4Aeg_1478310969")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce,

    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;GBPI&quot;.
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_Y4qn0Np-Ed-ak6NoX_4Aeg_1519869052")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint,

    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;USPI&quot;.
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_Y4qn0dp-Ed-ak6NoX_4Aeg_1554964810")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint,

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;GBQA&quot;.
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_Y4qn0tp-Ed-ak6NoX_4Aeg_1593752536")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart,

    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as &quot;USQA&quot;.
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_Y4qn09p-Ed-ak6NoX_4Aeg_1865264870")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart,

    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as &quot;USGA&quot;.
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_Y4qn1Np-Ed-ak6NoX_4Aeg_1981629893")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon,

    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMET&quot;.
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_Y4qn1dp-Ed-ak6NoX_4Aeg_2022263492")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre,

    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_Y4qn1tp-Ed-ak6NoX_4Aeg_-1280839016")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre,

    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;SQYA&quot;.
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_Y4qn19p-Ed-ak6NoX_4Aeg_-941909737")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard,

    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as &quot;ACRE&quot;.
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_Y4qn2Np-Ed-ak6NoX_4Aeg_-508776390")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre,

    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_Y4qn2dp-Ed-ak6NoX_4Aeg_-467217555")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are,

    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;SMIL&quot;.
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_Y4qn2tp-Ed-ak6NoX_4Aeg_232809099")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre,

    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;SCMT&quot;.
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_Y4zxwNp-Ed-ak6NoX_4Aeg_377803722")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre,

    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as &quot;HECT&quot;.
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_Y4zxwdp-Ed-ak6NoX_4Aeg_477543602")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare,

    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;SQKI&quot;.
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_Y4zxwtp-Ed-ak6NoX_4Aeg_733356908")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre,

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MILI&quot;.
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_Y4zxw9p-Ed-ak6NoX_4Aeg_1181267429")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre,

    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CELI&quot;.
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_Y4zxxNp-Ed-ak6NoX_4Aeg_1318869240")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre,

    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LITR&quot;.
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_Y4zxxdp-Ed-ak6NoX_4Aeg_1694744170")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre,

    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;PUND&quot;.
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_Y4zxxtp-Ed-ak6NoX_4Aeg_2053068429")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound,

    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as &quot;ALOW&quot;.
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_Z-hA4tUkEeOz093LM8f3Hw")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances,

    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as &quot;ACCY&quot;.
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_Z-hA49UkEeOz093LM8f3Hw")]
    [Description(
        @"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217."
    )]
    AmountOfCurrency,

    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as &quot;BARL&quot;.
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_dh2kxNUkEeOz093LM8f3Hw")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels,

    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as &quot;BCUF&quot;.
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_dh2kxdUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters."
    )]
    BillionCubicFeet,

    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as &quot;BDFT&quot;.
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_dh2kxtUkEeOz093LM8f3Hw")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet,

    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as &quot;BUSL&quot;.
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_dh2kx9UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently."
    )]
    Bushels,

    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as &quot;CEER&quot;.
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_hkukV9UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol."
    )]
    CertifiedEmissionsReduction,

    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as &quot;CLRT&quot;.
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_hkukWNUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered."
    )]
    ClimateReserveTonnes,

    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as &quot;CBME&quot;.
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_hkukWdUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters."
    )]
    CubicMeters,

    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_hkukWtUkEeOz093LM8f3Hw")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days,

    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as &quot;DMET&quot;.
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_hkukW9UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of weight that is equal to the same mass value as a metric ton excluding moisture."
    )]
    DryMetricTons,

    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as &quot;ENVC&quot;.
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_hkukXNUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton)."
    )]
    EnvironmentalCredit,

    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as &quot;ENVO&quot;.
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_hkukXdUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit."
    )]
    EnvironmentalOffset,

    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as &quot;HUWG&quot;.
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("_pSHt0dUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum."
    )]
    Hundredweight,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as &quot;KWDC&quot;.
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("_tS0jJtUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day."
    )]
    KilowattDayCapacity,

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as &quot;KWHO&quot;.
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_tS1KMNUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one kilowatt during one hour."
    )]
    KilowattHours,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;KWHC&quot;.
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_tS1KMdUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour."
    )]
    KilowattHoursCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;KMOC&quot;.
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_tS1KMtUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute."
    )]
    KilowattMinuteCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as &quot;KWMC&quot;.
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_tS1KM9UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month."
    )]
    KilowattMonthCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as &quot;KWYC&quot;.
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_tS1KNNUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year."
    )]
    KilowattYearCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as &quot;MWDC&quot;.
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_xAg85tUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day."
    )]
    MegawattDayCapacity,

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as &quot;MWHO&quot;.
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_xAg859UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one megawatt during one hour."
    )]
    MegawattHours,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as &quot;MWHC&quot;.
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_xAg86NUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour."
    )]
    MegawattHoursCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as &quot;MWMC&quot;.
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_xAg86dUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute."
    )]
    MegawattMinuteCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as &quot;MMOC&quot;.
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_xAg86tUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month."
    )]
    MegawattMonthCapacity,

    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as &quot;MWYC&quot;.
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_xAg869UkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year."
    )]
    MegawattYearCapacity,

    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_zSmUQdUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial)."
    )]
    MetricTons,

    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as &quot;MIBA&quot;.
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_3XUG4tUkEeOz093LM8f3Hw")]
    [Description(
        @"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons."
    )]
    MillionBarrels,

    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as &quot;MBTU&quot;.
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_4IGDk9UkEeOz093LM8f3Hw")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU,

    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as &quot;OZTR&quot;.
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_GGMWItUlEeOz093LM8f3Hw")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces,

    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as &quot;UCWT&quot;.
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_GGMWI9UlEeOz093LM8f3Hw")]
    [Description(
        @"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs."
    )]
    USHundredweight,

    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as &quot;IPNT&quot;.
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_X-RK8dUlEeOz093LM8f3Hw")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint,

    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as &quot;PWRD&quot;.
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_wOUOcdUlEeOz093LM8f3Hw")]
    [Description(
        @"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest)."
    )]
    PrincipalWithRelationToDebtInstrument,

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as &quot;DGEU&quot;.
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_uiAgYI-IEeWjH5rPPp5_bg")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent,

    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as &quot;GGEU&quot;.
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_KxMS8I-JEeWjH5rPPp5_bg")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent,

    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as &quot;TOCD&quot;.
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_PxH0wSyGEeauQ_tRT3DWwA")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide,

    /// <summary>
    /// Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.
    /// Encoded/decoded by serializers as &quot;SHAS&quot;.
    /// </summary>
    [EnumMember(Value = "SHAS")]
    [IsoId("_4jSB8Lb6EeabfchHYoktpA")]
    [Description(
        @"Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy."
    )]
    Shares,

    /// <summary>
    /// Unit of heat, often used a unit of measure for natural gas in the UK.
    /// Encoded/decoded by serializers as &quot;THMS&quot;.
    /// </summary>
    [EnumMember(Value = "THMS")]
    [IsoId("_YUaRQLb7EeabfchHYoktpA")]
    [Description(@"Unit of heat, often used a unit of measure for natural gas in the UK.")]
    Therms,

    /// <summary>
    /// Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_3PDQMBYAEeejf-cbr8l5qw")]
    [Description(
        @"Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future."
    )]
    Future,

    /// <summary>
    /// Unit of measure that is equal to the power consumption of one Gigawatt during one hour.
    /// Encoded/decoded by serializers as &quot;GWHO&quot;.
    /// </summary>
    [EnumMember(Value = "GWHO")]
    [IsoId("_5JlvMNT7Eeec2McyvEYavg")]
    [Description(
        @"Unit of measure that is equal to the power consumption of one Gigawatt during one hour."
    )]
    GigawattHours,

    /// <summary>
    /// Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit.
    /// Encoded/decoded by serializers as &quot;BRTU&quot;.
    /// </summary>
    [EnumMember(Value = "BRTU")]
    [IsoId("_5PGhUNT7Eeec2McyvEYavg")]
    [Description(
        @"Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit."
    )]
    BritishThermalUnit,

    /// <summary>
    /// Indication of the unit of measurement.
    /// Encoded/decoded by serializers as &quot;LOTS&quot;.
    /// </summary>
    [EnumMember(Value = "LOTS")]
    [IsoId("_5ilgsOb7EeaUdvocwZJDIw")]
    [Description(@"Indication of the unit of measurement.")]
    Lot,

    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_PFxDkPFAEee_LsXdoqzkWg")]
    [Description(@"Code for a bag.")]
    Bag,

    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BALE&quot;.
    /// </summary>
    [EnumMember(Value = "BALE")]
    [IsoId("_T8o2cPFBEee_LsXdoqzkWg")]
    [Description(@"Code for a bale.")]
    Bale,

    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BOTL&quot;.
    /// </summary>
    [EnumMember(Value = "BOTL")]
    [IsoId("_d8hnAPFBEee_LsXdoqzkWg")]
    [Description(@"Code for a bottle.")]
    Bottle,

    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BOXX&quot;.
    /// </summary>
    [EnumMember(Value = "BOXX")]
    [IsoId("_l-7XMPFBEee_LsXdoqzkWg")]
    [Description(@"Code for a box.")]
    Box,

    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_skCC8PFBEee_LsXdoqzkWg")]
    [Description(@"Code for a carton.")]
    Carton,

    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_-kQHIPFBEee_LsXdoqzkWg")]
    [Description(@"Code for a container.")]
    Container,

    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CRAT&quot;.
    /// </summary>
    [EnumMember(Value = "CRAT")]
    [IsoId("_3qbSIPFNEee_LsXdoqzkWg")]
    [Description(@"Code for a crate.")]
    Crate,

    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_HjD-wPFOEee_LsXdoqzkWg")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch,

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;CBML&quot;.
    /// </summary>
    [EnumMember(Value = "CBML")]
    [IsoId("_rl6h8PFOEee_LsXdoqzkWg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre,

    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;GBFO&quot;.
    /// </summary>
    [EnumMember(Value = "GBFO")]
    [IsoId("_NZ2WgPFPEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFuildOunce,

    /// <summary>
    /// Measure of weight, in Britain 2240 lb (long ton).
    /// Encoded/decoded by serializers as &quot;GBTN&quot;.
    /// </summary>
    [EnumMember(Value = "GBTN")]
    [IsoId("_fAonAPFPEee_LsXdoqzkWg")]
    [Description(@"Measure of weight, in Britain 2240 lb (long ton).")]
    GBTon,

    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;USBA&quot;.
    /// </summary>
    [EnumMember(Value = "USBA")]
    [IsoId("_M18iwPFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel,

    /// <summary>
    /// Unit of volume equal to 2, 957353 centilitre.
    /// Encoded/decoded by serializers as &quot;USFO&quot;.
    /// </summary>
    [EnumMember(Value = "USFO")]
    [IsoId("_XyfI0PFQEee_LsXdoqzkWg")]
    [Description(@"Unit of volume equal to 2, 957353 centilitre.")]
    USFluidOunce,

    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_lqsOwPFQEee_LsXdoqzkWg")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon,

    /// <summary>
    /// Cooling degree day
    /// Encoded/decoded by serializers as &quot;CDDA&quot;.
    /// </summary>
    [EnumMember(Value = "CDDA")]
    [IsoId("_643PMFfoEeqfKIw9ojIoIw")]
    [Description(@"Cooling degree day")]
    CoolingDegreeDay,

    /// <summary>
    /// Heating degree day
    /// Encoded/decoded by serializers as &quot;HDDA&quot;.
    /// </summary>
    [EnumMember(Value = "HDDA")]
    [IsoId("_AckvYFfpEeqfKIw9ojIoIw")]
    [Description(@"Heating degree day")]
    HeatingDegreeDay,

    /// <summary>
    /// Critical precipitation day
    /// Encoded/decoded by serializers as &quot;CPDA&quot;.
    /// </summary>
    [EnumMember(Value = "CPDA")]
    [IsoId("_KyeMMFfpEeqfKIw9ojIoIw")]
    [Description(@"Critical precipitation day")]
    CriticalPrecipitationDay,
}
