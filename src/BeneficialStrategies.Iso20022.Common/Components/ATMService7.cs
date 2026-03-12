// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Services allowed for the customer&apos;s profile.
/// </summary>
[IsoId("_IAYH0Yq0EeSIDtZ76p6McQ")]
[DisplayName("ATM Service")]
public partial record ATMService7
{
    #nullable enable
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_INCq1Yq0EeSIDtZ76p6McQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType4Code ServiceType { get; init; } 
    
    /// <summary>
    /// Limits of amounts.
    /// </summary>
    [IsoId("_nMR4QIq2EeSIDtZ76p6McQ")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts3? Limits { get; init; } 
    
    /// <summary>
    /// Preferred withdrawal transaction chosen by the customer.
    /// </summary>
    [IsoId("_vyGCEIq3EeSIDtZ76p6McQ")]
    [DisplayName("Preferred Withdrawal")]
    [IsoXmlTag("PrefrdWdrwl")]
    public ATMTransaction8? PreferredWithdrawal { get; init; } 
    
    
    #nullable disable
    
}
