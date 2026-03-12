// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
[IsoId("_WHfgsdp-Ed-ak6NoX_4Aeg_-984642735")]
[DisplayName("Cash Account")]
public partial record CashAccount8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_WHfgstp-Ed-ak6NoX_4Aeg_-984642657")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification2 Identification { get; init; } 
    
    
    #nullable disable
    
}
