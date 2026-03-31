// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPdXMtp-Ed-ak6NoX_4Aeg_330107896")]
[Description(@"Specifies if the stamp duty is applicable.")]
[DerivedFrom(typeof(StampDutyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StampDutyType1Code>))]
#endif
public enum StampDutyType1Code
{
    /// <summary>
    /// SDRT paid outside of CSD on corporate action.
    /// Encoded/decoded by serializers as &quot;SDRU&quot;.
    /// </summary>
    [EnumMember(Value = "SDRU")]
    [IsoId("_ZPdXM9p-Ed-ak6NoX_4Aeg_497267445")]
    [Description(@"SDRT paid outside of CSD on corporate action.")]
    OutsideCSD = StampDutyTypeCode.OutsideCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SDRT paid on another transaction.
    /// Encoded/decoded by serializers as &quot;SDRT&quot;.
    /// </summary>
    [EnumMember(Value = "SDRT")]
    [IsoId("_ZPdXNNp-Ed-ak6NoX_4Aeg_514814980")]
    [Description(@"SDRT paid on another transaction.")]
    Paid = StampDutyTypeCode.Paid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp duty not applicable.
    /// Encoded/decoded by serializers as &quot;SDRN&quot;.
    /// </summary>
    [EnumMember(Value = "SDRN")]
    [IsoId("_ZPdXNdp-Ed-ak6NoX_4Aeg_775244648")]
    [Description(@"Stamp duty not applicable.")]
    NotApplicable = StampDutyTypeCode.NotApplicable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exempt, for any other reason.
    /// Encoded/decoded by serializers as &quot;SDRQ&quot;.
    /// </summary>
    [EnumMember(Value = "SDRQ")]
    [IsoId("_ZPdXNtp-Ed-ak6NoX_4Aeg_814957832")]
    [Description(@"Exempt, for any other reason.")]
    Exemption = StampDutyTypeCode.Exemption, // same ordinal as derivation source for type conversions
}
