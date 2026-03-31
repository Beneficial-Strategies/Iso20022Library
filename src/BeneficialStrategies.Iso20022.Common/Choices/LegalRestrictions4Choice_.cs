// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for legal restrictions.
    /// </summary>
    [KnownType(typeof(LegalRestrictions4Choice.Code))]
    [KnownType(typeof(LegalRestrictions4Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalRestrictions4Choice.Code), nameof(LegalRestrictions4Choice.Code))]
    [JsonDerivedType(
        typeof(LegalRestrictions4Choice.Proprietary),
        nameof(LegalRestrictions4Choice.Proprietary)
    )]
    [IsoId("_J_DnkeLcEeWFtOV72FbX9w")]
    [DisplayName("Legal Restrictions 4 Choice")]
    public abstract record LegalRestrictions4Choice_ { }
}
