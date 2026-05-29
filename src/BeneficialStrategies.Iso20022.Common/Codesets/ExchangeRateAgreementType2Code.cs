// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of exchange rate agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GNwvQSH2EfCkq6-p7S3J1Q")]
[Description(@"Type of exchange rate agreement.")]
[DerivedFrom(typeof(ExchangeRateAgreementTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExchangeRateAgreementType2Code>))]
public enum ExchangeRateAgreementType2Code
{
    /// <summary>
    /// Forward contract exchange rate type.
    /// Encoded/decoded by serializers as &quot;FWCT&quot;.
    /// </summary>
    [EnumMember(Value = "FWCT")]
    [IsoId("_GQvKwSH2EfCkq6-p7S3J1Q")]
    [Description(@"Forward contract exchange rate type.")]
    ForwardContract = ExchangeRateAgreementTypeCode.ForwardContract,

    /// <summary>
    /// Normal exchange rate agreement type.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_GQvKwyH2EfCkq6-p7S3J1Q")]
    [Description(@"Normal exchange rate agreement type.")]
    Normal = ExchangeRateAgreementTypeCode.Normal,

    /// <summary>
    /// Spot agreement exchange rate type.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_GQvKySH2EfCkq6-p7S3J1Q")]
    [Description(@"Spot agreement exchange rate type.")]
    Spot = ExchangeRateAgreementTypeCode.Spot,
}
