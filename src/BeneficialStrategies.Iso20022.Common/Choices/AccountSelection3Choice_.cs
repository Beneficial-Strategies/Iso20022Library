// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of criteria for the identification of an account.
    /// </summary>
    [KnownType(typeof(AccountSelection3Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection3Choice.OtherAccountSelectionData))]
    [JsonDerivedType(typeof(AccountSelection3Choice.AccountIdentification),nameof(AccountSelection3Choice.AccountIdentification))]
    [JsonDerivedType(typeof(AccountSelection3Choice.OtherAccountSelectionData),nameof(AccountSelection3Choice.OtherAccountSelectionData))]
    [IsoId("_n9ODwZTIEemqYPWMBuVawg")]
    [DisplayName("Account Selection 3 Choice")]
    public abstract partial record AccountSelection3Choice_
    {
    }
}
