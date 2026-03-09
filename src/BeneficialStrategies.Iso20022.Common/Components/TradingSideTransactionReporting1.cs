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
/// This is regulatory transaction reporting information from the Trading Side party.
/// </summary>
[IsoId("_fZgLUU4LEeOHYs5EqIAeTw")]
[DisplayName("Trading Side Transaction Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradingSideTransactionReporting1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_mnlioU4LEeOHYs5EqIAeTw")]
    [DisplayName("Reporting Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgJursdctn")]
    #endif
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportingJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportingJurisdiction { get; init; } 
    #else
    public System.String? ReportingJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_nyi54U4LEeOHYs5EqIAeTw")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? ReportingParty { get; init; } 
    #else
    public PartyIdentification73Choice_? ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Trading Side party.
    /// </summary>
    [IsoId("_qaB5gU4LEeOHYs5EqIAeTw")]
    [DisplayName("Trading Side Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdUnqTxIdr")]
    #endif
    [IsoXmlTag("TradgSdUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2? TradingSideUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2? TradingSideUniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier2? TradingSideUniqueTransactionIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
