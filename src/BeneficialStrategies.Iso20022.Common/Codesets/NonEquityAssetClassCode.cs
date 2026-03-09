// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the asset class of a non-equity financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9f_awHBYEeqTZuDtO9NgaQ")]
[Description(@"Specifies the asset class of a non-equity financial instrument.")]
[Derivations(typeof(NonEquityAssetClass1Code))]
public enum NonEquityAssetClassCode
{
    /// <summary>
    /// Interest rate derivative.
    /// Encoded/decoded by serializers as &quot;IRDV&quot;.
    /// </summary>
    [EnumMember(Value = "IRDV")]
    [IsoId("_rG2DwHBZEeqTZuDtO9NgaQ")]
    [Description(@"Interest rate derivative.")]
    InterestRateDerivative,
    
    /// <summary>
    /// Equity derivative.
    /// Encoded/decoded by serializers as &quot;EQDV&quot;.
    /// </summary>
    [EnumMember(Value = "EQDV")]
    [IsoId("_vfkXgHBZEeqTZuDtO9NgaQ")]
    [Description(@"Equity derivative.")]
    EquityDerivative,
    
    /// <summary>
    /// Commodity derivative.
    /// Encoded/decoded by serializers as &quot;COMD&quot;.
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_17-aQHBZEeqTZuDtO9NgaQ")]
    [Description(@"Commodity derivative.")]
    CommodityDerivative,
    
    /// <summary>
    /// Foreign exchange derivative.
    /// Encoded/decoded by serializers as &quot;FEXD&quot;.
    /// </summary>
    [EnumMember(Value = "FEXD")]
    [IsoId("_4iFg4HBZEeqTZuDtO9NgaQ")]
    [Description(@"Foreign exchange derivative.")]
    ForeignExchangeDerivative,
    
    /// <summary>
    /// Credit derivative.
    /// Encoded/decoded by serializers as &quot;CRDV&quot;.
    /// </summary>
    [EnumMember(Value = "CRDV")]
    [IsoId("__v6ZgHBZEeqTZuDtO9NgaQ")]
    [Description(@"Credit derivative.")]
    CreditDerivative,
    
    /// <summary>
    /// C10 derivative.
    /// Encoded/decoded by serializers as &quot;C10D&quot;.
    /// </summary>
    [EnumMember(Value = "C10D")]
    [IsoId("_CVFE8HBaEeqTZuDtO9NgaQ")]
    [Description(@"C10 derivative.")]
    C10Derivative,
    
    /// <summary>
    /// Contract for difference.
    /// Encoded/decoded by serializers as &quot;CFDS&quot;.
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_Ev3FUHBaEeqTZuDtO9NgaQ")]
    [Description(@"Contract for difference.")]
    ContractForDifference,
    
    /// <summary>
    /// Emission allowance.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_G3tioHBaEeqTZuDtO9NgaQ")]
    [Description(@"Emission allowance.")]
    EmissionAllowance,
    
    /// <summary>
    /// Emission allowance derivative.
    /// Encoded/decoded by serializers as &quot;EADV&quot;.
    /// </summary>
    [EnumMember(Value = "EADV")]
    [IsoId("_KNbhQHBaEeqTZuDtO9NgaQ")]
    [Description(@"Emission allowance derivative.")]
    EmissionAllowanceDerivative,
    
    /// <summary>
    /// Securitised derivative.
    /// Encoded/decoded by serializers as &quot;SDRV&quot;.
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_Ng75YHBaEeqTZuDtO9NgaQ")]
    [Description(@"Securitised derivative.")]
    SecuritisedDerivative,
    
    /// <summary>
    /// Bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_vN9uEIR5EeqOnqlbcclX_g")]
    [Description(@"Bond.")]
    Bond,
    
    /// <summary>
    /// Exchange traded commodities.
    /// Encoded/decoded by serializers as &quot;ETCS&quot;.
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_C1r7kIR6EeqOnqlbcclX_g")]
    [Description(@"Exchange traded commodities.")]
    ExchangeTradedCommodities,
    
    /// <summary>
    /// Exchange traded note.
    /// Encoded/decoded by serializers as &quot;ETNS&quot;.
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_FHQVkIR6EeqOnqlbcclX_g")]
    [Description(@"Exchange traded note.")]
    ExchangeTradedNote,
    
    /// <summary>
    /// Structured finance product.
    /// Encoded/decoded by serializers as &quot;SFPS&quot;.
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_etfI4IR6EeqOnqlbcclX_g")]
    [Description(@"Structured finance product.")]
    StructuredFinanceProduct,
    
}
