// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the contract type of a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3gF7gJHrEeabEPkKgPJPcA")]
[Description(@"Specifies the contract type of a derivative.")]
[DerivedFrom(typeof(FinancialInstrumentContractTypeCode))]
public enum FinancialInstrumentContractType2Code
{
    /// <summary>
    /// Contract of type contracts for difference.
    /// Encoded/decoded by serializers as &quot;CFDS&quot;.
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_6FDLkZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type contracts for difference.")]
    ContractForDifference = FinancialInstrumentContractTypeCode.ContractForDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type forward rate agreement.
    /// Encoded/decoded by serializers as &quot;FRAS&quot;.
    /// </summary>
    [EnumMember(Value = "FRAS")]
    [IsoId("_6mlLUZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type forward rate agreement.")]
    ForwardRateAgreement = FinancialInstrumentContractTypeCode.ForwardRateAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_7jFP0ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type future.")]
    Futures = FinancialInstrumentContractTypeCode.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type forward.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_8OmSAZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type forward.||")]
    Forward = FinancialInstrumentContractTypeCode.Forward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_8o0v4ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type option.|")]
    Option = FinancialInstrumentContractTypeCode.Option, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type spread betting.
    /// Encoded/decoded by serializers as &quot;SPDB&quot;.
    /// </summary>
    [EnumMember(Value = "SPDB")]
    [IsoId("_9HN8EZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type spread betting.|")]
    SpreadBetting = FinancialInstrumentContractTypeCode.SpreadBetting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_9yJIYZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type swap.|")]
    Swap = FinancialInstrumentContractTypeCode.Swap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of type swaption.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_-I73wZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type swaption.|")]
    Swaption = FinancialInstrumentContractTypeCode.Swaption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract of other financial instrument contract type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-oFR4ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of other financial instrument contract type.")]
    Other = FinancialInstrumentContractTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
