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
[IsoId("_XYiKkW49EeiU9cctagi5ow")]
[DisplayName("New Account")]
public partial record NewAccount2
{
    #nullable enable
    
    /// <summary>
    /// Details of the new account.
    /// </summary>
    [IsoId("_XjHp8W49EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount39 Account { get; init; } 
    
    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    [IsoId("_XjHp8249EeiU9cctagi5ow")]
    [DisplayName("Account Party")]
    [IsoXmlTag("AcctPty")]
    public ValueList<IndividualPerson36> AccountParty { get; init; } = new ValueList<IndividualPerson36>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _XjHp8249EeiU9cctagi5ow
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_XjHp9W49EeiU9cctagi5ow")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public Organisation35? Organisation { get; init; } 
    
    
    #nullable disable
    
}
