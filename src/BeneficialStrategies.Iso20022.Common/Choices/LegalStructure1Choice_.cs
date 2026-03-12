// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the legal structure of a financial instrument.
    /// </summary>
    [KnownType(typeof(LegalStructure1Choice.Code))]
    [KnownType(typeof(LegalStructure1Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalStructure1Choice.Code),nameof(LegalStructure1Choice.Code))]
    [JsonDerivedType(typeof(LegalStructure1Choice.Proprietary),nameof(LegalStructure1Choice.Proprietary))]
    [IsoId("_kfzX0DQeEeifw8iDiyZLmQ")]
    [DisplayName("Legal Structure 1 Choice")]
    public abstract partial record LegalStructure1Choice_
    {
    }
}
