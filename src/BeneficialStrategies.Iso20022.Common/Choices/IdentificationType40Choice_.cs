// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType40Choice.Code))]
    [KnownType(typeof(IdentificationType40Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType40Choice.Code),
        nameof(IdentificationType40Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType40Choice.Proprietary),
        nameof(IdentificationType40Choice.Proprietary)
    )]
    [IsoId("_AeoSMtokEeC60axPepSq7g_2115994376")]
    [DisplayName("Identification Type 40 Choice")]
    public abstract record IdentificationType40Choice_ { }
}
