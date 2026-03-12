// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a name and an account number.
/// </summary>
[IsoId("__rmBEVOWEeijdq8ilaxyOA")]
[DisplayName("Account Identification And Name")]
public partial record AccountIdentificationAndName6
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("__7qdY1OWEeijdq8ilaxyOA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of the customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_Fa6UUlOXEeijdq8ilaxyOA")]
    [DisplayName("IBAN")]
    [IsoXmlTag("IBAN")]
    [IsoSimpleType(IsoSimpleType.IBAN2007Identifier)]
    public IsoIBAN2007Identifier? IBAN { get; init; } 
    
    /// <summary>
    /// Unique identification of the account, as assigned by the account servicer, using an identification scheme.
    /// </summary>
    [IsoId("_Fa6UU1OXEeijdq8ilaxyOA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericAccountIdentification1? Other { get; init; } 
    
    
    #nullable disable
    
}
