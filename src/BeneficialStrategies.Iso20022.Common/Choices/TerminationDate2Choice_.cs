// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate2Choice.Date))]
    [KnownType(typeof(TerminationDate2Choice.Code))]
    [JsonDerivedType(typeof(TerminationDate2Choice.Date),nameof(TerminationDate2Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate2Choice.Code),nameof(TerminationDate2Choice.Code))]
    [IsoId("_QurB4dp-Ed-ak6NoX_4Aeg_1799972644")]
    [DisplayName("Termination Date 2 Choice")]
    public abstract partial record TerminationDate2Choice_
    {
    }
}
