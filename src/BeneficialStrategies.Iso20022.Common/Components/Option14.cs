// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Derivative instrument that gives the buyer the right but not the obligation to purchase a set of quantity of a financial instrument at a future date.
/// </summary>
[IsoId("_d3DnkchsEeadgvwNGwK05w")]
[DisplayName("Option")]
public partial record Option14
{
    #nullable enable
    
    /// <summary>
    /// Expiration style of the option.
    /// </summary>
    [IsoId("_d_smOchsEeadgvwNGwK05w")]
    [DisplayName("Expiration Style")]
    [IsoXmlTag("XprtnStyle")]
    [MinLength(1)]
    [MaxLength(4)]
    public SimpleValueList<OptionStyle5Code> ExpirationStyle { get; init; } = new SimpleValueList<OptionStyle5Code>(){};
    
    /// <summary>
    /// Specifies how the option can be exercised.
    /// </summary>
    [IsoId("_d_smN8hsEeadgvwNGwK05w")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public ExoticOptionStyle1Code? OptionStyle { get; init; } 
    
    /// <summary>
    /// Specifies whether the option is a call or a put.
    /// </summary>
    [IsoId("_d_smO8hsEeadgvwNGwK05w")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType1Code? OptionType { get; init; } 
    
    /// <summary>
    /// Indicates whether the option has a barrier.
    /// </summary>
    [IsoId("_d_smPchsEeadgvwNGwK05w")]
    [DisplayName("Barrier Indicator")]
    [IsoXmlTag("BrrrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BarrierIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the event in the life of the option.
    /// </summary>
    [IsoId("_d_smQchsEeadgvwNGwK05w")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public OptionEvent2? EventType { get; init; } 
    
    
    #nullable disable
    
}
