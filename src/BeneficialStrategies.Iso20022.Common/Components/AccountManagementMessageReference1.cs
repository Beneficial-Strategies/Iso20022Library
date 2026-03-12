// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the account management instruction message for which the status is requested.
/// </summary>
[IsoId("_RPTpwNp-Ed-ak6NoX_4Aeg_1905550020")]
[DisplayName("Account Management Message Reference")]
public partial record AccountManagementMessageReference1
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_RPTpwdp-Ed-ak6NoX_4Aeg_1905550359")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public AdditionalReference3? OtherReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_RPTpwtp-Ed-ak6NoX_4Aeg_1905550317")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    [IsoId("_RPTpw9p-Ed-ak6NoX_4Aeg_1905550298")]
    [DisplayName("Status Request Type")]
    [IsoXmlTag("StsReqTp")]
    public required AccountManagementType1Code StatusRequestType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_RPTpxNp-Ed-ak6NoX_4Aeg_1905550256")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_RPTpxdp-Ed-ak6NoX_4Aeg_1905550394")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount14? InvestmentAccount { get; init; } 
    
    
    #nullable disable
    
}
