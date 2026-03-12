// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt2Choice
{
    /// <summary>
    /// Specifies that the claim non receipt has been rejected and provides the reason for the rejection.
    /// </summary>
    [IsoId("_EhbFM24-EeiU9cctagi5ow")]
    [DisplayName("Rejected")]
    public partial record Rejected : ClaimNonReceipt2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
