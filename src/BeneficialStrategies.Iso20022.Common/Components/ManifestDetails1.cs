// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the related items or attachments (such as message types and number of messages types) within the file.
/// </summary>
[IsoId("_jLluVe5NEeCisYr99QEiWA_942484578")]
[DisplayName("Manifest Details")]
public partial record ManifestDetails1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of items contained in the document set. An initial list of values can be found in the ISO20022 message type catalogue such as admi, camt, pacs, sese, semt etc. ISO messages.
    /// </summary>
    [IsoId("_jLvfUO5NEeCisYr99QEiWA_-354097622")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DocumentType { get; init; } 
    
    /// <summary>
    /// Gives the number of instances (messages) for each declared type.
    /// </summary>
    [IsoId("_jLvfUe5NEeCisYr99QEiWA_-683335600")]
    [DisplayName("Number Of Documents")]
    [IsoXmlTag("NbOfDocs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDocuments { get; init; } 
    
    
    #nullable disable
    
}
