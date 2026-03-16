// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition1Choice.Code))]
    [KnownType(typeof(ProcessingPosition1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingPosition1Choice.Code),
        nameof(ProcessingPosition1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingPosition1Choice.Proprietary),
        nameof(ProcessingPosition1Choice.Proprietary)
    )]
    [IsoId("_QzcNINp-Ed-ak6NoX_4Aeg_135502517")]
    [DisplayName("Processing Position 1 Choice")]
    public abstract record ProcessingPosition1Choice_ { }
}
