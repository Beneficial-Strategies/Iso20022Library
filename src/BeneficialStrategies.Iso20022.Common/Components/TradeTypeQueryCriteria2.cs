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
/// Indicates the query criteria related to transaction types.
/// </summary>
[IsoId("_14z4PRfMEeyPHpqpKwtFdw")]
[DisplayName("Trade Type Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTypeQueryCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTypeQueryCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTypeQueryCriteria2( Operation3Code reqOperator )
    {
        Operator = reqOperator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_2PddoRfMEeyPHpqpKwtFdw")]
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
    /// Query criteria related to the type of the securities financing transaction.
    /// </summary>
    [IsoId("_2PddoxfMEeyPHpqpKwtFdw")]
    [DisplayName("Securities Financing Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTxTp")]
    #endif
    [IsoXmlTag("SctiesFincgTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureType10Code? SecuritiesFinancingTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType10Code? SecuritiesFinancingTransactionType { get; init; } 
    #else
    public ExposureType10Code? SecuritiesFinancingTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Query criteria related to the type of the collateral component.
    /// </summary>
    [IsoId("_2PddpRfMEeyPHpqpKwtFdw")]
    [DisplayName("Collateral Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollCmpntTp")]
    #endif
    [IsoXmlTag("CollCmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType6Code? CollateralComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType6Code? CollateralComponentType { get; init; } 
    #else
    public CollateralType6Code? CollateralComponentType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
