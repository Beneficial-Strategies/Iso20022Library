// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
[IsoId("_cm369kjwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Type Information")]
public partial record MandateTypeInformation2
{
    #nullable enable
    
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    [IsoId("_cvK7QUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_cvK7Q0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    
    /// <summary>
    /// Specifies the high level purpose of the mandate based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_T6WPoUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    
    /// <summary>
    /// Type of direct debit instruction.
    /// </summary>
    [IsoId("_3MJbIGVREeacpJ-gG9kyUQ")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MandateClassification1Choice_? Classification { get; init; } 
    
    
    #nullable disable
    
}
