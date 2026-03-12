// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the new account.
/// </summary>
[IsoId("_a8noUdcZEeqRFcf2R4bPBw")]
[DisplayName("New Account")]
public partial record NewAccount3
{
    #nullable enable
    
    /// <summary>
    /// Details of the new account.
    /// </summary>
    [IsoId("_a99FEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount41 Account { get; init; } 
    
    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    [IsoId("_a99FE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Party")]
    [IsoXmlTag("AcctPty")]
    public ValueList<IndividualPerson36> AccountParty { get; init; } = new ValueList<IndividualPerson36>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _a99FE9cZEeqRFcf2R4bPBw
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_a99FFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public Organisation35? Organisation { get; init; } 
    
    
    #nullable disable
    
}
