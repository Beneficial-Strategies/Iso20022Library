// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__z2249ojEeC60axPepSq7g_1528237670")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice3Code
{
    /// <summary>
    /// Price is an average execution price.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("__z225NojEeC60axPepSq7g_-2134523685")]
    [Description(@"Price is an average execution price.")]
    Average = TypeOfPriceCode.Average, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is an override of the average price.
    /// Encoded/decoded by serializers as &quot;AVOV&quot;.
    /// </summary>
    [EnumMember(Value = "AVOV")]
    [IsoId("__z225dojEeC60axPepSq7g_-2145622462")]
    [Description(@"Price is an override of the average price.")]
    AverageOverride = TypeOfPriceCode.AverageOverride, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.
    /// Encoded/decoded by serializers as &quot;GREX&quot;.
    /// </summary>
    [EnumMember(Value = "GREX")]
    [IsoId("__0An4NojEeC60axPepSq7g_-1515416890")]
    [Description(
        @"Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes."
    )]
    GrossOfAll = TypeOfPriceCode.GrossOfAll, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a net price, ie, net only of local broker&apos;s commission, local fees and local taxes.
    /// Encoded/decoded by serializers as &quot;NET2&quot;.
    /// </summary>
    [EnumMember(Value = "NET2")]
    [IsoId("__0An4dojEeC60axPepSq7g_-1471209616")]
    [Description(
        @"Price is a net price, ie, net only of local broker's commission, local fees and local taxes."
    )]
    Net = TypeOfPriceCode.Net, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a net price, ie, net of all charges, fees and taxes.
    /// Encoded/decoded by serializers as &quot;NET1&quot;.
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("__0An4tojEeC60axPepSq7g_1799597409")]
    [Description(@"Price is a net price, ie, net of all charges, fees and taxes.")]
    NetOfAll = TypeOfPriceCode.NetOfAll, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is equal to the nominal or face value of the instrument.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("__0An49ojEeC60axPepSq7g_-2066929852")]
    [Description(@"Price is equal to the nominal or face value of the instrument.")]
    ParValue = TypeOfPriceCode.ParValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a rounded average price.
    /// Encoded/decoded by serializers as &quot;RDAV&quot;.
    /// </summary>
    [EnumMember(Value = "RDAV")]
    [IsoId("__0An5NojEeC60axPepSq7g_749789904")]
    [Description(@"Price is a rounded average price.")]
    RoundedAverage = TypeOfPriceCode.RoundedAverage, // same ordinal as derivation source for type conversions
}
