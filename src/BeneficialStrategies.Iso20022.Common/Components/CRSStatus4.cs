// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common Reporting Standard (CRS) status information.
/// </summary>
[IsoId("_uRVacUNeEeamLdeYEZm56w")]
[DisplayName("CRS Status")]
public partial record CRSStatus4
{
    #nullable enable
    
    /// <summary>
    /// Common Reporting Standard (CRS) status.
    /// </summary>
    [IsoId("_uqe6QUNeEeamLdeYEZm56w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CRSStatus3Choice_ Type { get; init; } 
    
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status.
    /// </summary>
    [IsoId("_uqe6Q0NeEeamLdeYEZm56w")]
    [DisplayName("Source")]
    [IsoXmlTag("Src")]
    public CRSSource1Choice_? Source { get; init; } 
    
    /// <summary>
    /// Reporting country for the CRS status when there is an exception at the country level.
    /// </summary>
    [IsoId("_xl3u8Hi0EeaRm5xIK6nGuQ")]
    [DisplayName("Exceptional Reporting Country")]
    [IsoXmlTag("XcptnlRptgCtry")]
    public CountryCode? ExceptionalReportingCountry { get; init; } 
    
    
    #nullable disable
    
}
