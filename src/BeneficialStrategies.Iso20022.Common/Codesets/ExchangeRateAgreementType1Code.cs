// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of exchange rate agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8WJeoIZ6EeuSbct6WWD-Ng")]
[Description(@"Type of exchange rate agreement.")]
[DerivedFrom(typeof(ExchangeRateAgreementTypeCode))]
public enum ExchangeRateAgreementType1Code
{
    /// <summary>
    /// Forward contract exchange rate type.
    /// Encoded/decoded by serializers as &quot;FWCT&quot;.
    /// </summary>
    [EnumMember(Value = "FWCT")]
    [IsoId("_Dq8h8YZ7EeuSbct6WWD-Ng")]
    [Description(@"Forward contract exchange rate type.")]
    ForwardContract = ExchangeRateAgreementTypeCode.ForwardContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Normal exchange rate agreement type.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_EVLKsYZ7EeuSbct6WWD-Ng")]
    [Description(@"Normal exchange rate agreement type.")]
    Normal = ExchangeRateAgreementTypeCode.Normal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other exchange rate agreement type defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EdpKMYZ7EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type defined at national level.")]
    OtherNational = ExchangeRateAgreementTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other exchange rate agreement type that is privately defined.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_FBk9sYZ7EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type that is privately defined.")]
    OtherPrivate = ExchangeRateAgreementTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spot agreement exchange rate type.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_FClDQYZ7EeuSbct6WWD-Ng")]
    [Description(@"Spot agreement exchange rate type.")]
    Spot = ExchangeRateAgreementTypeCode.Spot, // same ordinal as derivation source for type conversions
}
