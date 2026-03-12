// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other investment need.
/// </summary>
[IsoId("_II3KcDceEeidBoT_PugKiA")]
[DisplayName("Other Investment Need")]
public partial record OtherInvestmentNeed1
{
    #nullable enable
    
    /// <summary>
    /// Type of return profile.
    /// </summary>
    [IsoId("_QFqo8DceEeidBoT_PugKiA")]
    [DisplayName("Client Objectives And Needs Type")]
    [IsoXmlTag("ClntObjctvsAndNeedsTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientObjectivesAndNeedsType { get; init; } 
    
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of return profile.
    /// </summary>
    [IsoId("_ROkKsDceEeidBoT_PugKiA")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public TargetMarket1Choice_? Target { get; init; } 
    
    /// <summary>
    /// Additional information about the target market and the Investor’s investment requirements.
    /// </summary>
    [IsoId("_mfHx0HoHEeidV-k9VF2jdA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
