// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters required to request a Fund Processing Passport (FPP).
/// </summary>
[IsoId("_Q52XIdp-Ed-ak6NoX_4Aeg_765499799")]
[DisplayName("Fund Parameters")]
public partial record FundParameters4
{
    #nullable enable
    
    /// <summary>
    /// Financial instrument for which the fund processing passport report report is requested.
    /// </summary>
    [IsoId("_Q6c0ENp-Ed-ak6NoX_4Aeg_651660733")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument17? FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Fund management company for which the report is requested.
    /// </summary>
    [IsoId("_Q6c0Edp-Ed-ak6NoX_4Aeg_-345411620")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public PartyIdentification2Choice_? FundManagementCompany { get; init; } 
    
    /// <summary>
    /// Specifies the date on or after which the information required will have been last updated. Only the most recent versions of the data is required.
    /// </summary>
    [IsoId("_Q6c0Etp-Ed-ak6NoX_4Aeg_-1342483973")]
    [DisplayName("Date From")]
    [IsoXmlTag("DtFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateFrom { get; init; } 
    
    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [IsoId("_Q6c0E9p-Ed-ak6NoX_4Aeg_1955410970")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; } 
    
    /// <summary>
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [IsoId("_Q6c0FNp-Ed-ak6NoX_4Aeg_958338617")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public CountryCode? RegisteredDistributionCountry { get; init; } 
    
    
    #nullable disable
    
}
