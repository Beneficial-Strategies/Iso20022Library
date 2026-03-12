// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a version together with the submitter of the document.|Also specifies the type of document and an index for easy referencing.
/// </summary>
[IsoId("_RaMEFtp-Ed-ak6NoX_4Aeg_-793210991")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification10
{
    #nullable enable
    
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RaMEF9p-Ed-ak6NoX_4Aeg_-792290935")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RaMEGNp-Ed-ak6NoX_4Aeg_-792290904")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Version { get; init; } 
    
    /// <summary>
    /// Identifies the type of data set.
    /// </summary>
    [IsoId("_RaMEGdp-Ed-ak6NoX_4Aeg_-792290843")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetType2Code Type { get; init; } 
    
    /// <summary>
    /// Uniquely identifies the financial institution which has submitted the set of data by using a BIC.
    /// </summary>
    [IsoId("_RaVOANp-Ed-ak6NoX_4Aeg_-792290750")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public required BICIdentification1 Submitter { get; init; } 
    
    /// <summary>
    /// Index assigned to the document, to allow easy referencing.
    /// </summary>
    [IsoId("_RaVOAdp-Ed-ak6NoX_4Aeg_-792290812")]
    [DisplayName("Document Index")]
    [IsoXmlTag("DocIndx")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText DocumentIndex { get; init; } 
    
    
    #nullable disable
    
}
