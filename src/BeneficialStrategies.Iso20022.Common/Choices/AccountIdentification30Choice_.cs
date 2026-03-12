// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification30Choice.Card))]
    [KnownType(typeof(AccountIdentification30Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification30Choice.EMail))]
    [KnownType(typeof(AccountIdentification30Choice.IBAN))]
    [KnownType(typeof(AccountIdentification30Choice.BBAN))]
    [KnownType(typeof(AccountIdentification30Choice.UPIC))]
    [KnownType(typeof(AccountIdentification30Choice.Domestic))]
    [KnownType(typeof(AccountIdentification30Choice.Other))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.Card),nameof(AccountIdentification30Choice.Card))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.MSISDN),nameof(AccountIdentification30Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.EMail),nameof(AccountIdentification30Choice.EMail))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.IBAN),nameof(AccountIdentification30Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.BBAN),nameof(AccountIdentification30Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.UPIC),nameof(AccountIdentification30Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.Domestic),nameof(AccountIdentification30Choice.Domestic))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.Other),nameof(AccountIdentification30Choice.Other))]
    [IsoId("_cLSqYHs8EeSTS7uHCe8FPQ")]
    [DisplayName("Account Identification 30 Choice")]
    public abstract partial record AccountIdentification30Choice_
    {
    }
}
