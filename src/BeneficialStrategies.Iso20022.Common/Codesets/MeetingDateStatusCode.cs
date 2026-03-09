// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible statuses of a meeting date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVWBNtp-Ed-ak6NoX_4Aeg_-958051818")]
[Description(@"Identifies the possible statuses of a meeting date.")]
[Derivations(typeof(MeetingDateStatus1Code),typeof(MeetingDateStatus2Code))]
public enum MeetingDateStatusCode
{
    /// <summary>
    /// Meeting date is tentative.
    /// Encoded/decoded by serializers as &quot;TNTA&quot;.
    /// </summary>
    [EnumMember(Value = "TNTA")]
    [IsoId("_aVWBN9p-Ed-ak6NoX_4Aeg_-471354872")]
    [Description(@"Meeting date is tentative.")]
    Tentative,
    
    /// <summary>
    /// Meeting date is confirmed.
    /// Encoded/decoded by serializers as &quot;CNFR&quot;.
    /// </summary>
    [EnumMember(Value = "CNFR")]
    [IsoId("_aVWBONp-Ed-ak6NoX_4Aeg_-66852936")]
    [Description(@"Meeting date is confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Meeting date has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aVfyMNp-Ed-ak6NoX_4Aeg_564891")]
    [Description(@"Meeting date has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Meeting could not take place as the quorum was not reached.
    /// Encoded/decoded by serializers as &quot;NOQO&quot;.
    /// </summary>
    [EnumMember(Value = "NOQO")]
    [IsoId("_aVfyMdp-Ed-ak6NoX_4Aeg_2083943406")]
    [Description(@"Meeting could not take place as the quorum was not reached.")]
    NoQuorum,
    
}
