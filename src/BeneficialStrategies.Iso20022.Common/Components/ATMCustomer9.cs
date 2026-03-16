// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Customer9.
/// </summary>
[IsoId("_Dic7UasgEe-ug9Puyq4nEw")]
[DisplayName("ATM Customer9")]
public partial record ATMCustomer9
{
    #nullable enable

    /// <summary>
    /// Authentication Result.
    /// </summary>
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public ValueList<TransactionVerificationResult5> AuthenticationResult { get; init; } = [];

    /// <summary>
    /// Preferred Language.
    /// </summary>
    [DisplayName("Preferred Language")]
    [IsoXmlTag("PrefrdLang")]
    public LanguageCode? PreferredLanguage { get; init; } 

    /// <summary>
    /// Profile.
    /// </summary>
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile2? Profile { get; init; } 

    
    #nullable disable
    
}
