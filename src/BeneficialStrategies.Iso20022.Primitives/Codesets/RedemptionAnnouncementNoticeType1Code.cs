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
[IsoId("_5csYcKD8Ee-4O7NbwmwJkQ")]
[Description(@"Specifies the type of notice for a redemption announcement.")]
[DerivedFrom(typeof(RedemptionAnnouncementNoticeTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RedemptionAnnouncementNoticeType1Code>))]
public enum RedemptionAnnouncementNoticeType1Code
{
    /// <summary>
    /// Notice is sent by the depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_7adFoaD8Ee-4O7NbwmwJkQ")]
    [Description(@"Notice is sent by the depository.")]
    Depository = RedemptionAnnouncementNoticeTypeCode.Depository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notice is universal.
    /// Encoded/decoded by serializers as &quot;UNVL&quot;.
    /// </summary>
    [EnumMember(Value = "UNVL")]
    [IsoId("_7iNTcqD8Ee-4O7NbwmwJkQ")]
    [Description(@"Notice is universal.")]
    Universal = RedemptionAnnouncementNoticeTypeCode.Universal, // same ordinal as derivation source for type conversions
}
