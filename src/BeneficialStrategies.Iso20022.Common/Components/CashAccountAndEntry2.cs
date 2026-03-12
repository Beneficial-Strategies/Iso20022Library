// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_HGFBcZliEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Account And Entry")]
public partial record CashAccountAndEntry2
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_HOYB05liEeeE1Ya-LgRsuQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount36 Account { get; init; } 
    
    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_HOYB1ZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public CashEntry2? Entry { get; init; } 
    
    
    #nullable disable
    
}
