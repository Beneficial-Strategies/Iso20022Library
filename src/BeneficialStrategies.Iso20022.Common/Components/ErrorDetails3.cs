// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Error Details3.
/// </summary>
[IsoId("_5GxE0XHJEe60F8I8TAMKmg")]
[DisplayName("Error Details3")]
public partial record ErrorDetails3
{
    #nullable enable

    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax35Text? Code { get; init; } 

    /// <summary>
    /// Data Element In Error.
    /// </summary>
    [DisplayName("Data Element In Error")]
    [IsoXmlTag("DataElmtInErr")]
    public ValueList<IsoMax4000Text> DataElementInError { get; init; } = [];

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax500Text? Description { get; init; } 

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MessageError1Code Type { get; init; } 

    
    #nullable disable
    
}
