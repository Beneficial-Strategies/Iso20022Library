// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_k0uOwECFEeeXpbqDpLawug")]
[DisplayName("Party Identification")]
public partial record PartyIdentification211
{
    #nullable enable
    
    /// <summary>
    /// Financial institution-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_zQJWgkCFEeeXpbqDpLawug")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution4? FinancialInstitution { get; init; } 
    
    /// <summary>
    /// Customer-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_zQJWg0CFEeeXpbqDpLawug")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer3? Customer { get; init; } 
    
    
    #nullable disable
    
}
