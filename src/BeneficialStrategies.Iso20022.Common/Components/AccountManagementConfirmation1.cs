// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the type of request or instruction which triggered this confirmation.
/// </summary>
[IsoId("_RESFhNp-Ed-ak6NoX_4Aeg_190539014")]
[DisplayName("Account Management Confirmation")]
public partial record AccountManagementConfirmation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the confirmation message applies to an account opening, an account modification request or to a get account details.
    /// </summary>
    [IsoId("_RESFhdp-Ed-ak6NoX_4Aeg_190539050")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_REb2gNp-Ed-ak6NoX_4Aeg_190539109")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    
    #nullable disable
    
}
