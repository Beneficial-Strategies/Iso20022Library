// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of an investigation.
    /// </summary>
    [KnownType(typeof(InvestigationType2Choice.Code))]
    [KnownType(typeof(InvestigationType2Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationType2Choice.Code),nameof(InvestigationType2Choice.Code))]
    [JsonDerivedType(typeof(InvestigationType2Choice.Proprietary),nameof(InvestigationType2Choice.Proprietary))]
    [IsoId("_yQ8IIXbkEe2GR4CRzIB77g")]
    [DisplayName("Investigation Type 2 Choice")]
    public abstract partial record InvestigationType2Choice_
    {
    }
}
