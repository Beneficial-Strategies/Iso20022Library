// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of request or instruction.
/// </summary>
[IsoId("_VSqnQQjhEeSI9qETkJHgqw")]
[DisplayName("Account Management Confirmation")]
public partial record AccountManagementConfirmation2
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the confirmation message applies to an account opening, an account modification request or to a get account details.
    /// </summary>
    [IsoId("_VtvZsQjhEeSI9qETkJHgqw")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_VtvZswjhEeSI9qETkJHgqw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer.
    /// </summary>
    [IsoId("_aKD0AgjhEeSI9qETkJHgqw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer as allocated by the counterparty.
    /// </summary>
    [IsoId("_aKD0AwjhEeSI9qETkJHgqw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; } 
    
    
    #nullable disable
    
}
