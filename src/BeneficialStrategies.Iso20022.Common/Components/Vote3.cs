// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Decision of the voting party for one resolution.
/// </summary>
[IsoId("_TK_TVtp-Ed-ak6NoX_4Aeg_696615532")]
[DisplayName("Vote")]
public partial record Vote3
{
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_TK_TV9p-Ed-ak6NoX_4Aeg_696615862")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Specifies the different instructions which can be used to vote.
    /// </summary>
    [IsoId("_TK_TWNp-Ed-ak6NoX_4Aeg_1196241389")]
    [DisplayName("Vote Option")]
    [IsoXmlTag("VoteOptn")]
    public required VoteInstruction2Code VoteOption { get; init; } 
    
    
    #nullable disable
    
}
