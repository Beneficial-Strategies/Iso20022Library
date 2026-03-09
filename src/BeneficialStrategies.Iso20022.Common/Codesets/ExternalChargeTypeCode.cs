// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__92AcJF_EeeBGrZP1w0opg")]
[Description(@"Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalChargeType1Code))]
public enum ExternalChargeTypeCode
{
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_uLHG3PRYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee,
    
    /// <summary>
    /// Fee paid for processing a batch of transactions.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_uLQ30PRYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid for processing a batch of transactions.")]
    Batch,
    
    /// <summary>
    /// Fee paid for services provided.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uLQ30_RYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid for services provided.")]
    Commission,
    
    /// <summary>
    /// Summation of individual fees.
    /// Encoded/decoded by serializers as &quot;SUMM&quot;.
    /// </summary>
    [EnumMember(Value = "SUMM")]
    [IsoId("_uLQ31vRYEeuLhpyIdtJzwg")]
    [Description(@"Summation of individual fees.")]
    Summation,
    
}
