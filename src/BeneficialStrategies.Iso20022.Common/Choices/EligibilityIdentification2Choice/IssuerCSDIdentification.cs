// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification2Choice
{
    /// <summary>
    /// Issuer CSD identification used to identify the securities to be defined as eligible.
    /// </summary>
    [IsoId("_oOzV9eLXEeWFtOV72FbX9w")]
    [DisplayName("Issuer CSD Identification")]
    public partial record IssuerCSDIdentification : EligibilityIdentification2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
