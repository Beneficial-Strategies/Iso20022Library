// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification1Choice.IBAN))]
    [KnownType(typeof(AccountIdentification1Choice.BBAN))]
    [KnownType(typeof(AccountIdentification1Choice.UPIC))]
    [KnownType(typeof(AccountIdentification1Choice.DomesticAccount))]
    [JsonDerivedType(
        typeof(AccountIdentification1Choice.IBAN),
        nameof(AccountIdentification1Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification1Choice.BBAN),
        nameof(AccountIdentification1Choice.BBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification1Choice.UPIC),
        nameof(AccountIdentification1Choice.UPIC)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification1Choice.DomesticAccount),
        nameof(AccountIdentification1Choice.DomesticAccount)
    )]
    [IsoId("_Pdd4t9p-Ed-ak6NoX_4Aeg_2089502043")]
    [DisplayName("Account Identification 1 Choice")]
    public abstract record AccountIdentification1Choice_ { }
}
