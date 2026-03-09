// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the occurrence of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajNeFNp-Ed-ak6NoX_4Aeg_-582418410")]
[Description(@"Indicates the status of the occurrence of an event.")]
[Derivations(typeof(EventConfirmationStatus1Code))]
public enum EventConfirmationStatusCode
{
    /// <summary>
    /// Occurrence of the event has been confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ajNeFdp-Ed-ak6NoX_4Aeg_-88336775")]
    [Description(@"Occurrence of the event has been confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Occurrence of the event has not been confirmed.
    /// Encoded/decoded by serializers as &quot;UCON&quot;.
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_ajNeFtp-Ed-ak6NoX_4Aeg_-88336774")]
    [Description(@"Occurrence of the event has not been confirmed.")]
    Unconfirmed,
    
    /// <summary>
    /// Occurrence of the event is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_k_9VoPyhEeq1mLMo4Zt_TQ")]
    [Description(@"Occurrence of the event is pending.")]
    Pending,
    
}
