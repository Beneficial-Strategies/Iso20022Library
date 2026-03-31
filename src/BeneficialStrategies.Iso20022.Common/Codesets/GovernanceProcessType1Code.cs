// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of governance process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ysK0kID5Eeiw-daIkkmMqQ")]
[Description(@"Specifies a type of governance process.")]
[DerivedFrom(typeof(GovernanceProcessTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GovernanceProcessType1Code>))]
#endif
public enum GovernanceProcessType1Code
{
    /// <summary>
    /// Product governance procedure is comparable to MiFID II.
    /// Encoded/decoded by serializers as &quot;BMIF&quot;.
    /// </summary>
    [EnumMember(Value = "BMIF")]
    [IsoId("_z5Y1oYD5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is comparable to MiFID II.")]
    ComparibleMiFID = GovernanceProcessTypeCode.ComparibleMiFID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No information is requested from the issuer.
    /// Encoded/decoded by serializers as &quot;NINF&quot;.
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_z-SjwYD5Eeiw-daIkkmMqQ")]
    [Description(@"No information is requested from the issuer.")]
    NoInformation = GovernanceProcessTypeCode.NoInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Product governance procedure is not in accordance with MiFID II.
    /// Encoded/decoded by serializers as &quot;CMIF&quot;.
    /// </summary>
    [EnumMember(Value = "CMIF")]
    [IsoId("_0CwNAYD5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is not in accordance with MiFID II.")]
    NotMiFID = GovernanceProcessTypeCode.NotMiFID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Product governance procedure is pursuant to MiFID II.
    /// Encoded/decoded by serializers as &quot;AMIF&quot;.
    /// </summary>
    [EnumMember(Value = "AMIF")]
    [IsoId("_0HN2QYD5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is pursuant to MiFID II.")]
    PursuantMiFID = GovernanceProcessTypeCode.PursuantMiFID, // same ordinal as derivation source for type conversions
}
