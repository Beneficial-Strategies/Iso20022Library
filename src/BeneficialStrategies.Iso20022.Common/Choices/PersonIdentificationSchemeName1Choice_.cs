// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(PersonIdentificationSchemeName1Choice.Code))]
    [KnownType(typeof(PersonIdentificationSchemeName1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PersonIdentificationSchemeName1Choice.Code),
        nameof(PersonIdentificationSchemeName1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationSchemeName1Choice.Proprietary),
        nameof(PersonIdentificationSchemeName1Choice.Proprietary)
    )]
    [IsoId("_P_4pQ9p-Ed-ak6NoX_4Aeg_2056543129")]
    [DisplayName("Person Identification Scheme Name 1 Choice")]
    public abstract record PersonIdentificationSchemeName1Choice_ { }
}
