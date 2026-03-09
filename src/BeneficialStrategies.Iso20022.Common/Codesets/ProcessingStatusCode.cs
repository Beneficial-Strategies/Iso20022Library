// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLN009p-Ed-ak6NoX_4Aeg_-1445203123")]
[Description(@"Specifies the processing status.")]
[Derivations(typeof(ProcessingStatus1Code))]
public enum ProcessingStatusCode
{
    /// <summary>
    /// Message contains complete details of the corporate action event at the time the event is communicated and the occurrence of the event has been confirmed by the account servicer&apos;s chosen official source. Further updates to the event are still possible.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aLN01Np-Ed-ak6NoX_4Aeg_-1415651502")]
    [Description(@"Message contains complete details of the corporate action event at the time the event is communicated and the occurrence of the event has been confirmed by the account servicer's chosen official source. Further updates to the event are still possible.")]
    Complete,
    
    /// <summary>
    /// Message may not contain complete details of the corporate action event,|however, the occurrence of the event is confirmed.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_aLN01dp-Ed-ak6NoX_4Aeg_-1410107405")]
    [Description(@"Message may not contain complete details of the corporate action event,|however, the occurrence of the event is confirmed.")]
    PreliminaryConfirmed,
    
    /// <summary>
    /// Message may not contain complete details of the corporate action event and|the occurrence of the event is not yet confirmed.
    /// Encoded/decoded by serializers as &quot;PREU&quot;.
    /// </summary>
    [EnumMember(Value = "PREU")]
    [IsoId("_aLN01tp-Ed-ak6NoX_4Aeg_-1383325513")]
    [Description(@"Message may not contain complete details of the corporate action event and|the occurrence of the event is not yet confirmed.")]
    PreliminaryUnconfirmed,
    
    /// <summary>
    /// The message is for information only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aLN019p-Ed-ak6NoX_4Aeg_931194609")]
    [Description(@"The message is for information only.")]
    ForInformationOnly,
    
}
