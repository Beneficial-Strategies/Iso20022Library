// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Print Response message.
/// </summary>
[IsoId("_Ty4bQN7HEeiwsev40qZGEQ")]
[DisplayName("Device Print Response")]
public partial record DevicePrintResponse1
{
    #nullable enable
    
    /// <summary>
    /// Qualification of the document printed to the Cashier or the Customer.
    /// </summary>
    [IsoId("_ckZUMN7HEeiwsev40qZGEQ")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    public required DocumentType7Code DocumentQualifier { get; init; } 
    
    
    #nullable disable
    
}
