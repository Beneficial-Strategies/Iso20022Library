// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for option party.
    /// </summary>
    [KnownType(typeof(OptionParty2Choice.Code))]
    [KnownType(typeof(OptionParty2Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionParty2Choice.Code),nameof(OptionParty2Choice.Code))]
    [JsonDerivedType(typeof(OptionParty2Choice.Proprietary),nameof(OptionParty2Choice.Proprietary))]
    [IsoId("_4RufoeLaEeWFtOV72FbX9w")]
    [DisplayName("Option Party 2 Choice")]
    public abstract partial record OptionParty2Choice_
    {
    }
}
