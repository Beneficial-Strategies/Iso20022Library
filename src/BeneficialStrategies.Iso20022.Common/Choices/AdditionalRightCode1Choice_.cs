// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of additional right code.
    /// </summary>
    [KnownType(typeof(AdditionalRightCode1Choice.Code))]
    [KnownType(typeof(AdditionalRightCode1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalRightCode1Choice.Code),
        nameof(AdditionalRightCode1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalRightCode1Choice.Proprietary),
        nameof(AdditionalRightCode1Choice.Proprietary)
    )]
    [IsoId("_RDYto9p-Ed-ak6NoX_4Aeg_-1284935135")]
    [DisplayName("Additional Right Code 1 Choice")]
    public abstract record AdditionalRightCode1Choice_ { }
}
