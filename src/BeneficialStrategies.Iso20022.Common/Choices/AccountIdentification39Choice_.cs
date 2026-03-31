// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification39Choice.Card))]
    [KnownType(typeof(AccountIdentification39Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification39Choice.EMail))]
    [KnownType(typeof(AccountIdentification39Choice.IBAN))]
    [KnownType(typeof(AccountIdentification39Choice.BBAN))]
    [KnownType(typeof(AccountIdentification39Choice.UPIC))]
    [KnownType(typeof(AccountIdentification39Choice.Domestic))]
    [KnownType(typeof(AccountIdentification39Choice.Other))]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.Card),
        nameof(AccountIdentification39Choice.Card)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.MSISDN),
        nameof(AccountIdentification39Choice.MSISDN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.EMail),
        nameof(AccountIdentification39Choice.EMail)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.IBAN),
        nameof(AccountIdentification39Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.BBAN),
        nameof(AccountIdentification39Choice.BBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.UPIC),
        nameof(AccountIdentification39Choice.UPIC)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.Domestic),
        nameof(AccountIdentification39Choice.Domestic)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification39Choice.Other),
        nameof(AccountIdentification39Choice.Other)
    )]
    [IsoId("_metiEdmpEeeN3v2fup_Shw")]
    [DisplayName("Account Identification 39 Choice")]
    public abstract record AccountIdentification39Choice_ { }
}
