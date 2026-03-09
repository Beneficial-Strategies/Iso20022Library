// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the place of delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azANldp-Ed-ak6NoX_4Aeg_-684562382")]
[Description(@"Specifies the place of delivery.")]
[Derivations(typeof(DeliveryPlace1Code))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum DeliveryPlaceCode
{
    /// <summary>
    /// Card needs to be mailed to employers address.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_azANltp-Ed-ak6NoX_4Aeg_-454602632")]
    [Description(@"Card needs to be mailed to employers address.")]
    Employer,
    
    /// <summary>
    /// Card needs to be mailed to individual specified in PersonDetail.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_azANl9p-Ed-ak6NoX_4Aeg_-436132256")]
    [Description(@"Card needs to be mailed to individual specified in PersonDetail.")]
    Individual,
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_azANmNp-Ed-ak6NoX_4Aeg_-208945676")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    EntranceOfMeeting,
    
    /// <summary>
    /// Cards needs to be send to other specified address.
    /// Encoded/decoded by serializers as &quot;OADR&quot;.
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_azJXgNp-Ed-ak6NoX_4Aeg_-344048738")]
    [Description(@"Cards needs to be send to other specified address.")]
    OtherAddress,
    
    /// <summary>
    /// Card needs to be sent via e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_cWcAAPNqEeqRfth943bvEA")]
    [Description(@"Card needs to be sent via e-mail.")]
    Email,
    
}
