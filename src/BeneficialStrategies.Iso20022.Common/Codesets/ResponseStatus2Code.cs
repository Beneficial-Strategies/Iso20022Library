// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DvI04Mf1EemlRYW9CHJ8_Q")]
[Description(
    @"Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective."
)]
[DerivedFrom(typeof(ResponseStatusCode))]
public enum ResponseStatus2Code
{
    /// <summary>
    /// Collateral giver instruction details are confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_FtcUocf1EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are confirmed.")]
    Confirmed = ResponseStatusCode.Confirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral giver instruction details are not recognised.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_Fzstocf1EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are not recognised.|")]
    NotRecognised = ResponseStatusCode.NotRecognised, // same ordinal as derivation source for type conversions
}
