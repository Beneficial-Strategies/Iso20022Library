// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification1Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification1Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification1Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification1Choice.BICOrBEI),nameof(PartyIdentification1Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification1Choice.ProprietaryIdentification),nameof(PartyIdentification1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification1Choice.NameAndAddress),nameof(PartyIdentification1Choice.NameAndAddress))]
    [IsoId("_QQR1v9p-Ed-ak6NoX_4Aeg_-1748201287")]
    [DisplayName("Party Identification 1 Choice")]
    public abstract partial record PartyIdentification1Choice_
    {
    }
}
