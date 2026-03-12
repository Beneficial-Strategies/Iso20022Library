// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the query criteria related to securities.
/// </summary>
[IsoId("_GO0zUZNeEeytjZlcgApf6A")]
[DisplayName("Trade Security Identification Query Criteria")]
public partial record TradeSecurityIdentificationQueryCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_GQzJQ5NeEeytjZlcgApf6A")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; } 
    
    /// <summary>
    /// Identification of the product through ISIN or AII.
    /// </summary>
    [IsoId("_GQzJRZNeEeytjZlcgApf6A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_kgZXkJNiEeytjZlcgApf6A")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_1sYF8JNjEeytjZlcgApf6A")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public ISINQueryCriteria1? ISIN { get; init; } 
    
    /// <summary>
    /// Identification of the product through a unique product identifier.
    /// </summary>
    [IsoId("_567KAJNjEeytjZlcgApf6A")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    public UPIQueryCriteria1? UniqueProductIdentifier { get; init; } 
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type. 
    /// </summary>
    [IsoId("_GQzJR5NeEeytjZlcgApf6A")]
    [DisplayName("Underlying Instrument Identification")]
    [IsoXmlTag("UndrlygInstrmId")]
    public SecurityIdentificationQuery4Choice_? UnderlyingInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
