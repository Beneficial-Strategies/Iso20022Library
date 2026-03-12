// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_SnYP89p-Ed-ak6NoX_4Aeg_-2022088805")]
[DisplayName("Regulatory Reporting")]
public partial record RegulatoryReporting2
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_SnYP9Np-Ed-ak6NoX_4Aeg_-1566793972")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; init; } 
    
    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_SnYP9dp-Ed-ak6NoX_4Aeg_-688527268")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    public RegulatoryAuthority? Authority { get; init; } 
    
    /// <summary>
    /// Details related to the regulatory reporting information.
    /// </summary>
    [IsoId("_SnYP9tp-Ed-ak6NoX_4Aeg_2118187672")]
    [DisplayName("Regulatory Details")]
    [IsoXmlTag("RgltryDtls")]
    public StructuredRegulatoryReporting2? RegulatoryDetails { get; init; } 
    
    
    #nullable disable
    
}
