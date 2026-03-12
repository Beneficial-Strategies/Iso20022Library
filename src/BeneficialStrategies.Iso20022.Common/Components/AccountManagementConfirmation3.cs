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
[IsoId("_RG7M8SFfEeW9XJWqfgXIIA")]
[DisplayName("Account Management Confirmation")]
public partial record AccountManagementConfirmation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the confirmation message applies to an account opening, an account modification request or to a get account details.
    /// </summary>
    [IsoId("_RkVhsSFfEeW9XJWqfgXIIA")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_RkVhsyFfEeW9XJWqfgXIIA")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [IsoId("_RkVhtSFfEeW9XJWqfgXIIA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_RkVhtyFfEeW9XJWqfgXIIA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference6? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_dczAAVxQEeW8MLuBzR10cg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ExistingAccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
