// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountOwner3Choice
{
    /// <summary>
    /// Identification of the individual person that legally owns the account.
    /// </summary>
    [IsoId("_6hUREZTIEemqYPWMBuVawg")]
    [DisplayName("Individual Owner Identification")]
    public partial record IndividualOwnerIdentification : AccountOwner3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
