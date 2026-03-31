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
[IsoId("_YbT9d9p-Ed-ak6NoX_4Aeg_643669747")]
[Description(@"Specifies the agreement type details for the margin call.")]
[DerivedFrom(typeof(AgreementFrameworkCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AgreementFramework1Code>))]
#endif
public enum AgreementFramework1Code
{
    /// <summary>
    /// French Banker&apos;s Association Agreement.
    /// Encoded/decoded by serializers as &quot;FBAA&quot;.
    /// </summary>
    [EnumMember(Value = "FBAA")]
    [IsoId("_YbdHYNp-Ed-ak6NoX_4Aeg_2036640841")]
    [Description(@"French Banker's Association Agreement.")]
    FBAAgreement = AgreementFrameworkCode.FBAAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// British Banker&apos;s Association Agreement.
    /// Encoded/decoded by serializers as &quot;BBAA&quot;.
    /// </summary>
    [EnumMember(Value = "BBAA")]
    [IsoId("_YbdHYdp-Ed-ak6NoX_4Aeg_-1672379429")]
    [Description(@"British Banker's Association Agreement.")]
    BBAAgreement = AgreementFrameworkCode.BBAAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// German Rahmenvertrag Agreement.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_YbdHYtp-Ed-ak6NoX_4Aeg_1243904924")]
    [Description(@"German Rahmenvertrag Agreement.")]
    GermanRahmenvertragAgreement = AgreementFrameworkCode.GermanRahmenvertragAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International Swaps and Derivatives Association Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_YbdHY9p-Ed-ak6NoX_4Aeg_1130065858")]
    [Description(@"International Swaps and Derivatives Association Agreement.")]
    ISDAAgreement = AgreementFrameworkCode.ISDAAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No information about the master agreement is available.
    /// Encoded/decoded by serializers as &quot;NONR&quot;.
    /// </summary>
    [EnumMember(Value = "NONR")]
    [IsoId("_YbdHZNp-Ed-ak6NoX_4Aeg_1232806147")]
    [Description(@"No information about the master agreement is available.")]
    NoReference = AgreementFrameworkCode.NoReference, // same ordinal as derivation source for type conversions
}
