// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType2Choice.Code))]
    [KnownType(typeof(IdentificationType2Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationType2Choice.Code),nameof(IdentificationType2Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType2Choice.Proprietary),nameof(IdentificationType2Choice.Proprietary))]
    [IsoId("_Q-Undtp-Ed-ak6NoX_4Aeg_-1566348160")]
    [DisplayName("Identification Type 2 Choice")]
    public abstract partial record IdentificationType2Choice_
    {
    }
}
