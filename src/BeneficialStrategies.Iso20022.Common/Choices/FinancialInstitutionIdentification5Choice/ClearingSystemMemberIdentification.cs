// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <summary>
    /// Unique and unambiguous identifier of a clearing system member, as assigned by the system or system administrator.
    /// </summary>
    [IsoId("_TFehONp-Ed-ak6NoX_4Aeg_1156630120")]
    [DisplayName("Clearing System Member Identification")]
    public partial record ClearingSystemMemberIdentification : FinancialInstitutionIdentification5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
