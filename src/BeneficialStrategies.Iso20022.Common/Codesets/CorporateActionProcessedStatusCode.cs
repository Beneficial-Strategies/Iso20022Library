// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of a corporate action transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bR2Fs9p-Ed-ak6NoX_4Aeg_-1178553458")]
[Description(@"Specifies the processing status of a corporate action transaction.")]
[Derivations(typeof(ProcessedStatus4Code),typeof(ProcessedStatus6Code),typeof(ProcessedStatus3Code),typeof(ProcessedStatus5Code),typeof(ProcessedStatus1Code),typeof(ProcessedStatus2Code))]
public enum CorporateActionProcessedStatusCode
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_bR2FtNp-Ed-ak6NoX_4Aeg_-720484994")]
    [Description(@"The instruction/request has been received.")]
    Received,
    
    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bR2Ftdp-Ed-ak6NoX_4Aeg_-720484993")]
    [Description(@"The request is accepted.")]
    Accepted,
    
    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bR2Fttp-Ed-ak6NoX_4Aeg_-720484964")]
    [Description(@"The processing of the request is pending.")]
    Pending,
    
    /// <summary>
    /// The request has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bR2Ft9p-Ed-ak6NoX_4Aeg_-257800026")]
    [Description(@"The request has been completed.")]
    Completed,
    
    /// <summary>
    /// Awaiting the deactivation date.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_bR2FuNp-Ed-ak6NoX_4Aeg_638012647")]
    [Description(@"Awaiting the deactivation date.")]
    WaitingDeactivationDate,
    
    /// <summary>
    /// The advice has been sent to the market.
    /// Encoded/decoded by serializers as &quot;SENT&quot;.
    /// </summary>
    [EnumMember(Value = "SENT")]
    [IsoId("_bR_2sNp-Ed-ak6NoX_4Aeg_2107675327")]
    [Description(@"The advice has been sent to the market.")]
    SentToMarket,
    
    /// <summary>
    /// The announcement has been accepted but another source has provided different information.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_bR_2sdp-Ed-ak6NoX_4Aeg_-2058923992")]
    [Description(@"The announcement has been accepted but another source has provided different information.")]
    AcceptedWithWarning,
    
}
