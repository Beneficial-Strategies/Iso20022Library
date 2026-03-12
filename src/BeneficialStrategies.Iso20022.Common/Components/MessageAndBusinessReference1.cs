// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_VFeqFtp-Ed-ak6NoX_4Aeg_1197711929")]
[DisplayName("Message And Business Reference")]
public partial record MessageAndBusinessReference1
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_VFeqF9p-Ed-ak6NoX_4Aeg_-1666036339")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference2 PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_VFeqGNp-Ed-ak6NoX_4Aeg_-1664186882")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public required AdditionalReference2 OtherReference { get; init; } 
    
    /// <summary>
    /// Investment account information of the transfer message for which the status is requested.
    /// </summary>
    [IsoId("_VFeqGdp-Ed-ak6NoX_4Aeg_-1659762580")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount10? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Business reference of the transfer instruction message.
    /// </summary>
    [IsoId("_VFeqGtp-Ed-ak6NoX_4Aeg_1669629363")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransferReference { get; init; } 
    
    
    #nullable disable
    
}
