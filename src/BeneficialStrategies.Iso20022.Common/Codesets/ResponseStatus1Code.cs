// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9uuBdp-Ed-ak6NoX_4Aeg_-788093726")]
[Description(
    @"Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective."
)]
[DerivedFrom(typeof(ResponseStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResponseStatus1Code>))]
#endif
public enum ResponseStatus1Code
{
    /// <summary>
    /// Part of the collateral is accepted, a part rejected.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Y9uuBtp-Ed-ak6NoX_4Aeg_-788093724")]
    [Description(@"Part of the collateral is accepted, a part rejected.")]
    PartlyAccepted = ResponseStatusCode.PartlyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Claim, substitution, proposal is fully accepted.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_Y9uuB9p-Ed-ak6NoX_4Aeg_-788093696")]
    [Description(@"Claim, substitution, proposal is fully accepted.")]
    Accepted = ResponseStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Claim, substitution, proposal is fully rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_Y9uuCNp-Ed-ak6NoX_4Aeg_-788093695")]
    [Description(@"Claim, substitution, proposal is fully rejected.")]
    Rejected = ResponseStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_Y9uuCdp-Ed-ak6NoX_4Aeg_-788093665")]
    [Description(
        @"Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral."
    )]
    SubstitutionAccepted = ResponseStatusCode.SubstitutionAccepted, // same ordinal as derivation source for type conversions
}
