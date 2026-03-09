// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Oq2Raq7DEemG7MmivSuE5g")]
[Description(@"Specifies the type of security holders meeting.")]
[Derivations(typeof(MeetingType4Code))]
public enum MeetingTypeV2Code
{
    /// <summary>
    /// Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_Oq2Rc67DEemG7MmivSuE5g")]
    [Description(@"Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.")]
    AnnualGeneralMeeting,
    
    /// <summary>
    /// Specifies a meeting that is not planned in the by laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_Oq2RcK7DEemG7MmivSuE5g")]
    [Description(@"Specifies a meeting that is not planned in the by laws.")]
    Ordinary,
    
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_Oq2Rb67DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    Extraordinary,
    
    /// <summary>
    /// Meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_Oq2Rbq7DEemG7MmivSuE5g")]
    [Description(@"Meeting which contains both ordinary and extraordinary resolutions.")]
    Mixed,
    
    /// <summary>
    /// Meeting for a class of assets.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_Oq2RbK7DEemG7MmivSuE5g")]
    [Description(@"Meeting for a class of assets.")]
    ClassMeeting,
    
    /// <summary>
    /// Meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_Oq2Ra67DEemG7MmivSuE5g")]
    [Description(@"Meeting is the result of a legal proceeding.")]
    CourtMeeting,
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_Oq2Rca7DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special,
    
    /// <summary>
    /// Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;GMET&quot;.
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_Oq2Rcq7DEemG7MmivSuE5g")]
    [Description(@"Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.")]
    General,
    
    /// <summary>
    /// Physical meeting of bond holders.
    /// Encoded/decoded by serializers as &quot;BMET&quot;.
    /// </summary>
    [EnumMember(Value = "BMET")]
    [IsoId("_Oq2Rba7DEemG7MmivSuE5g")]
    [Description(@"Physical meeting of bond holders.")]
    BondHolderMeeting,
    
}
