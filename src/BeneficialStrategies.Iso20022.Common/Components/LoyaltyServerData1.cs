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
/// Data related to the loyalty server during a loyalty transaction.
/// </summary>
[IsoId("_0ZN1QNxLEeioifFt1dhnJA")]
[DisplayName("Loyalty Server Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyServerData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the loyalty Server.
    /// </summary>
    [IsoId("__zNMUNxLEeioifFt1dhnJA")]
    [DisplayName("Loyalty Server Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltySvrId")]
    #endif
    [IsoXmlTag("LltySvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LoyaltyServerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoyaltyServerIdentification { get; init; } 
    #else
    public System.String? LoyaltyServerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Approval code assigned to a loyalty transaction by the Server.
    /// </summary>
    [IsoId("_JAKEENxMEeioifFt1dhnJA")]
    [DisplayName("Approval Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlCd")]
    #endif
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin6Max8Text? ApprovalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApprovalCode { get; init; } 
    #else
    public System.String? ApprovalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Loyalty transaction in an unambiguous way.
    /// </summary>
    [IsoId("_sjFxENxMEeioifFt1dhnJA")]
    [DisplayName("Loyalty Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyTxId")]
    #endif
    [IsoXmlTag("LltyTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host.
    /// </summary>
    [IsoId("_7kPcENxMEeioifFt1dhnJA")]
    [DisplayName("Host Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstRcncltnId")]
    #endif
    [IsoXmlTag("HstRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HostReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostReconciliationIdentification { get; init; } 
    #else
    public System.String? HostReconciliationIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
