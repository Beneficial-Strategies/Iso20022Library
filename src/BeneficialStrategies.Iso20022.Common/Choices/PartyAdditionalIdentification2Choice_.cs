// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [KnownType(typeof(PartyAdditionalIdentification2Choice.BirthDate))]
    [KnownType(typeof(PartyAdditionalIdentification2Choice.RegistrationIdentification))]
    [JsonDerivedType(typeof(PartyAdditionalIdentification2Choice.BirthDate),nameof(PartyAdditionalIdentification2Choice.BirthDate))]
    [JsonDerivedType(typeof(PartyAdditionalIdentification2Choice.RegistrationIdentification),nameof(PartyAdditionalIdentification2Choice.RegistrationIdentification))]
    [IsoId("_Qo3U0dp-Ed-ak6NoX_4Aeg_1365227120")]
    [DisplayName("Party Additional Identification 2 Choice")]
    public abstract partial record PartyAdditionalIdentification2Choice_
    {
    }
}
