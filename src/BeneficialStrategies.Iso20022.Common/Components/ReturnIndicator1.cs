// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the return indicators and the investigation result.
/// </summary>
[IsoId("_o8EakzzuEeGl7N0Cd54dlw")]
[DisplayName("Return Indicator")]
public partial record ReturnIndicator1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the dates between which period the response results relate to.
    /// </summary>
    [IsoId("_c3ykVUMYEeGOTYFglkhSbA")]
    [DisplayName("Response Period")]
    [IsoXmlTag("RspnPrd")]
    public DateOrDateTimePeriodChoice_? ResponsePeriod { get; init; } 
    
    /// <summary>
    /// Identifies the authority request type as a code.
    /// </summary>
    [IsoId("_rb9kgTzuEeGl7N0Cd54dlw")]
    [DisplayName("Authority Request Type")]
    [IsoXmlTag("AuthrtyReqTp")]
    public required AuthorityRequestType1 AuthorityRequestType { get; init; } 
    
    /// <summary>
    /// Provides the investigation result.
    /// </summary>
    [IsoId("_uWrCITzuEeGl7N0Cd54dlw")]
    [DisplayName("Investigation Result")]
    [IsoXmlTag("InvstgtnRslt")]
    public required InvestigationResult1Choice_ InvestigationResult { get; init; } 
    
    /// <summary>
    /// Additional information, in free text form, to complement the investigation result.
    /// </summary>
    [IsoId("_10Z_ATzuEeGl7N0Cd54dlw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
