// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_8c6H1fNXEeqRfth943bvEA")]
[DisplayName("Vote")]
public partial record Vote14
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_8v8_o_NXEeqRfth943bvEA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    [IsoId("_hYJhAfNXEeqRfth943bvEA")]
    [DisplayName("Listing Group Resolution Label")]
    [IsoXmlTag("ListgGrpRsltnLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_8v8_pfNXEeqRfth943bvEA")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public QuantityOrCode1Choice_? For { get; init; } 
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_8v8_p_NXEeqRfth943bvEA")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public QuantityOrCode1Choice_? Against { get; init; } 
    
    /// <summary>
    /// Number of abstention votes for one resolution.
    /// </summary>
    [IsoId("_8v8_qfNXEeqRfth943bvEA")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public QuantityOrCode1Choice_? Abstain { get; init; } 
    
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_8v8_q_NXEeqRfth943bvEA")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public QuantityOrCode1Choice_? Withhold { get; init; } 
    
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_8v8_rfNXEeqRfth943bvEA")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public QuantityOrCode1Choice_? WithManagement { get; init; } 
    
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_8v8_r_NXEeqRfth943bvEA")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public QuantityOrCode1Choice_? AgainstManagement { get; init; } 
    
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_8v8_sfNXEeqRfth943bvEA")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public QuantityOrCode1Choice_? Discretionary { get; init; } 
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_s_NXEeqRfth943bvEA")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public QuantityOrCode1Choice_? OneYear { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_tfNXEeqRfth943bvEA")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public QuantityOrCode1Choice_? TwoYears { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8v8_t_NXEeqRfth943bvEA")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public QuantityOrCode1Choice_? ThreeYears { get; init; } 
    
    /// <summary>
    /// Do not vote.
    /// </summary>
    [IsoId("_8v8_ufNXEeqRfth943bvEA")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public QuantityOrCode1Choice_? NoAction { get; init; } 
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_8v8_u_NXEeqRfth943bvEA")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public QuantityOrCode1Choice_? Blank { get; init; } 
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_8v8_vfNXEeqRfth943bvEA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<ProprietaryVote1> Proprietary { get; init; } = new ValueList<ProprietaryVote1>(){};
    
    
    #nullable disable
    
}
