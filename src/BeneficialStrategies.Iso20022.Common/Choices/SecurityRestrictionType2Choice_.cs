// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the type of restriction.
    /// </summary>
    [KnownType(typeof(SecurityRestrictionType2Choice.RestrictionType))]
    [KnownType(typeof(SecurityRestrictionType2Choice.ProprietaryRestriction))]
    [JsonDerivedType(
        typeof(SecurityRestrictionType2Choice.RestrictionType),
        nameof(SecurityRestrictionType2Choice.RestrictionType)
    )]
    [JsonDerivedType(
        typeof(SecurityRestrictionType2Choice.ProprietaryRestriction),
        nameof(SecurityRestrictionType2Choice.ProprietaryRestriction)
    )]
    [IsoId("_c8LMVeLxEeWOD7aAy2fAcA")]
    [DisplayName("Security Restriction Type 2 Choice")]
    public abstract record SecurityRestrictionType2Choice_ { }
}
