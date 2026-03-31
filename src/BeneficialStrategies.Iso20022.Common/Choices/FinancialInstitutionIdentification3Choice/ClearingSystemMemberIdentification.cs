// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification3Choice
{
    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [IsoId("_QE8vc9p-Ed-ak6NoX_4Aeg_2090381835")]
    [DisplayName("Clearing System Member Identification")]
    public record ClearingSystemMemberIdentification
        : FinancialInstitutionIdentification3Choice_ { }
}
