// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the contract type of a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xfQ6kAOBEeWs3sTa9Sj6Lg")]
[Description(@"Specifies the contract type of a derivative.")]
[DerivedFrom(typeof(FinancialInstrumentContractTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancialInstrumentContractType1Code>))]
#endif
public enum FinancialInstrumentContractType1Code
{
    /// <summary>
    /// Contract of type contracts for difference.
    /// Encoded/decoded by serializers as &quot;CFDS&quot;.
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_ygkmkQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type contracts for difference.")]
    ContractForDifference = FinancialInstrumentContractTypeCode.ContractForDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type forward.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_yl7nsQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type forward.||")]
    Forward = FinancialInstrumentContractTypeCode.Forward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type forward rate agreement.
    /// Encoded/decoded by serializers as &quot;FRAS&quot;.
    /// </summary>
    [EnumMember(Value = "FRAS")]
    [IsoId("_ytg2YQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type forward rate agreement.")]
    ForwardRateAgreement = FinancialInstrumentContractTypeCode.ForwardRateAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_y2S-8QOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type future.")]
    Futures = FinancialInstrumentContractTypeCode.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_y81r0QOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type option.|")]
    Option = FinancialInstrumentContractTypeCode.Option, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of other financial instrument contract type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zEImoQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of other financial instrument contract type.")]
    Other = FinancialInstrumentContractTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type spread betting.
    /// Encoded/decoded by serializers as &quot;SPDB&quot;.
    /// </summary>
    [EnumMember(Value = "SPDB")]
    [IsoId("_zxpz8QOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type spread betting.|")]
    SpreadBetting = FinancialInstrumentContractTypeCode.SpreadBetting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_z48uwQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type swap.|")]
    Swap = FinancialInstrumentContractTypeCode.Swap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type swaption.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_z_WRsQOBEeWs3sTa9Sj6Lg")]
    [Description(@"Contract of type swaption.|")]
    Swaption = FinancialInstrumentContractTypeCode.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type future on a swap.
    /// Encoded/decoded by serializers as &quot;FONS&quot;.
    /// </summary>
    [EnumMember(Value = "FONS")]
    [IsoId("_tbKSAQnOEeW1sbwBDSZgiA")]
    [Description(@"Contract of type future on a swap.")]
    FuturesOnSwap = FinancialInstrumentContractTypeCode.FuturesOnSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type portfolio swap.
    /// Encoded/decoded by serializers as &quot;PSWP&quot;.
    /// </summary>
    [EnumMember(Value = "PSWP")]
    [IsoId("_CkMosQ3qEeWc7_0KPiuk6w")]
    [Description(@"Contract of type portfolio swap.")]
    PortfolioSwap = FinancialInstrumentContractTypeCode.PortfolioSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type forward freight agreement.
    /// Encoded/decoded by serializers as &quot;FFAS&quot;.
    /// </summary>
    [EnumMember(Value = "FFAS")]
    [IsoId("_Mzy3UXwWEeWa36CuR-uOCw")]
    [Description(@"Contract of type forward freight agreement.")]
    ForwardFreightAgreement = FinancialInstrumentContractTypeCode.ForwardFreightAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract of type forwards on a swap.
    /// Encoded/decoded by serializers as &quot;FWOS&quot;.
    /// </summary>
    [EnumMember(Value = "FWOS")]
    [IsoId("_M8IT8XwWEeWa36CuR-uOCw")]
    [Description(@"Contract of type forwards on a swap.")]
    ForwardsOnASwap = FinancialInstrumentContractTypeCode.ForwardsOnASwap, // same ordinal as derivation source for type conversions
}
