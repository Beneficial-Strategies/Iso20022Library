// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report entry details.
/// </summary>
[IsoId("_WH67kBj6EeapYKOltfjd7A")]
[DisplayName("CBRF Report Entry")]
public partial record CBRFReportEntry1
{
    #nullable enable
    
    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_pRNgoBj6EeapYKOltfjd7A")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageName { get; init; } 
    
    /// <summary>
    /// Total number of entries in the group.
    /// </summary>
    [IsoId("_dXICUBj8EeapYKOltfjd7A")]
    [DisplayName("Total Number Of Entries")]
    [IsoXmlTag("TtlNbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TotalNumberOfEntries { get; init; } 
    
    /// <summary>
    /// Information identifying electronic messages.
    /// </summary>
    [IsoId("_99e7YBj6EeapYKOltfjd7A")]
    [DisplayName("Message Details")]
    [IsoXmlTag("MsgDtls")]
    public ValueList<ElectronicMessageDetails1> MessageDetails { get; init; } = [];
    // ID for the above is _99e7YBj6EeapYKOltfjd7A
    
    
    #nullable disable
    
}
