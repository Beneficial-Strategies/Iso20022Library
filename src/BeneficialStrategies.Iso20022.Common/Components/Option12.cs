// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for a call/put option.
/// </summary>
[IsoId("_TvjDULtJEeSmENFdxjMqzQ")]
[DisplayName("Option")]
public partial record Option12
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the instrument has a call option or a put option. If the instrument contains both options, i.e. a call and a put, both the call option and the put option have to be reported.
    /// </summary>
    [IsoId("_an7QYLtJEeSmENFdxjMqzQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OptionType1Code Type { get; init; } 
    
    /// <summary>
    /// Provides the exercise date or notice period for a call/put option.
    /// </summary>
    [IsoId("_VQ8yMTU7EeWITbq5W8H-2w")]
    [DisplayName("Date Or Period")]
    [IsoXmlTag("DtOrPrd")]
    public required OptionDateOrPeriod1Choice_ DateOrPeriod { get; init; } 
    
    
    #nullable disable
    
}
