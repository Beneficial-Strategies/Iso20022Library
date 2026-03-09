// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the contract type of a derivative financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9MdW8QOAEeWs3sTa9Sj6Lg")]
[Description(@"Specifies the contract type of a derivative financial instrument.")]
[Derivations(typeof(FinancialInstrumentContractType1Code),typeof(FinancialInstrumentContractType2Code))]
public enum FinancialInstrumentContractTypeCode
{
    /// <summary>
    /// Contract of type contracts for difference.
    /// Encoded/decoded by serializers as &quot;CFDS&quot;.
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_CN864AOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type contracts for difference.")]
    ContractForDifference,
    
    /// <summary>
    /// Contract of type forward rate agreement.
    /// Encoded/decoded by serializers as &quot;FRAS&quot;.
    /// </summary>
    [EnumMember(Value = "FRAS")]
    [IsoId("_JBRBwAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type forward rate agreement.")]
    ForwardRateAgreement,
    
    /// <summary>
    /// Contract of type future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_KitmYAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type future.")]
    Futures,
    
    /// <summary>
    /// Contract of type forward.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_L_Zm0AOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type forward.||")]
    Forward,
    
    /// <summary>
    /// Contract of type option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_NBv0oAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type option.|")]
    Option,
    
    /// <summary>
    /// Contract of type swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_OY7qAAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type swap.|")]
    Swap,
    
    /// <summary>
    /// Contract of type spread betting.
    /// Encoded/decoded by serializers as &quot;SPDB&quot;.
    /// </summary>
    [EnumMember(Value = "SPDB")]
    [IsoId("_PdhTgAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type spread betting.|")]
    SpreadBetting,
    
    /// <summary>
    /// Contract of type swaption.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_QjvUsAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type swaption.|")]
    Swaption,
    
    /// <summary>
    /// Contract of other financial instrument contract type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_R25lsAOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of other financial instrument contract type.")]
    Other,
    
    /// <summary>
    /// Contract of type future on a swap.
    /// Encoded/decoded by serializers as &quot;FONS&quot;.
    /// </summary>
    [EnumMember(Value = "FONS")]
    [IsoId("_nI4boAnOEeW1sbwBDSZgiA")]
    [Description(@"Contract of type future on a swap.")]
    FuturesOnSwap,
    
    /// <summary>
    /// Contract of type portfolio swap.
    /// Encoded/decoded by serializers as &quot;PSWP&quot;.
    /// </summary>
    [EnumMember(Value = "PSWP")]
    [IsoId("_7Og0kA3pEeWc7_0KPiuk6w")]
    [Description(@"Contract of type portfolio swap.")]
    PortfolioSwap,
    
    /// <summary>
    /// Contract of type forwards on a swap.
    /// Encoded/decoded by serializers as &quot;FWOS&quot;.
    /// </summary>
    [EnumMember(Value = "FWOS")]
    [IsoId("__yztQHwVEeWa36CuR-uOCw")]
    [Description(@"Contract of type forwards on a swap.")]
    ForwardsOnASwap,
    
    /// <summary>
    /// Contract of type forward freight agreement.
    /// Encoded/decoded by serializers as &quot;FFAS&quot;.
    /// </summary>
    [EnumMember(Value = "FFAS")]
    [IsoId("_FbdX0HwWEeWa36CuR-uOCw")]
    [Description(@"Contract of type forward freight agreement.")]
    ForwardFreightAgreement,
    
}
