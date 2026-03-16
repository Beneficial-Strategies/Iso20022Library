// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Customer7.
/// </summary>
[IsoId("_wODsIajzEe--FqfI7l8ySw")]
[DisplayName("ATM Customer7")]
public partial record ATMCustomer7
{
    #nullable enable

    /// <summary>
    /// Authentication Result.
    /// </summary>
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public ValueList<TransactionVerificationResult5> AuthenticationResult { get; init; } = [];

    /// <summary>
    /// Profile.
    /// </summary>
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile6? Profile { get; init; } 

    /// <summary>
    /// Selected Language.
    /// </summary>
    [DisplayName("Selected Language")]
    [IsoXmlTag("SelctdLang")]
    public LanguageCode? SelectedLanguage { get; init; } 

    
    #nullable disable
    
}
