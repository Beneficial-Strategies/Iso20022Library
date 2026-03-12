// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the characteristics for a SEPA formatted payment initiation file.
/// </summary>
[IsoId("_XKhX0KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel SEPA File")]
public partial record IsabelSEPAFile1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the SEPA formatted file is compliant to the SEPA rulebook.
    /// </summary>
    [IsoId("_VfbZsMmREeWAGphE2LvqeA")]
    [DisplayName("SEPA Indicator")]
    [IsoXmlTag("SEPAInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator SEPAIndicator { get; init; } 
    
    /// <summary>
    /// High level category purpose of the payment initiation messages in the file, based on the SEPA rulebook.
    /// </summary>
    [IsoId("_aSMlIMmREeWAGphE2LvqeA")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text CategoryPurpose { get; init; } 
    
    /// <summary>
    /// Local market practices applicable to the SEPA file.
    /// </summary>
    [IsoId("_fdp9YMmREeWAGphE2LvqeA")]
    [DisplayName("Market Practices")]
    [IsoXmlTag("MktPrctcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<System.String> MarketPractices { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
