// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a service level restricted to the proprietary element.
    /// </summary>
    [KnownType(typeof(RestrictedProprietaryChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RestrictedProprietaryChoice.Proprietary),
        nameof(RestrictedProprietaryChoice.Proprietary)
    )]
    [IsoId("_QJa_z9p-Ed-ak6NoX_4Aeg_1495589549")]
    [DisplayName("Restricted Proprietary Choice")]
    public abstract record RestrictedProprietaryChoice_ { }
}
