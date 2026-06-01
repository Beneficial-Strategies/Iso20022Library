// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of notice for a redemption announcement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_V1N_IKD7Ee-4O7NbwmwJkQ")]
[Description(@"Specifies the type of notice for a redemption announcement.")]
[Derivations(typeof(RedemptionAnnouncementNoticeType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RedemptionAnnouncementNoticeTypeCode>))]
public enum RedemptionAnnouncementNoticeTypeCode
{
    /// <summary>
    /// Notice is sent by the depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Q04cUKD8Ee-4O7NbwmwJkQ")]
    [Description(@"Notice is sent by the depository.")]
    Depository,

    /// <summary>
    /// Notice is universal.
    /// Encoded/decoded by serializers as &quot;UNVL&quot;.
    /// </summary>
    [EnumMember(Value = "UNVL")]
    [IsoId("_FpUi0KD8Ee-4O7NbwmwJkQ")]
    [Description(@"Notice is universal.")]
    Universal,
}
