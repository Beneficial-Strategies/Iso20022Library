// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// File Data1.
/// </summary>
[IsoId("_6csvISedEe6TQOljeYYeiQ")]
[DisplayName("File Data1")]
public partial record FileData1
{
    #nullable enable

    /// <summary>
    /// File Location Electronic Address.
    /// </summary>
    [DisplayName("File Location Electronic Address")]
    [IsoXmlTag("FileLctnElctrncAdr")]
    public IsoMax2048Text? FileLocationElectronicAddress { get; init; } 

    /// <summary>
    /// File Name.
    /// </summary>
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    public IsoMax140Text? FileName { get; init; } 

    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public DocumentFormat1Choice_? Format { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    /// <summary>
    /// Issue Date.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DateAndDateTime2Choice_? IssueDate { get; init; } 

    /// <summary>
    /// Network Reference.
    /// </summary>
    [DisplayName("Network Reference")]
    [IsoXmlTag("NtwkRef")]
    public IsoMax140Text? NetworkReference { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentType1Choice_? Type { get; init; } 

    
    #nullable disable
    
}
