// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of account.
    /// </summary>
    [KnownType(typeof(AccountType2Choice.Code))]
    [KnownType(typeof(AccountType2Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountType2Choice.Code),nameof(AccountType2Choice.Code))]
    [JsonDerivedType(typeof(AccountType2Choice.Proprietary),nameof(AccountType2Choice.Proprietary))]
    [IsoId("_cyOI8SC7EeWPMvNwVtiMsA")]
    [DisplayName("Account Type 2 Choice")]
    public abstract partial record AccountType2Choice_
    {
    }
}
