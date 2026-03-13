// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_RIosoYqPEeSRT5rEzcAHEw")]
[DisplayName("ATM Customer")]
public partial record ATMCustomer3
{
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the withdrawal.
    /// </summary>
    [IsoId("_RUtZwYqPEeSRT5rEzcAHEw")]
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile1? Profile { get; init; } 
    
    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_RUtZw4qPEeSRT5rEzcAHEw")]
    [DisplayName("Selected Language")]
    [IsoXmlTag("SelctdLang")]
    public LanguageCode? SelectedLanguage { get; init; } 
    
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_RUtZxYqPEeSRT5rEzcAHEw")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public ValueList<TransactionVerificationResult5> AuthenticationResult { get; init; } = [];
    // ID for the above is _RUtZxYqPEeSRT5rEzcAHEw
    
    
    #nullable disable
    
}
