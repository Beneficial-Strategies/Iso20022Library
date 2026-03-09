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
/// Regulatory transaction reporting information from the counterparty side party.
/// </summary>
[IsoId("_Bzi_4QN1Ee2-vqzwMUAewg")]
[DisplayName("Counterparty Side Transaction Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartySideTransactionReporting2
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
    [IsoId("_B5DK4QN1Ee2-vqzwMUAewg")]
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
    [IsoId("_B5DK4wN1Ee2-vqzwMUAewg")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? ReportingParty { get; init; } 
    #else
    public PartyIdentification242Choice_? ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Counterparty Side party.
    /// </summary>
    [IsoId("_B5DK5QN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdUnqTxIdr")]
    #endif
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2? CounterpartySideUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2? CounterpartySideUniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier2? CounterpartySideUniqueTransactionIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
