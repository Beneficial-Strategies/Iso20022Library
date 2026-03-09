// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLgvwtp-Ed-ak6NoX_4Aeg_-1244080292")]
[Description(@"Specifies the type of security holders meeting.")]
[Derivations(typeof(MeetingType1Code),typeof(MeetingType2Code),typeof(MeetingType3Code))]
public enum MeetingTypeCode
{
    /// <summary>
    /// Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_aLgvw9p-Ed-ak6NoX_4Aeg_2014713210")]
    [Description(@"Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.")]
    AnnualGeneralMeeting,
    
    /// <summary>
    /// Specifies a meeting that is not planned in the by laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_aLgvxNp-Ed-ak6NoX_4Aeg_1555440595")]
    [Description(@"Specifies a meeting that is not planned in the by laws.")]
    Ordinary,
    
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_aLgvxdp-Ed-ak6NoX_4Aeg_-1739813621")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    Extraordinary,
    
    /// <summary>
    /// Specifies a meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_aLgvxtp-Ed-ak6NoX_4Aeg_-1820621758")]
    [Description(@"Specifies a meeting which contains both ordinary and extraordinary resolutions.")]
    Mixed,
    
    /// <summary>
    /// Meeting for a class of assets.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_aLgvx9p-Ed-ak6NoX_4Aeg_-1876676760")]
    [Description(@"Meeting for a class of assets.")]
    ClassMeeting,
    
    /// <summary>
    /// Specifies that the meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_aLgvyNp-Ed-ak6NoX_4Aeg_-1807410883")]
    [Description(@"Specifies that the meeting is the result of a legal proceeding.")]
    CourtMeeting,
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_aLqgwNp-Ed-ak6NoX_4Aeg_-311079659")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special,
    
    /// <summary>
    /// Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;GMET&quot;.
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_aLqgwdp-Ed-ak6NoX_4Aeg_516436244")]
    [Description(@"Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated.")]
    General,
    
    /// <summary>
    /// Physical meeting of bond holders.
    /// Encoded/decoded by serializers as &quot;BMET&quot;.
    /// </summary>
    [EnumMember(Value = "BMET")]
    [IsoId("_BvKTYFuLEeSmO6RkXg92Lg")]
    [Description(@"Physical meeting of bond holders.")]
    BondHolderMeeting,
    
}
