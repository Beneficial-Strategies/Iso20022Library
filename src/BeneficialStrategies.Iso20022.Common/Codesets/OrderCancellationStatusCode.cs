// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQk189p-Ed-ak6NoX_4Aeg_85357733")]
[Description(@"Specifies the current status of the order cancellation request.")]
[Derivations(typeof(OrderCancellationStatus1Code),typeof(OrderCancellationStatus2Code))]
public enum OrderCancellationStatusCode
{
    /// <summary>
    /// Order cancellation request has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aQk19Np-Ed-ak6NoX_4Aeg_117683450")]
    [Description(@"Order cancellation request has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aQk19dp-Ed-ak6NoX_4Aeg_131534414")]
    [Description(@"Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.")]
    CancellationPending,
    
    /// <summary>
    /// Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aQk19tp-Ed-ak6NoX_4Aeg_573306707")]
    [Description(@"Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.")]
    CancellationCompleted,
    
    /// <summary>
    /// Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_XxrFEdcPEeaX5rvhR0a-OQ")]
    [Description(@"Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received,
    
}
