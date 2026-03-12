// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains customer reference values provided for this transaction and used for various reference processing at the
/// customer site. These values represent information most prevalently provided by travel agencies for transactions booked against a lodged account or central travel account.
/// </summary>
[IsoId("_0Fh7xPPaEeihCvvpsmGI2w")]
[DisplayName("Customer Reference")]
public partial record CustomerReference1
{
    #nullable enable
    
    /// <summary>
    /// Defines the content of the value provided in the Customer Reference detail.
    /// </summary>
    [IsoId("_0Fh7xvPaEeihCvvpsmGI2w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Subfield is a free-form text field containing customer reference value details about the transaction.
    /// </summary>
    [IsoId("_0Fh7xfPaEeihCvvpsmGI2w")]
    [DisplayName("Detail")]
    [IsoXmlTag("Dtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Detail { get; init; } 
    
    
    #nullable disable
    
}
