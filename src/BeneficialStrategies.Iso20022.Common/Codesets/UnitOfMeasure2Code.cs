// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y2SCNtp-Ed-ak6NoX_4Aeg_-339035809")]
[Description(
    @"Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20."
)]
[Derivations(typeof(UnitOfMeasure4Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum UnitOfMeasure2Code
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as &quot;KGM&quot;.
    /// </summary>
    [EnumMember(Value = "KGM")]
    [IsoId("_Y2SCN9p-Ed-ak6NoX_4Aeg_-481523840")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram,

    /// <summary>
    /// Unit of count defining the number of items regarded as separate units.
    /// Encoded/decoded by serializers as &quot;EA&quot;.
    /// </summary>
    [EnumMember(Value = "EA")]
    [IsoId("_Y2SCONp-Ed-ak6NoX_4Aeg_-481523815")]
    [Description(@"Unit of count defining the number of items regarded as separate units.")]
    Each,

    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton).
    /// Encoded/decoded by serializers as &quot;LTN&quot;.
    /// </summary>
    [EnumMember(Value = "LTN")]
    [IsoId("_Y2bMINp-Ed-ak6NoX_4Aeg_-481523798")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton).")]
    GBTon,

    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as &quot;MTR&quot;.
    /// </summary>
    [EnumMember(Value = "MTR")]
    [IsoId("_Y2bMIdp-Ed-ak6NoX_4Aeg_-481523563")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre,

    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as &quot;INH&quot;.
    /// </summary>
    [EnumMember(Value = "INH")]
    [IsoId("_Y2bMItp-Ed-ak6NoX_4Aeg_-481523546")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch,

    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as &quot;LY&quot;.
    /// </summary>
    [EnumMember(Value = "LY")]
    [IsoId("_Y2bMI9p-Ed-ak6NoX_4Aeg_-481523528")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard,

    /// <summary>
    /// Unit of volume that is equal to 8 GB pints.
    /// Encoded/decoded by serializers as &quot;GLI&quot;.
    /// </summary>
    [EnumMember(Value = "GLI")]
    [IsoId("_Y2bMJNp-Ed-ak6NoX_4Aeg_-481523520")]
    [Description(@"Unit of volume that is equal to 8 GB pints.")]
    GBGallon,

    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as &quot;GRM&quot;.
    /// </summary>
    [EnumMember(Value = "GRM")]
    [IsoId("_Y2bMJdp-Ed-ak6NoX_4Aeg_-481523503")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram,

    /// <summary>
    /// One 100th part of a metre.
    /// Encoded/decoded by serializers as &quot;CMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMT")]
    [IsoId("_Y2bMJtp-Ed-ak6NoX_4Aeg_-481523486")]
    [Description(@"One 100th part of a metre.")]
    Centimetre,

    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as &quot;MTK&quot;.
    /// </summary>
    [EnumMember(Value = "MTK")]
    [IsoId("_Y2bMJ9p-Ed-ak6NoX_4Aeg_-481523468")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre,

    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as &quot;FOT&quot;.
    /// </summary>
    [EnumMember(Value = "FOT")]
    [IsoId("_Y2bMKNp-Ed-ak6NoX_4Aeg_-481523443")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot,

    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;1A&quot;.
    /// </summary>
    [EnumMember(Value = "1A")]
    [IsoId("_Y2bMKdp-Ed-ak6NoX_4Aeg_-473215286")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile,

    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as &quot;INK&quot;.
    /// </summary>
    [EnumMember(Value = "INK")]
    [IsoId("_Y2bMKtp-Ed-ak6NoX_4Aeg_-473215269")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch,

    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as &quot;FTK&quot;.
    /// </summary>
    [EnumMember(Value = "FTK")]
    [IsoId("_Y2k9INp-Ed-ak6NoX_4Aeg_-473215251")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot,

    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as &quot;MIK&quot;.
    /// </summary>
    [EnumMember(Value = "MIK")]
    [IsoId("_Y2k9Idp-Ed-ak6NoX_4Aeg_-473215226")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile,

    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as &quot;ONZ&quot;.
    /// </summary>
    [EnumMember(Value = "ONZ")]
    [IsoId("_Y2k9Itp-Ed-ak6NoX_4Aeg_-473215209")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    Ounce,

    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;PTI&quot;.
    /// </summary>
    [EnumMember(Value = "PTI")]
    [IsoId("_Y2k9I9p-Ed-ak6NoX_4Aeg_-473215174")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint,

    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as &quot;PT&quot;.
    /// </summary>
    [EnumMember(Value = "PT")]
    [IsoId("_Y2k9JNp-Ed-ak6NoX_4Aeg_-473215156")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint,

    /// <summary>
    /// Unit of volume that is equal to 2 GB pints.
    /// Encoded/decoded by serializers as &quot;QTI&quot;.
    /// </summary>
    [EnumMember(Value = "QTI")]
    [IsoId("_Y2k9Jdp-Ed-ak6NoX_4Aeg_-473215131")]
    [Description(@"Unit of volume that is equal to 2 GB pints.")]
    GBQuart,

    /// <summary>
    /// Unit of volume that is equal to 2 US pints.
    /// Encoded/decoded by serializers as &quot;QT&quot;.
    /// </summary>
    [EnumMember(Value = "QT")]
    [IsoId("_Y2k9Jtp-Ed-ak6NoX_4Aeg_-473215114")]
    [Description(@"Unit of volume that is equal to 2 US pints.")]
    USQuart,

    /// <summary>
    /// Unit of volume that is equal to 8 US pints.
    /// Encoded/decoded by serializers as &quot;GLL&quot;.
    /// </summary>
    [EnumMember(Value = "GLL")]
    [IsoId("_Y2k9J9p-Ed-ak6NoX_4Aeg_-473215096")]
    [Description(@"Unit of volume that is equal to 8 US pints.")]
    USGallon,

    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as &quot;MMT&quot;.
    /// </summary>
    [EnumMember(Value = "MMT")]
    [IsoId("_Y2k9KNp-Ed-ak6NoX_4Aeg_-473215071")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre,

    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KTM&quot;.
    /// </summary>
    [EnumMember(Value = "KTM")]
    [IsoId("_Y2k9Kdp-Ed-ak6NoX_4Aeg_-473215053")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre,

    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as &quot;YDK&quot;.
    /// </summary>
    [EnumMember(Value = "YDK")]
    [IsoId("_Y2uuINp-Ed-ak6NoX_4Aeg_-473215035")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard,

    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as &quot;MMK&quot;.
    /// </summary>
    [EnumMember(Value = "MMK")]
    [IsoId("_Y2uuIdp-Ed-ak6NoX_4Aeg_-473215010")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre,

    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as &quot;CMK&quot;.
    /// </summary>
    [EnumMember(Value = "CMK")]
    [IsoId("_Y2uuItp-Ed-ak6NoX_4Aeg_-473214993")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre,

    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as &quot;KMK&quot;.
    /// </summary>
    [EnumMember(Value = "KMK")]
    [IsoId("_Y2uuI9p-Ed-ak6NoX_4Aeg_-473214741")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre,

    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as &quot;MMQ&quot;.
    /// </summary>
    [EnumMember(Value = "MMQ")]
    [IsoId("_Y2uuJNp-Ed-ak6NoX_4Aeg_-473214723")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre,

    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as &quot;CLT&quot;.
    /// </summary>
    [EnumMember(Value = "CLT")]
    [IsoId("_Y2uuJdp-Ed-ak6NoX_4Aeg_-473214698")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre,

    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as &quot;LTR&quot;.
    /// </summary>
    [EnumMember(Value = "LTR")]
    [IsoId("_Y2uuJtp-Ed-ak6NoX_4Aeg_-473214681")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre,

    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as &quot;LBR&quot;.
    /// </summary>
    [EnumMember(Value = "LBR")]
    [IsoId("_Y2uuJ9p-Ed-ak6NoX_4Aeg_-473214663")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound,

    /// <summary>
    /// Measure of weight, in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as &quot;STN&quot;.
    /// </summary>
    [EnumMember(Value = "STN")]
    [IsoId("_Y2uuKNp-Ed-ak6NoX_4Aeg_880666735")]
    [Description(@"Measure of weight, in the US 2000lb (short ton).")]
    USTon,

    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as &quot;BLL&quot;.
    /// </summary>
    [EnumMember(Value = "BLL")]
    [IsoId("_Y2uuKdp-Ed-ak6NoX_4Aeg_1492039014")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel,

    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as &quot;BX&quot;.
    /// </summary>
    [EnumMember(Value = "BX")]
    [IsoId("_Y234ENp-Ed-ak6NoX_4Aeg_1796799475")]
    [Description(@"Code for a box.")]
    Box,

    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as &quot;BO&quot;.
    /// </summary>
    [EnumMember(Value = "BO")]
    [IsoId("_Y234Edp-Ed-ak6NoX_4Aeg_1821737409")]
    [Description(@"Code for a bottle.")]
    Bottle,

    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as &quot;CT&quot;.
    /// </summary>
    [EnumMember(Value = "CT")]
    [IsoId("_Y234Etp-Ed-ak6NoX_4Aeg_1850365195")]
    [Description(@"Code for a carton.")]
    Carton,

    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as &quot;CH&quot;.
    /// </summary>
    [EnumMember(Value = "CH")]
    [IsoId("_Y234E9p-Ed-ak6NoX_4Aeg_1865140585")]
    [Description(@"Code for a container.")]
    Container,

    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as &quot;CR&quot;.
    /// </summary>
    [EnumMember(Value = "CR")]
    [IsoId("_Y234FNp-Ed-ak6NoX_4Aeg_2119110191")]
    [Description(@"Code for a crate.")]
    Crate,

    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as &quot;INQ&quot;.
    /// </summary>
    [EnumMember(Value = "INQ")]
    [IsoId("_Y234Fdp-Ed-ak6NoX_4Aeg_2134808148")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch,

    /// <summary>
    /// Measure of a volume, one meter by one meter by one meter.
    /// Encoded/decoded by serializers as &quot;MTQ&quot;.
    /// </summary>
    [EnumMember(Value = "MTQ")]
    [IsoId("_Y234Ftp-Ed-ak6NoX_4Aeg_-2131528066")]
    [Description(@"Measure of a volume, one meter by one meter by one meter.")]
    CubicMeter,

    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as &quot;OZI&quot;.
    /// </summary>
    [EnumMember(Value = "OZI")]
    [IsoId("_Y234F9p-Ed-ak6NoX_4Aeg_-2105670854")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFluidOunce,

    /// <summary>
    /// Unit of volume equal to 2, 957 353 centilitre.
    /// Encoded/decoded by serializers as &quot;OZA&quot;.
    /// </summary>
    [EnumMember(Value = "OZA")]
    [IsoId("_Y234GNp-Ed-ak6NoX_4Aeg_-2071500070")]
    [Description(@"Unit of volume equal to 2, 957 353 centilitre.")]
    USFluidOunce,

    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as &quot;BG&quot;.
    /// </summary>
    [EnumMember(Value = "BG")]
    [IsoId("_Y234Gdp-Ed-ak6NoX_4Aeg_1078859500")]
    [Description(@"Code for a bag.")]
    Bag,

    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as &quot;BL&quot;.
    /// </summary>
    [EnumMember(Value = "BL")]
    [IsoId("_Y234Gtp-Ed-ak6NoX_4Aeg_1093634177")]
    [Description(@"Code for a bale.")]
    Bale,

    /// <summary>
    /// Measure of weight, equal to 1000 kilograms.
    /// Encoded/decoded by serializers as &quot;TNE&quot;.
    /// </summary>
    [EnumMember(Value = "TNE")]
    [IsoId("_Y3BpENp-Ed-ak6NoX_4Aeg_-1784174275")]
    [Description(@"Measure of weight, equal to 1000 kilograms.")]
    MetricTon,
}
