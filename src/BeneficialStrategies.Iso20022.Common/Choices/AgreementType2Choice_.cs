// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Classification of a master agreement.
    /// </summary>
    [KnownType(typeof(AgreementType2Choice.Type))]
    [KnownType(typeof(AgreementType2Choice.Proprietary))]
    [JsonDerivedType(typeof(AgreementType2Choice.Type), nameof(AgreementType2Choice.Type))]
    [JsonDerivedType(
        typeof(AgreementType2Choice.Proprietary),
        nameof(AgreementType2Choice.Proprietary)
    )]
    [IsoId("_Nw6gQS4yEeuxhbw_aW6haw")]
    [DisplayName("Agreement Type 2 Choice")]
    public abstract record AgreementType2Choice_ { }
}
