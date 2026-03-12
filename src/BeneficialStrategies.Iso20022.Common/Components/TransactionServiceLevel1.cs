// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the service level of the transaction.
/// </summary>
[IsoId("_XZ-m4_WfEemtd4wHZYvFUQ")]
[DisplayName("Transaction Service Level")]
public partial record TransactionServiceLevel1
{
    #nullable enable
    
    /// <summary>
    /// Specifies a pre-agreed service or level of service between the parties, as published in an external service level code list.
    /// </summary>
    [IsoId("_XZ-m5fWfEemtd4wHZYvFUQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalServiceLevel1Code Code { get; init; } 
    
    
    #nullable disable
    
}
