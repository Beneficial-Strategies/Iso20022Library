// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or a business error.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError2Choice.BusinessError))]
    [KnownType(typeof(PartyOrBusinessError2Choice.SystemParty))]
    [JsonDerivedType(typeof(PartyOrBusinessError2Choice.BusinessError),nameof(PartyOrBusinessError2Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError2Choice.SystemParty),nameof(PartyOrBusinessError2Choice.SystemParty))]
    [IsoId("_ewUgRfAzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Or Business Error 2 Choice")]
    public abstract partial record PartyOrBusinessError2Choice_
    {
    }
}
