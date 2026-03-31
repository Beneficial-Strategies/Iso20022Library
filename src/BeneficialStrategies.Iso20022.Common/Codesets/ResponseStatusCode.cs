// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y94fANp-Ed-ak6NoX_4Aeg_1785427389")]
[Description(
    @"Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective."
)]
[Derivations(typeof(ResponseStatus1Code), typeof(ResponseStatus2Code))]
public enum ResponseStatusCode
{
    /// <summary>
    /// Part of the collateral is accepted, a part rejected.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Y94fAdp-Ed-ak6NoX_4Aeg_-2007141387")]
    [Description(@"Part of the collateral is accepted, a part rejected.")]
    PartlyAccepted,

    /// <summary>
    /// Claim, substitution, proposal is fully accepted.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_Y94fAtp-Ed-ak6NoX_4Aeg_-1286794697")]
    [Description(@"Claim, substitution, proposal is fully accepted.")]
    Accepted,

    /// <summary>
    /// Claim, substitution, proposal is fully rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_Y94fA9p-Ed-ak6NoX_4Aeg_-1200908229")]
    [Description(@"Claim, substitution, proposal is fully rejected.")]
    Rejected,

    /// <summary>
    /// Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_Y94fBNp-Ed-ak6NoX_4Aeg_-1161198752")]
    [Description(
        @"Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral."
    )]
    SubstitutionAccepted,

    /// <summary>
    /// Collateral giver instruction details are confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_dS5_gcf0EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are confirmed.")]
    Confirmed,

    /// <summary>
    /// Collateral giver instruction details are not recognised.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_euTmgcf0EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are not recognised.|")]
    NotRecognised,
}
