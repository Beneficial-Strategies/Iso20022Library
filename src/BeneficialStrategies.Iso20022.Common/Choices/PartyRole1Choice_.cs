// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the role of the party.
    /// </summary>
    [KnownType(typeof(PartyRole1Choice.Code))]
    [KnownType(typeof(PartyRole1Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyRole1Choice.Code),nameof(PartyRole1Choice.Code))]
    [JsonDerivedType(typeof(PartyRole1Choice.Proprietary),nameof(PartyRole1Choice.Proprietary))]
    [IsoId("_Q937gdp-Ed-ak6NoX_4Aeg_894093769")]
    [DisplayName("Party Role 1 Choice")]
    public abstract partial record PartyRole1Choice_
    {
    }
}
