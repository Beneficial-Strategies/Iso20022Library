// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification80Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification80Choice.BBAN))]
    [KnownType(typeof(AccountIdentification80Choice.DomesticAccount))]
    [KnownType(typeof(AccountIdentification80Choice.Email))]
    [KnownType(typeof(AccountIdentification80Choice.IBAN))]
    [KnownType(typeof(AccountIdentification80Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification80Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.BBAN),nameof(AccountIdentification80Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.DomesticAccount),nameof(AccountIdentification80Choice.DomesticAccount))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.Email),nameof(AccountIdentification80Choice.Email))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.IBAN),nameof(AccountIdentification80Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.MSISDN),nameof(AccountIdentification80Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification80Choice.UPIC),nameof(AccountIdentification80Choice.UPIC))]
    [IsoId("_pIbZgZ9sEe-nbM0aSPcoiQ")]
    [DisplayName("Account Identification80Choice")]
    public abstract partial record AccountIdentification80Choice_
    {
    }
}
