// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to the network management.
/// </summary>
[IsoId("_aNF6EHvFEeSKFIcWw3l4Yw")]
[DisplayName("Acquirer Network Management Response")]
public partial record AcquirerNetworkManagementResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_mn0VYHvFEeSKFIcWw3l4Yw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment6 Environment { get; init; } 
    
    /// <summary>
    /// Network management transaction.
    /// </summary>
    [IsoId("_uCunwHvFEeSKFIcWw3l4Yw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction12 Transaction { get; init; } 
    
    
    #nullable disable
    
}
