// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party6Choice.OrganisationIdentification))]
    [KnownType(typeof(Party6Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party6Choice.OrganisationIdentification),nameof(Party6Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party6Choice.PrivateIdentification),nameof(Party6Choice.PrivateIdentification))]
    [IsoId("_Pa7iFNp-Ed-ak6NoX_4Aeg_567090753")]
    [DisplayName("Party 6 Choice")]
    public abstract partial record Party6Choice_
    {
    }
}
