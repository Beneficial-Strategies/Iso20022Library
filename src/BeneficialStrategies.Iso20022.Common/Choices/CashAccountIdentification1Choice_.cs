// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a cash account.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification1Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification1Choice.BBAN))]
    [KnownType(typeof(CashAccountIdentification1Choice.UPIC))]
    [KnownType(typeof(CashAccountIdentification1Choice.DomesticAccount))]
    [JsonDerivedType(
        typeof(CashAccountIdentification1Choice.IBAN),
        nameof(CashAccountIdentification1Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification1Choice.BBAN),
        nameof(CashAccountIdentification1Choice.BBAN)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification1Choice.UPIC),
        nameof(CashAccountIdentification1Choice.UPIC)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification1Choice.DomesticAccount),
        nameof(CashAccountIdentification1Choice.DomesticAccount)
    )]
    [IsoId("_PdwzpNp-Ed-ak6NoX_4Aeg_2060838761")]
    [DisplayName("Cash Account Identification 1 Choice")]
    public abstract record CashAccountIdentification1Choice_ { }
}
