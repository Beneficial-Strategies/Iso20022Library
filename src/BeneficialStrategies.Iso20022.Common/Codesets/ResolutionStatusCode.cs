// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a resolution in a meeting agenda.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU0_aNp-Ed-ak6NoX_4Aeg_1388201869")]
[Description(@"Specifies the status of a resolution in a meeting agenda.")]
[Derivations(typeof(ResolutionStatus1Code),typeof(ResolutionStatus2Code))]
public enum ResolutionStatusCode
{
    /// <summary>
    /// Meeting resolution has to be voted for by the participants to a general meeting.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZU-JUNp-Ed-ak6NoX_4Aeg_1419601443")]
    [Description(@"Meeting resolution has to be voted for by the participants to a general meeting.")]
    Active,
    
    /// <summary>
    /// Meeting resolution has been withdrawn.
    /// Encoded/decoded by serializers as &quot;WDRA&quot;.
    /// </summary>
    [EnumMember(Value = "WDRA")]
    [IsoId("_ZU-JUdp-Ed-ak6NoX_4Aeg_1710508898")]
    [Description(@"Meeting resolution has been withdrawn.")]
    Withdrawn,
    
    /// <summary>
    /// Meeting resolution has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_XE0YYF63EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Meeting resolution has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_eBOw4F63EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been accepted.")]
    Accepted,
    
}
