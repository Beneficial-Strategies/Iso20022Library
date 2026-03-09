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
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
[IsoId("_CtHU1__oEemm3skPVSMJQg")]
[DisplayName("Reconciliation Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationReport5( TradeTransactionIdentification4 reqTransactionIdentification,System.String reqModified,ReconciliationStatus5Choice_ reqReconciliationStatus )
    {
        TransactionIdentification = reqTransactionIdentification;
        Modified = reqModified;
        ReconciliationStatus = reqReconciliationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_CxSDIf_oEemm3skPVSMJQg")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to transactions that are subject of reconciliation.
    /// </summary>
    [IsoId("_CxSDI__oEemm3skPVSMJQg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransactionIdentification4 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransactionIdentification4 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionIdentification4 TransactionIdentification { get; init; } 
    #else
    public TradeTransactionIdentification4 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether information was modified.
    /// </summary>
    [IsoId("_CxSDJf_oEemm3skPVSMJQg")]
    [DisplayName("Modified")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Modfd")]
    #endif
    [IsoXmlTag("Modfd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Modified { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Modified { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Modified { get; init; } 
    #else
    public System.String Modified { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    [IsoId("_CxSDJ__oEemm3skPVSMJQg")]
    [DisplayName("Reconciliation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnSts")]
    #endif
    [IsoXmlTag("RcncltnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationStatus5Choice_ ReconciliationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationStatus5Choice_ ReconciliationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationStatus5Choice_ ReconciliationStatus { get; init; } 
    #else
    public ReconciliationStatus5Choice_ ReconciliationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
