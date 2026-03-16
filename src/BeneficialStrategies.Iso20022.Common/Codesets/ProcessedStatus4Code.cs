// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of the standing instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKnX49p-Ed-ak6NoX_4Aeg_1007090482")]
[Description(@"Specifies the processing status of the standing instruction cancellation request.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus4Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKnX5Np-Ed-ak6NoX_4Aeg_-879600124")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The request has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aKnX5dp-Ed-ak6NoX_4Aeg_-879600094")]
    [Description(@"The request has been completed.")]
    Completed = CorporateActionProcessedStatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_aKnX5tp-Ed-ak6NoX_4Aeg_-879600093")]
    [Description(@"The processing of the request is pending.")]
    Pending = CorporateActionProcessedStatusCode.Pending, // same ordinal as derivation source for type conversions
}
