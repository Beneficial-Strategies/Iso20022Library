// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a data source scheme.
/// </summary>
[IsoId("_puErAEVnEeS9ytE0W9bgkQ")]
[DisplayName("Account Identification")]
public partial record AccountIdentification30
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of account.
    /// </summary>
    [IsoId("_aczocEa8EeSm2psHh_KSCw")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public required AccountInformationType1Code AccountType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_woHE8EVnEeS9ytE0W9bgkQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification26 Identification { get; init; } 
    
    
    #nullable disable
    
}
