// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a person and the identification of a non-financial institution.
    /// </summary>
    [KnownType(typeof(Party1Choice.OrganisationIdentification))]
    [KnownType(typeof(Party1Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party1Choice.OrganisationIdentification),nameof(Party1Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party1Choice.PrivateIdentification),nameof(Party1Choice.PrivateIdentification))]
    [IsoId("_Rca4t9p-Ed-ak6NoX_4Aeg_49258998")]
    [DisplayName("Party 1 Choice")]
    public abstract partial record Party1Choice_
    {
    }
}
