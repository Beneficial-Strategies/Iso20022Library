// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of an advice, a request or a movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKeN-Np-Ed-ak6NoX_4Aeg_969222817")]
[Description(@"Specifies the processing status of an advice, a request or a movement.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus3Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKnX4Np-Ed-ak6NoX_4Aeg_-807236817")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_aKnX4dp-Ed-ak6NoX_4Aeg_-807236816")]
    [Description(@"The processing of the request is pending.")]
    Pending = CorporateActionProcessedStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aKnX4tp-Ed-ak6NoX_4Aeg_-807236786")]
    [Description(@"The request is accepted.")]
    Accepted = CorporateActionProcessedStatusCode.Accepted, // same ordinal as derivation source for type conversions
}
