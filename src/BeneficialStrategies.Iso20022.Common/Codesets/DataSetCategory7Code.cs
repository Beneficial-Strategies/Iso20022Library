// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of an ATM configuration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uif28In9EeShMpas3885ww")]
[Description(@"Type of an ATM configuration.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory7Code
{
    /// <summary>
    /// Configuration parameters of the ATM.
    /// Encoded/decoded by serializers as &quot;ATMC&quot;.
    /// </summary>
    [EnumMember(Value = "ATMC")]
    [IsoId("_2KOdUYn9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the ATM.")]
    ATMConfiguration = DataSetCategoryCode.ATMConfiguration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM protocol parameters, including the configuration of the hosts.
    /// Encoded/decoded by serializers as &quot;ATMP&quot;.
    /// </summary>
    [EnumMember(Value = "ATMP")]
    [IsoId("_2RPEQ4n9EeShMpas3885ww")]
    [Description(@"ATM protocol parameters, including the configuration of the hosts.")]
    ATMProtocol = DataSetCategoryCode.ATMProtocol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_6zEQs4n9EeShMpas3885ww")]
    [Description(
        @"Payment application specific configuration parameters for the point of interaction (POI) system."
    )]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration parameters of the card application.
    /// Encoded/decoded by serializers as &quot;CRAP&quot;.
    /// </summary>
    [EnumMember(Value = "CRAP")]
    [IsoId("__QYwk4n9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the card application.")]
    CardApplication = DataSetCategoryCode.CardApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of the cards accepted by the terminal.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("__XsSc4n9EeShMpas3885ww")]
    [Description(@"Configuration of the cards accepted by the terminal.")]
    CardConfiguration = DataSetCategoryCode.CardConfiguration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Local rates for currency exchanges.
    /// Encoded/decoded by serializers as &quot;OEXR&quot;.
    /// </summary>
    [EnumMember(Value = "OEXR")]
    [IsoId("_As9cQ4n-EeShMpas3885ww")]
    [Description(@"Local rates for currency exchanges.")]
    OfflineExchangeRate = DataSetCategoryCode.OfflineExchangeRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Predefined amounts to be presented to the customer.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_A1wL44n-EeShMpas3885ww")]
    [Description(@"Predefined amounts to be presented to the customer.")]
    PreDefinedAmount = DataSetCategoryCode.PreDefinedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of the location.
    /// Encoded/decoded by serializers as &quot;LOCC&quot;.
    /// </summary>
    [EnumMember(Value = "LOCC")]
    [IsoId("_CL-X84n-EeShMpas3885ww")]
    [Description(@"Configuration of the location.")]
    LocationConfiguration = DataSetCategoryCode.LocationConfiguration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration of the mobile operator cards accepted by the terminal.
    /// Encoded/decoded by serializers as &quot;MNOC&quot;.
    /// </summary>
    [EnumMember(Value = "MNOC")]
    [IsoId("_E8OSA4n-EeShMpas3885ww")]
    [Description(@"Configuration of the mobile operator cards accepted by the terminal.")]
    MobileOperator = DataSetCategoryCode.MobileOperator, // same ordinal as derivation source for type conversions
}
