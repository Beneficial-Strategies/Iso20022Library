// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification7Choice
{
    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [IsoId("_Tet_ZSGOEeW7gKYhAMEFCw")]
    [DisplayName("Clearing System Member Identification")]
    public partial record ClearingSystemMemberIdentification : FinancialInstitutionIdentification7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
