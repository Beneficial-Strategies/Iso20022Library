// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the detailed parameters a service to be billed.
/// </summary>
[IsoId("_6PgXwZqlEeGSON8vddiWzQ_-423301635")]
[DisplayName("Billing Service Parameters")]
public partial record BillingServiceParameters1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the details to fully identify the bank service.
    /// </summary>
    [IsoId("_6PgXwpqlEeGSON8vddiWzQ_-245182963")]
    [DisplayName("Bank Service")]
    [IsoXmlTag("BkSvc")]
    public required BillingServiceIdentification1 BankService { get; init; } 
    
    /// <summary>
    /// Count or number of items (volume) involved in the charge.
    /// </summary>
    [IsoId("_6PgXw5qlEeGSON8vddiWzQ_-537140701")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Volume { get; init; } 
    
    
    #nullable disable
    
}
