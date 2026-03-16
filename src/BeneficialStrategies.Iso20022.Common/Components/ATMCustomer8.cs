// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Customer8.
/// </summary>
[IsoId("_LQcUYaj0Ee--FqfI7l8ySw")]
[DisplayName("ATM Customer8")]
public partial record ATMCustomer8
{
    #nullable enable

    /// <summary>
    /// Authentication.
    /// </summary>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication8> Authentication { get; init; } = [];

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
