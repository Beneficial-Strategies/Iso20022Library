// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of response requested from the receiver of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVH6Vdp-Ed-ak6NoX_4Aeg_336259036")]
[Description(@"Specifies the level of response requested from the receiver of the message.")]
[Derivations(typeof(ResponseLevel1Code))]
public enum ResponseLevelCode
{
    /// <summary>
    /// No acknowledgement is requested.
    /// Encoded/decoded by serializers as &quot;NACK&quot;.
    /// </summary>
    [EnumMember(Value = "NACK")]
    [IsoId("_ZVH6Vtp-Ed-ak6NoX_4Aeg_336259037")]
    [Description(@"No acknowledgement is requested.")]
    NoAcknowledgement,
    
    /// <summary>
    /// Acknowledgement of only negative or erroneous messages is requested.
    /// Encoded/decoded by serializers as &quot;ACNE&quot;.
    /// </summary>
    [EnumMember(Value = "ACNE")]
    [IsoId("_ZVH6V9p-Ed-ak6NoX_4Aeg_336259038")]
    [Description(@"Acknowledgement of only negative or erroneous messages is requested.")]
    AcknowledgementNegativeError,
    
    /// <summary>
    /// Acknowledgement of each message is requested.
    /// Encoded/decoded by serializers as &quot;ACEA&quot;.
    /// </summary>
    [EnumMember(Value = "ACEA")]
    [IsoId("_ZVH6WNp-Ed-ak6NoX_4Aeg_336259046")]
    [Description(@"Acknowledgement of each message is requested.")]
    AcknowledgementEach,
    
}
