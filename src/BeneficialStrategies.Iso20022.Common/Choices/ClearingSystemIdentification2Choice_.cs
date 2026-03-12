// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a clearing system identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification2Choice.Code))]
    [KnownType(typeof(ClearingSystemIdentification2Choice.Proprietary))]
    [JsonDerivedType(typeof(ClearingSystemIdentification2Choice.Code),nameof(ClearingSystemIdentification2Choice.Code))]
    [JsonDerivedType(typeof(ClearingSystemIdentification2Choice.Proprietary),nameof(ClearingSystemIdentification2Choice.Proprietary))]
    [IsoId("_TMoSENp-Ed-ak6NoX_4Aeg_-1410917193")]
    [DisplayName("Clearing System Identification 2 Choice")]
    public abstract partial record ClearingSystemIdentification2Choice_
    {
    }
}
