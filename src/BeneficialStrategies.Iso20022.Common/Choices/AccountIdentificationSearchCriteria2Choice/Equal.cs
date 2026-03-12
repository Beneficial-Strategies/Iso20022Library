// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationSearchCriteria2Choice
{
    /// <summary>
    /// Search for one or more accounts based on exact identification of the account(s).
    /// </summary>
    [IsoId("_g7QEuWliEeGaMcKyqKNRfQ_-950111322")]
    [DisplayName("Equal")]
    public partial record Equal : AccountIdentificationSearchCriteria2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
