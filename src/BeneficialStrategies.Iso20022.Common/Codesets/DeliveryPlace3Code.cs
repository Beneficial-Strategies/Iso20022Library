// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the place of delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L915cA1fEeu_4e16J8D_UA")]
[Description(@"Specifies the place of delivery.")]
[DerivedFrom(typeof(DeliveryPlaceV2Code))]
public enum DeliveryPlace3Code
{
    /// <summary>
    /// Card needs to be sent via e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_OY3KYQ1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be sent via e-mail.")]
    Email = DeliveryPlaceV2Code.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card needs to be mailed to employer&apos;s address.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_OgTPIQ1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to employer's address.")]
    Employer = DeliveryPlaceV2Code.Employer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card needs to be mailed to the individual specified in PersonDetail.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_OoL_0Q1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to the individual specified in PersonDetail.")]
    Individual = DeliveryPlaceV2Code.Individual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_Ot174Q1fEeu_4e16J8D_UA")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    MeetingEntrance = DeliveryPlaceV2Code.MeetingEntrance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cards needs to be send to another specified address.
    /// Encoded/decoded by serializers as &quot;OADR&quot;.
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_O2KxcQ1fEeu_4e16J8D_UA")]
    [Description(@"Cards needs to be send to another specified address.")]
    OtherAddress = DeliveryPlaceV2Code.OtherAddress, // same ordinal as derivation source for type conversions
    
}
