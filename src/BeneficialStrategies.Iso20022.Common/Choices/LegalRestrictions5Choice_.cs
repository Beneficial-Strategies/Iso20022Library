// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for legal restrictions.
    /// </summary>
    [KnownType(typeof(LegalRestrictions5Choice.Code))]
    [KnownType(typeof(LegalRestrictions5Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalRestrictions5Choice.Code),nameof(LegalRestrictions5Choice.Code))]
    [JsonDerivedType(typeof(LegalRestrictions5Choice.Proprietary),nameof(LegalRestrictions5Choice.Proprietary))]
    [IsoId("_cg8o6-LxEeWOD7aAy2fAcA")]
    [DisplayName("Legal Restrictions 5 Choice")]
    public abstract partial record LegalRestrictions5Choice_
    {
    }
}
