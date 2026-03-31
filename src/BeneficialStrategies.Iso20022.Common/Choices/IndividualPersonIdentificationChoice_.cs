// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentificationChoice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentificationChoice.PersonName))]
    [JsonDerivedType(
        typeof(IndividualPersonIdentificationChoice.IdentificationNumber),
        nameof(IndividualPersonIdentificationChoice.IdentificationNumber)
    )]
    [JsonDerivedType(
        typeof(IndividualPersonIdentificationChoice.PersonName),
        nameof(IndividualPersonIdentificationChoice.PersonName)
    )]
    [IsoId("_REuxfNp-Ed-ak6NoX_4Aeg_-925696504")]
    [DisplayName("Individual Person Identification Choice")]
    public abstract record IndividualPersonIdentificationChoice_ { }
}
