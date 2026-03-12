// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of an account, as assigned by the account servicer.
/// </summary>
[IsoId("_WHfgudp-Ed-ak6NoX_4Aeg_655013533")]
[DisplayName("Account Identification")]
public partial record AccountIdentification2
{
    #nullable enable
    
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_WHfgutp-Ed-ak6NoX_4Aeg_701188999")]
    [DisplayName("IBAN")]
    [IsoXmlTag("IBAN")]
    [IsoSimpleType(IsoSimpleType.IBANIdentifier)]
    public required IsoIBANIdentifier IBAN { get; init; } 
    
    
    #nullable disable
    
}
