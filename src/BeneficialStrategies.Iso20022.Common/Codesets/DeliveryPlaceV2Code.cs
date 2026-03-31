// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the place of delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iSfctg1eEeu_4e16J8D_UA")]
[Description(@"Specifies the place of delivery.")]
[Derivations(typeof(DeliveryPlace3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeliveryPlaceV2Code>))]
#endif
public enum DeliveryPlaceV2Code
{
    /// <summary>
    /// Card needs to be mailed to employer&apos;s address.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_iSfctw1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to employer's address.")]
    Employer,

    /// <summary>
    /// Card needs to be mailed to the individual specified in PersonDetail.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_iSfcuQ1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be mailed to the individual specified in PersonDetail.")]
    Individual,

    /// <summary>
    /// Card needs to be available at the entrance of the meeting.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_iSfcuA1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be available at the entrance of the meeting.")]
    MeetingEntrance,

    /// <summary>
    /// Cards needs to be send to another specified address.
    /// Encoded/decoded by serializers as &quot;OADR&quot;.
    /// </summary>
    [EnumMember(Value = "OADR")]
    [IsoId("_iSfcuw1eEeu_4e16J8D_UA")]
    [Description(@"Cards needs to be send to another specified address.")]
    OtherAddress,

    /// <summary>
    /// Card needs to be sent via e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_iSfcug1eEeu_4e16J8D_UA")]
    [Description(@"Card needs to be sent via e-mail.")]
    Email,
}
