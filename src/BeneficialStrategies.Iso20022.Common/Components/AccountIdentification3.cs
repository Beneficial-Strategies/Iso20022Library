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
[IsoId("_PoVr8tp-Ed-ak6NoX_4Aeg_2048303446")]
[DisplayName("Account Identification")]
public partial record AccountIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_PoVr89p-Ed-ak6NoX_4Aeg_1372251027")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the information.
    /// </summary>
    [IsoId("_PoVr9Np-Ed-ak6NoX_4Aeg_2100019973")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public required IsoMax8Text Issuer { get; init; } 
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_PoVr9dp-Ed-ak6NoX_4Aeg_2100019938")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText Information { get; init; } 
    
    
    #nullable disable
    
}
