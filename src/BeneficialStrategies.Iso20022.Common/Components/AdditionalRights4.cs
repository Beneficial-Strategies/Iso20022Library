// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Rights4.
/// </summary>
[IsoId("_dTVYEZK5Ee-l-O3vIHRmRw")]
[DisplayName("Additional Rights4")]
public partial record AdditionalRights4
{
    #nullable enable

    /// <summary>
    /// Additional Right.
    /// </summary>
    [DisplayName("Additional Right")]
    [IsoXmlTag("AddtlRght")]
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 

    /// <summary>
    /// Additional Right Deadline.
    /// </summary>
    [DisplayName("Additional Right Deadline")]
    [IsoXmlTag("AddtlRghtDdln")]
    public DateFormat58Choice_? AdditionalRightDeadline { get; init; } 

    /// <summary>
    /// Additional Right Information URL Address.
    /// </summary>
    [DisplayName("Additional Right Information URL Address")]
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    public IsoMax2048Text? AdditionalRightInformationURLAddress { get; init; } 

    /// <summary>
    /// Additional Right Market Deadline.
    /// </summary>
    [DisplayName("Additional Right Market Deadline")]
    [IsoXmlTag("AddtlRghtMktDdln")]
    public DateFormat58Choice_? AdditionalRightMarketDeadline { get; init; } 

    /// <summary>
    /// Additional Right Threshold.
    /// </summary>
    [DisplayName("Additional Right Threshold")]
    [IsoXmlTag("AddtlRghtThrshld")]
    public AdditionalRightThreshold2Choice_? AdditionalRightThreshold { get; init; } 

    
    #nullable disable
    
}
