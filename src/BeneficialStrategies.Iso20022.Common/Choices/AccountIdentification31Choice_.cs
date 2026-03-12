// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification31Choice.IBAN))]
    [KnownType(typeof(AccountIdentification31Choice.BBAN))]
    [KnownType(typeof(AccountIdentification31Choice.UPIC))]
    [KnownType(typeof(AccountIdentification31Choice.DomesticAccount))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.IBAN),nameof(AccountIdentification31Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.BBAN),nameof(AccountIdentification31Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.UPIC),nameof(AccountIdentification31Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.DomesticAccount),nameof(AccountIdentification31Choice.DomesticAccount))]
    [IsoId("_sg7o4PSaEeSfzLT5J5kvFg")]
    [DisplayName("Account Identification 31 Choice")]
    public abstract partial record AccountIdentification31Choice_
    {
    }
}
