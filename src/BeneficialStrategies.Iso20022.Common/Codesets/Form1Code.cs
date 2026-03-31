// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a physical form is required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vr6_Btp-Ed-ak6NoX_4Aeg_1756006615")]
[Description(@"Specifies whether a physical form is required.")]
[DerivedFrom(typeof(FormCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Form1Code>))]
#endif
public enum Form1Code
{
    /// <summary>
    /// A phsyical form is required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_Vr6_B9p-Ed-ak6NoX_4Aeg_1756006617")]
    [Description(@"A phsyical form is required through the main fund order desk.")]
    Required = FormCode.Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A phsyical form is not required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;NREQ&quot;.
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_Vr6_CNp-Ed-ak6NoX_4Aeg_1756006646")]
    [Description(@"A phsyical form is not required through the main fund order desk.")]
    NotRequired = FormCode.NotRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A phsyical form with the investor&apos;s written signature is required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;SREQ&quot;.
    /// </summary>
    [EnumMember(Value = "SREQ")]
    [IsoId("_VsEwANp-Ed-ak6NoX_4Aeg_1756006647")]
    [Description(
        @"A phsyical form with the investor's written signature is required through the main fund order desk."
    )]
    SignatureRequired = FormCode.SignatureRequired, // same ordinal as derivation source for type conversions
}
