// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Exchange Rate agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c9M7QIZ5EeuSbct6WWD-Ng")]
[Description(@"Type of Exchange Rate agreement.")]
[Derivations(typeof(ExchangeRateAgreementType1Code))]
public enum ExchangeRateAgreementTypeCode
{
    /// <summary>
    /// Normal exchange rate agreement type.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_qOpjMIZ5EeuSbct6WWD-Ng")]
    [Description(@"Normal exchange rate agreement type.")]
    Normal,
    
    /// <summary>
    /// Spot agreement exchange rate type.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_vLLHkIZ5EeuSbct6WWD-Ng")]
    [Description(@"Spot agreement exchange rate type.")]
    Spot,
    
    /// <summary>
    /// Forward contract exchange rate type.
    /// Encoded/decoded by serializers as &quot;FWCT&quot;.
    /// </summary>
    [EnumMember(Value = "FWCT")]
    [IsoId("_zdOyoIZ5EeuSbct6WWD-Ng")]
    [Description(@"Forward contract exchange rate type.")]
    ForwardContract,
    
    /// <summary>
    /// Other exchange rate agreement type defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_7OiLwIZ5EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other exchange rate agreement type that is privately defined.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ENkjUIZ6EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type that is privately defined.")]
    OtherPrivate,
    
}
