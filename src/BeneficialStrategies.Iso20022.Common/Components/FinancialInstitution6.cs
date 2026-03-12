// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a financial institution required by business or regulation (for example, in money or funds transfer).
/// </summary>
[IsoId("_wnLr0cWhEeuhguwJmlgagQ")]
[DisplayName("Financial Institution")]
public partial record FinancialInstitution6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial institution.
    /// </summary>
    [IsoId("_wsPyAcWhEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification258 Identification { get; init; } 
    
    /// <summary>
    /// Account number from which the funds get debited or credited.
    /// </summary>
    [IsoId("_wsPyA8WhEeuhguwJmlgagQ")]
    [DisplayName("Account Number")]
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountNumber { get; init; } 
    
    
    #nullable disable
    
}
