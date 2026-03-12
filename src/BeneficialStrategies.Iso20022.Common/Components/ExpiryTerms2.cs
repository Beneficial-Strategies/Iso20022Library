// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expiry conditions.
/// </summary>
[IsoId("_rhWRxoAAEeGOn4dfTT_QdQ")]
[DisplayName("Expiry Terms")]
public partial record ExpiryTerms2
{
    #nullable enable
    
    /// <summary>
    /// Date and time when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_rhW4yoAAEeGOn4dfTT_QdQ")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public DateAndDateTimeChoice_? DateTime { get; init; } 
    
    /// <summary>
    /// Details related to the automatic extension of the undertaking.
    /// </summary>
    [IsoId("_rhW43IAAEeGOn4dfTT_QdQ")]
    [DisplayName("Auto Extension")]
    [IsoXmlTag("AutoXtnsn")]
    public AutoExtension1? AutoExtension { get; init; } 
    
    /// <summary>
    /// Documentary condition that indicates when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_rhW4xIAAEeGOn4dfTT_QdQ")]
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? Condition { get; init; } 
    
    /// <summary>
    /// Indicates whether the expiry terms are without a fixed expiry date.
    /// </summary>
    [IsoId("_rhW40oAAEeGOn4dfTT_QdQ")]
    [DisplayName("Open Ended Indicator")]
    [IsoXmlTag("OpnEnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OpenEndedIndicator { get; init; } 
    
    
    #nullable disable
    
}
