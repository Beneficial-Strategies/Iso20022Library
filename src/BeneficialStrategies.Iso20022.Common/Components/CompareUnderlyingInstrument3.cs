// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a underlying instrument.
/// </summary>
[IsoId("_eZnNkVo2Ee23K4GXSpBSeg")]
[DisplayName("Compare Underlying Instrument")]
public partial record CompareUnderlyingInstrument3
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_ebTPoVo2Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecurityIdentification41Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_ebTPo1o2Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecurityIdentification41Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
