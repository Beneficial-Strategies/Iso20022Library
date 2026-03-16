// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a predefined code value or a proprietary code value for a general meeting voting participation method.
    /// </summary>
    [KnownType(typeof(ParticipationMethod3Choice.Code))]
    [KnownType(typeof(ParticipationMethod3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ParticipationMethod3Choice.Code),
        nameof(ParticipationMethod3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ParticipationMethod3Choice.Proprietary),
        nameof(ParticipationMethod3Choice.Proprietary)
    )]
    [IsoId("_XZhU5RrlEeyhRdHRjakS2w")]
    [DisplayName("Participation Method 3 Choice")]
    public abstract record ParticipationMethod3Choice_ { }
}
