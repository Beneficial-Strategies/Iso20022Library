// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the presentation of documents.
/// </summary>
[IsoId("_96-4OHltEeG7BsjMvd1mEw_-1699635040")]
[DisplayName("Presentation")]
public partial record Presentation1
{
    #nullable enable
    
    /// <summary>
    /// Medium through which the presentation can be submitted such as paper, electronic or both.
    /// </summary>
    [IsoId("_97IpMHltEeG7BsjMvd1mEw_285308407")]
    [DisplayName("Medium")]
    [IsoXmlTag("Mdm")]
    public PresentationMedium1Choice_? Medium { get; init; } 
    
    /// <summary>
    /// Choice of representation for the place of presentation.
    /// </summary>
    [IsoId("_97IpMXltEeG7BsjMvd1mEw_-2054994062")]
    [DisplayName("Place Of Presentation Or Under Confirmation Choice")]
    [IsoXmlTag("PlcOfPresntnOrUdrConfChc")]
    public PlaceOrUnderConfirmationChoice1_? PlaceOfPresentationOrUnderConfirmationChoice { get; init; } 
    
    /// <summary>
    /// Document required to be presented.
    /// </summary>
    [IsoId("_97IpMnltEeG7BsjMvd1mEw_882759480")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public Document8? Document { get; init; } 
    
    /// <summary>
    /// Additional information related to the presentation.
    /// </summary>
    [IsoId("_97IpM3ltEeG7BsjMvd1mEw_-1393168814")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
