// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or an operational error.
    /// </summary>
    [KnownType(typeof(PartyOrOperationalError2Choice.PartyReport))]
    [KnownType(typeof(PartyOrOperationalError2Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyOrOperationalError2Choice.PartyReport),nameof(PartyOrOperationalError2Choice.PartyReport))]
    [JsonDerivedType(typeof(PartyOrOperationalError2Choice.OperationalError),nameof(PartyOrOperationalError2Choice.OperationalError))]
    [IsoId("_edSPgfAzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Or Operational Error 2 Choice")]
    public abstract partial record PartyOrOperationalError2Choice_
    {
    }
}
