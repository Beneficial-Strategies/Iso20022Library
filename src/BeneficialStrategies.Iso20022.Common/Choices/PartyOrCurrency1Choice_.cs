// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a depostory or settlement currency.
    /// </summary>
    [KnownType(typeof(PartyOrCurrency1Choice.Depository))]
    [KnownType(typeof(PartyOrCurrency1Choice.SettlementCurrency))]
    [JsonDerivedType(typeof(PartyOrCurrency1Choice.Depository),nameof(PartyOrCurrency1Choice.Depository))]
    [JsonDerivedType(typeof(PartyOrCurrency1Choice.SettlementCurrency),nameof(PartyOrCurrency1Choice.SettlementCurrency))]
    [IsoId("_eY4Ls1K0EeOsJr32EK1NAQ")]
    [DisplayName("Party Or Currency 1 Choice")]
    public abstract partial record PartyOrCurrency1Choice_
    {
    }
}
