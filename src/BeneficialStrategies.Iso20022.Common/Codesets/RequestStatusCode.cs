// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUFYg9p-Ed-ak6NoX_4Aeg_1488265087")]
[Description(@"Specifies the coded status of invoice financing request.")]
[Derivations(typeof(RequestStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RequestStatusCode>))]
#endif
public enum RequestStatusCode
{
    /// <summary>
    /// Single Invoice/Instalment financing request has been financed.
    /// Encoded/decoded by serializers as &quot;FNCD&quot;.
    /// </summary>
    [EnumMember(Value = "FNCD")]
    [IsoId("_ZUFYhNp-Ed-ak6NoX_4Aeg_1919546667")]
    [Description(@"Single Invoice/Instalment financing request has been financed.")]
    Financed,

    /// <summary>
    /// Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZUFYhdp-Ed-ak6NoX_4Aeg_-809624912")]
    [Description(
        @"Single Invoice/Instalment financing request is in a pending status and more checks are ongoing."
    )]
    Pending,

    /// <summary>
    /// Single Invoice/Instalment financing request has not been financed.
    /// Encoded/decoded by serializers as &quot;NTFD&quot;.
    /// </summary>
    [EnumMember(Value = "NTFD")]
    [IsoId("_ZUFYhtp-Ed-ak6NoX_4Aeg_-1950599515")]
    [Description(@"Single Invoice/Instalment financing request has not been financed.")]
    NotFinanced,
}
