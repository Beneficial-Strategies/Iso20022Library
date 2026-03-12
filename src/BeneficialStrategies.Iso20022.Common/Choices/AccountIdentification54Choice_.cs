// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification54Choice.Card))]
    [KnownType(typeof(AccountIdentification54Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification54Choice.EMail))]
    [KnownType(typeof(AccountIdentification54Choice.IBAN))]
    [KnownType(typeof(AccountIdentification54Choice.BBAN))]
    [KnownType(typeof(AccountIdentification54Choice.UPIC))]
    [KnownType(typeof(AccountIdentification54Choice.Domestic))]
    [KnownType(typeof(AccountIdentification54Choice.Other))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.Card),nameof(AccountIdentification54Choice.Card))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.MSISDN),nameof(AccountIdentification54Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.EMail),nameof(AccountIdentification54Choice.EMail))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.IBAN),nameof(AccountIdentification54Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.BBAN),nameof(AccountIdentification54Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.UPIC),nameof(AccountIdentification54Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.Domestic),nameof(AccountIdentification54Choice.Domestic))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.Other),nameof(AccountIdentification54Choice.Other))]
    [IsoId("_5jK-cVHSEey4xOoMoOPSJQ")]
    [DisplayName("Account Identification 54 Choice")]
    public abstract partial record AccountIdentification54Choice_
    {
    }
}
