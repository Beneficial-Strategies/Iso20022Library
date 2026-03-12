// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the account to or from which a securities entry is made and the usage type.
/// </summary>
[IsoId("_mzWcD-FgEeWIA4E9cYSxxQ")]
[DisplayName("Issuance Account")]
public partial record IssuanceAccount2
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_m8H9geFgEeWIA4E9cYSxxQ")]
    [DisplayName("Issuance Account")]
    [IsoXmlTag("IssncAcct")]
    public required SecuritiesAccount19 IssuanceAccount { get; init; } 
    
    /// <summary>
    /// Defines if the related issuance account is the primary account or not.
    /// </summary>
    [IsoId("_m8H9g-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Primary Account Indicator")]
    [IsoXmlTag("PmryAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PrimaryAccountIndicator { get; init; } 
    
    
    #nullable disable
    
}
