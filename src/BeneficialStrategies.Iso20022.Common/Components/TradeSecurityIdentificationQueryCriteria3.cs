// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the query criteria related to securities.
/// </summary>
[IsoId("_GO0zUZNeEeytjZlcgApf6A")]
[DisplayName("Trade Security Identification Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeSecurityIdentificationQueryCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeSecurityIdentificationQueryCriteria3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeSecurityIdentificationQueryCriteria3( Operation3Code reqOperator )
    {
        Operator = reqOperator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_GQzJQ5NeEeytjZlcgApf6A")]
    [DisplayName("Operator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprtr")]
    #endif
    [IsoXmlTag("Oprtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Operation3Code Operator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Operation3Code Operator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operation3Code Operator { get; init; } 
    #else
    public Operation3Code Operator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the product through ISIN or AII.
    /// </summary>
    [IsoId("_GQzJRZNeEeytjZlcgApf6A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    #else
    public SecurityIdentificationQueryCriteria1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_kgZXkJNiEeytjZlcgApf6A")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #else
    public FinancialInstrumentContractType2Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_1sYF8JNjEeytjZlcgApf6A")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISINQueryCriteria1? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISINQueryCriteria1? ISIN { get; init; } 
    #else
    public ISINQueryCriteria1? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the product through a unique product identifier.
    /// </summary>
    [IsoId("_567KAJNjEeytjZlcgApf6A")]
    [DisplayName("Unique Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqPdctIdr")]
    #endif
    [IsoXmlTag("UnqPdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UPIQueryCriteria1? UniqueProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UPIQueryCriteria1? UniqueProductIdentifier { get; init; } 
    #else
    public UPIQueryCriteria1? UniqueProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type. 
    /// </summary>
    [IsoId("_GQzJR5NeEeytjZlcgApf6A")]
    [DisplayName("Underlying Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrmId")]
    #endif
    [IsoXmlTag("UndrlygInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentificationQuery4Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentificationQuery4Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentificationQuery4Choice_? UnderlyingInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
