// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification5Choice.IBAN))]
    [KnownType(typeof(AccountIdentification5Choice.BBAN))]
    [KnownType(typeof(AccountIdentification5Choice.DomesticAccount))]
    [KnownType(typeof(AccountIdentification5Choice.DepositoryAccount))]
    [JsonDerivedType(
        typeof(AccountIdentification5Choice.IBAN),
        nameof(AccountIdentification5Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification5Choice.BBAN),
        nameof(AccountIdentification5Choice.BBAN)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification5Choice.DomesticAccount),
        nameof(AccountIdentification5Choice.DomesticAccount)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification5Choice.DepositoryAccount),
        nameof(AccountIdentification5Choice.DepositoryAccount)
    )]
    [IsoId("_Pdd4stp-Ed-ak6NoX_4Aeg_-1989600356")]
    [DisplayName("Account Identification 5 Choice")]
    public abstract record AccountIdentification5Choice_ { }
}
