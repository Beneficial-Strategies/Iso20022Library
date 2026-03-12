// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition2Choice.Code))]
    [KnownType(typeof(ProcessingPosition2Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition2Choice.Code),nameof(ProcessingPosition2Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition2Choice.Proprietary),nameof(ProcessingPosition2Choice.Proprietary))]
    [IsoId("_QtevGtp-Ed-ak6NoX_4Aeg_-730269459")]
    [DisplayName("Processing Position 2 Choice")]
    public abstract partial record ProcessingPosition2Choice_
    {
    }
}
