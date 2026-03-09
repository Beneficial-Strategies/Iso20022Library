// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies where the attendance card should be delivered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azANkNp-Ed-ak6NoX_4Aeg_-743931469")]
[Description(@"Specifies where the attendance card should be delivered.")]
[DerivedFrom(typeof(DeliveryPlaceCode))]
public enum DeliveryPlace1Code
{
    /// <summary>
    /// Card needs to be mailed to employers address.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_azANkdp-Ed-ak6NoX_4Aeg_-743931467")]
    [Description(@"Card needs to be mailed to employers address.")]
    Employer = DeliveryPlaceCode.Employer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card needs to be mailed to individual specified in PersonDetail.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_azANktp-Ed-ak6NoX_4Aeg_-743931451")]
    [Description(@"Card needs to be mailed to individual specified in PersonDetail.")]
    Individual = DeliveryPlaceCode.Individual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_azANk9p-Ed-ak6NoX_4Aeg_-743931450")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    EntranceOfMeeting = DeliveryPlaceCode.EntranceOfMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cards needs to be send to other specified address.
    /// Encoded/decoded by serializers as &quot;OADR&quot;.
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_azANlNp-Ed-ak6NoX_4Aeg_1639092662")]
    [Description(@"Cards needs to be send to other specified address.")]
    OtherAddress = DeliveryPlaceCode.OtherAddress, // same ordinal as derivation source for type conversions
    
}
