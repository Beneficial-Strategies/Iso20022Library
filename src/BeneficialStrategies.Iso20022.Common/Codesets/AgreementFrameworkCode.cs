// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the agreement type details for the margin call.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbdHZdp-Ed-ak6NoX_4Aeg_630710567")]
[Description(@"Specifies the agreement type details for the margin call.")]
[Derivations(typeof(AgreementFramework1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AgreementFrameworkCode>))]
#endif
public enum AgreementFrameworkCode
{
    /// <summary>
    /// French Banker&apos;s Association Agreement.
    /// Encoded/decoded by serializers as &quot;FBAA&quot;.
    /// </summary>
    [EnumMember(Value = "FBAA")]
    [IsoId("_YbdHZtp-Ed-ak6NoX_4Aeg_-475249815")]
    [Description(@"French Banker's Association Agreement.")]
    FBAAgreement,

    /// <summary>
    /// British Banker&apos;s Association Agreement.
    /// Encoded/decoded by serializers as &quot;BBAA&quot;.
    /// </summary>
    [EnumMember(Value = "BBAA")]
    [IsoId("_Ybm4YNp-Ed-ak6NoX_4Aeg_-482117852")]
    [Description(@"British Banker's Association Agreement.")]
    BBAAgreement,

    /// <summary>
    /// German Rahmenvertrag Agreement.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_Ybm4Ydp-Ed-ak6NoX_4Aeg_368638088")]
    [Description(@"German Rahmenvertrag Agreement.")]
    GermanRahmenvertragAgreement,

    /// <summary>
    /// International Swaps and Derivatives Association Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_Ybm4Ytp-Ed-ak6NoX_4Aeg_343206723")]
    [Description(@"International Swaps and Derivatives Association Agreement.")]
    ISDAAgreement,

    /// <summary>
    /// No information about the master agreement is available.
    /// Encoded/decoded by serializers as &quot;NONR&quot;.
    /// </summary>
    [EnumMember(Value = "NONR")]
    [IsoId("_Ybm4Y9p-Ed-ak6NoX_4Aeg_-2097675031")]
    [Description(@"No information about the master agreement is available.")]
    NoReference,
}
