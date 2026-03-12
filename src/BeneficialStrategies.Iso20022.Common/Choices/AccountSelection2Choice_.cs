// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of criteria for the identification of an account.
    /// </summary>
    [KnownType(typeof(AccountSelection2Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection2Choice.OtherAccountSelectionData))]
    [JsonDerivedType(typeof(AccountSelection2Choice.AccountIdentification),nameof(AccountSelection2Choice.AccountIdentification))]
    [JsonDerivedType(typeof(AccountSelection2Choice.OtherAccountSelectionData),nameof(AccountSelection2Choice.OtherAccountSelectionData))]
    [IsoId("_Ct6vkU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Selection 2 Choice")]
    public abstract partial record AccountSelection2Choice_
    {
    }
}
