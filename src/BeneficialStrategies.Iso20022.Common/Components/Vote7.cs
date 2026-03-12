// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the number of voting rights cast to a resolution.
/// </summary>
[IsoId("_1cUF0V64EeSjaerr_EM7AQ")]
[DisplayName("Vote")]
public partial record Vote7
{
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_14JGM164EeSjaerr_EM7AQ")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Specifies the acceptance status of a resolution.
    /// </summary>
    [IsoId("_14JGNV64EeSjaerr_EM7AQ")]
    [DisplayName("Resolution Status")]
    [IsoXmlTag("RsltnSts")]
    public required ResolutionStatus2Code ResolutionStatus { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_14JGN164EeSjaerr_EM7AQ")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? For { get; init; } 
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_14JGOV64EeSjaerr_EM7AQ")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Against { get; init; } 
    
    /// <summary>
    /// Number of votes expressed as abstain.
    /// </summary>
    [IsoId("_14JGO164EeSjaerr_EM7AQ")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Abstain { get; init; } 
    
    /// <summary>
    /// Total votes withheld, for example, in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    [IsoId("_14JGPV64EeSjaerr_EM7AQ")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Withhold { get; init; } 
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VwKY816_EeSjaerr_EM7AQ")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? OneYear { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VwKY9F6_EeSjaerr_EM7AQ")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TwoYears { get; init; } 
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VwKY9V6_EeSjaerr_EM7AQ")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ThreeYears { get; init; } 
    
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_14JGP164EeSjaerr_EM7AQ")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NoAction { get; init; } 
    
    
    #nullable disable
    
}
