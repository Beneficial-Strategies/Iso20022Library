// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data container to exchange data elements defined by another standard.
/// </summary>
[IsoId("_dxWPMAx1Eeqdx6buGpCCQw")]
[DisplayName("Externally Defined Data")]
public partial record ExternallyDefinedData1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the set of data to exchange.
    /// </summary>
    [IsoId("_dxWPMQx1Eeqdx6buGpCCQw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public required IsoMax1025Text Identification { get; init; } 
    
    /// <summary>
    /// Data to exchange according to an external standard.
    /// </summary>
    [IsoId("_dxWPNAx1Eeqdx6buGpCCQw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Value { get; init; } 
    
    /// <summary>
    /// Protection of the values to exchange.
    /// </summary>
    [IsoId("_dxWPMwx1Eeqdx6buGpCCQw")]
    [DisplayName("Protected Value")]
    [IsoXmlTag("PrtctdVal")]
    public ContentInformationType23? ProtectedValue { get; init; } 
    
    /// <summary>
    /// Identification of the standard used to encode the values to exchange.
    /// </summary>
    [IsoId("_dxWPMgx1Eeqdx6buGpCCQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? Type { get; init; } 
    
    
    #nullable disable
    
}
