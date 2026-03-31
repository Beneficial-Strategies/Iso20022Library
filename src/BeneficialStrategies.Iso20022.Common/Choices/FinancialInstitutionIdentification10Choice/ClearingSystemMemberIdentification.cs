// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification10Choice
{
    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [IsoId("_Rou1FWAZEeiH9-hkDDXUHA")]
    [DisplayName("Clearing System Member Identification")]
    public record ClearingSystemMemberIdentification
        : FinancialInstitutionIdentification10Choice_ { }
}
