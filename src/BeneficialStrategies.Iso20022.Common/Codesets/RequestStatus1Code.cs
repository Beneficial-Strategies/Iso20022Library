// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZT7nidp-Ed-ak6NoX_4Aeg_783372839")]
[Description(@"Specifies the coded status of invoice financing request.")]
[DerivedFrom(typeof(RequestStatusCode))]
public enum RequestStatus1Code
{
    /// <summary>
    /// Single Invoice/Instalment financing request has been financed.
    /// Encoded/decoded by serializers as &quot;FNCD&quot;.
    /// </summary>
    [EnumMember(Value = "FNCD")]
    [IsoId("_ZUFYgNp-Ed-ak6NoX_4Aeg_783372870")]
    [Description(@"Single Invoice/Instalment financing request has been financed.")]
    Financed = RequestStatusCode.Financed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZUFYgdp-Ed-ak6NoX_4Aeg_783372871")]
    [Description(
        @"Single Invoice/Instalment financing request is in a pending status and more checks are ongoing."
    )]
    Pending = RequestStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single Invoice/Instalment financing request has not been financed.
    /// Encoded/decoded by serializers as &quot;NTFD&quot;.
    /// </summary>
    [EnumMember(Value = "NTFD")]
    [IsoId("_ZUFYgtp-Ed-ak6NoX_4Aeg_783372900")]
    [Description(@"Single Invoice/Instalment financing request has not been financed.")]
    NotFinanced = RequestStatusCode.NotFinanced, // same ordinal as derivation source for type conversions
}
