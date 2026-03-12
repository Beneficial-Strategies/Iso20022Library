// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with an account number and a code.
/// </summary>
[IsoId("_PoVr9tp-Ed-ak6NoX_4Aeg_1399035911")]
[DisplayName("Account Identification And Purpose")]
public partial record AccountIdentificationAndPurpose
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_PoVr99p-Ed-ak6NoX_4Aeg_1457217360")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_PoVr-Np-Ed-ak6NoX_4Aeg_1496004828")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public required SecuritiesAccountPurposeType1Code Purpose { get; init; } 
    
    
    #nullable disable
    
}
