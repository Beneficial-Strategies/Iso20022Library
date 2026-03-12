// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_Pofc89p-Ed-ak6NoX_4Aeg_-1748202398")]
[DisplayName("Account")]
public partial record Account1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Pofc9Np-Ed-ak6NoX_4Aeg_-1748202389")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification1? Identification { get; init; } 
    
    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    [IsoId("_Pofc9dp-Ed-ak6NoX_4Aeg_-1748202388")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification1Choice_ AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
