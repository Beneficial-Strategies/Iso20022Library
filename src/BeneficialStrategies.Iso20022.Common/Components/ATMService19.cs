// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service allowed on the account.
/// </summary>
[IsoId("_zjuCEa4ZEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
public partial record ATMService19
{
    #nullable enable
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_zuvmUa4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType8Code ServiceType { get; init; } 
    
    /// <summary>
    /// Variant of the service.
    /// </summary>
    [IsoId("_zuvmU64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Service Variant")]
    [IsoXmlTag("SvcVarnt")]
    public ATMService18? ServiceVariant { get; init; } 
    
    /// <summary>
    /// Limits of amounts.
    /// </summary>
    [IsoId("_zuvmVa4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; } 
    
    
    #nullable disable
    
}
