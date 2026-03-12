// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of other identification.
    /// </summary>
    [KnownType(typeof(OtherIdentification1Choice.Code))]
    [KnownType(typeof(OtherIdentification1Choice.Proprietary))]
    [JsonDerivedType(typeof(OtherIdentification1Choice.Code),nameof(OtherIdentification1Choice.Code))]
    [JsonDerivedType(typeof(OtherIdentification1Choice.Proprietary),nameof(OtherIdentification1Choice.Proprietary))]
    [IsoId("_smxawBc0EeK5g-3oYI0_9Q")]
    [DisplayName("Other Identification 1 Choice")]
    public abstract partial record OtherIdentification1Choice_
    {
    }
}
