// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the terminal performing the transaction.
/// </summary>
[IsoId("_PE3qQRyqEey6gI8SKlv7rg")]
[DisplayName("Terminal Identification")]
public partial record TerminalIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal.
    /// ISO 8583 bit 41
    /// </summary>
    [IsoId("_PKX1URyqEey6gI8SKlv7rg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text Identification { get; init; } 
    
    /// <summary>
    /// Assignor of the terminal identification.
    /// </summary>
    [IsoId("_PKX1UxyqEey6gI8SKlv7rg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the terminal.
    /// </summary>
    [IsoId("_PKX1VRyqEey6gI8SKlv7rg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the terminal.
    /// </summary>
    [IsoId("_PKX1VxyqEey6gI8SKlv7rg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
