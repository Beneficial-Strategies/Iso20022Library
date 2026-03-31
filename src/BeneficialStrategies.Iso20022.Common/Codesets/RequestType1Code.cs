// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUOicNp-Ed-ak6NoX_4Aeg_979401735")]
[Description(
    @"Specifies the request used to further detail the type of information that will be queried."
)]
[DerivedFrom(typeof(RequestTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RequestType1Code>))]
#endif
public enum RequestType1Code
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as &quot;RT01&quot;.
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_ZUOicdp-Ed-ak6NoX_4Aeg_979401766")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending = RequestTypeCode.ReleasePending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as &quot;RT02&quot;.
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_ZUOictp-Ed-ak6NoX_4Aeg_979401797")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal = RequestTypeCode.HoldNormal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is a request to cancellation a transaction.
    /// Encoded/decoded by serializers as &quot;RT03&quot;.
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_ZUOic9p-Ed-ak6NoX_4Aeg_979401827")]
    [Description(@"Type is a request to cancellation a transaction.")]
    Cancellation = RequestTypeCode.Cancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as &quot;RT04&quot;.
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_ZUOidNp-Ed-ak6NoX_4Aeg_979401828")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence = RequestTypeCode.ReSequence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as &quot;RT05&quot;.
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_ZUOiddp-Ed-ak6NoX_4Aeg_979401858")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious = RequestTypeCode.ReleaseSuspicious, // same ordinal as derivation source for type conversions
}
