// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1YzMNp-Ed-ak6NoX_4Aeg_890260104")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[Derivations(typeof(CancelledStatusReason17Code),typeof(CancelledStatusReason8Code),typeof(CancelledStatusReason3Code),typeof(CancellationCompleteStatusReason1Code),typeof(CancelledStatusReason1Code),typeof(CancelledStatusReason2Code))]
public enum CancelledStatusReasonCode
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a1YzMdp-Ed-ak6NoX_4Aeg_1461921044")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself,
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a1YzMtp-Ed-ak6NoX_4Aeg_1461921447")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem,
    
    /// <summary>
    /// Transaction is cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a1YzM9p-Ed-ak6NoX_4Aeg_1461921482")]
    [Description(@"Transaction is cancelled by the agent.")]
    CancelledByAgent,
    
    /// <summary>
    /// Other (see additional information).
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a1YzNNp-Ed-ak6NoX_4Aeg_1476697330")]
    [Description(@"Other (see additional information).")]
    Other,
    
    /// <summary>
    /// Transaction is cancelled by the hub.
    /// Encoded/decoded by serializers as &quot;CANH&quot;.
    /// </summary>
    [EnumMember(Value = "CANH")]
    [IsoId("_a1YzNdp-Ed-ak6NoX_4Aeg_-1256122966")]
    [Description(@"Transaction is cancelled by the hub.")]
    CancelledByHub,
    
    /// <summary>
    /// Transaction is cancelled by the instructing party.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_a1YzNtp-Ed-ak6NoX_4Aeg_-1256122906")]
    [Description(@"Transaction is cancelled by the instructing party.")]
    CancelledByInstructingParty,
    
    /// <summary>
    /// Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.
    /// Encoded/decoded by serializers as &quot;CXLR&quot;.
    /// </summary>
    [EnumMember(Value = "CXLR")]
    [IsoId("_a1YzN9p-Ed-ak6NoX_4Aeg_-1256122829")]
    [Description(@"Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.")]
    EndOfLife,
    
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a1YzONp-Ed-ak6NoX_4Aeg_-1256122769")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.")]
    CancelledByOther,
    
    /// <summary>
    /// Transaction is cancelled by the transfer agent.
    /// Encoded/decoded by serializers as &quot;CNTA&quot;.
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_a1YzOdp-Ed-ak6NoX_4Aeg_-1256122691")]
    [Description(@"Transaction is cancelled by the transfer agent.")]
    CancelledByTransferAgent,
    
    /// <summary>
    /// Transaction is cancelled by the client.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a1h9INp-Ed-ak6NoX_4Aeg_-1256122379")]
    [Description(@"Transaction is cancelled by the client.")]
    CancelledByClient,
    
    /// <summary>
    /// Transaction is cancelled by the intermediary.
    /// Encoded/decoded by serializers as &quot;CNIN&quot;.
    /// </summary>
    [EnumMember(Value = "CNIN")]
    [IsoId("_a1h9Idp-Ed-ak6NoX_4Aeg_-1256122302")]
    [Description(@"Transaction is cancelled by the intermediary.")]
    CancelledByIntermediary,
    
}
