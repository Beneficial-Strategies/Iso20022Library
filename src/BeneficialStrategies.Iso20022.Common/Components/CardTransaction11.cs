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
/// Network management transaction.
/// </summary>
[IsoId("_wiFRAXvDEeSKFIcWw3l4Yw")]
[DisplayName("Card Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransaction11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransaction11( CardServiceType2Code reqNetworkManagementType )
    {
        NetworkManagementType = reqNetworkManagementType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of network management service (correspond to the ISO 8583 field 24).
    /// </summary>
    [IsoId("_erLrcHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Network Management Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkMgmtTp")]
    #endif
    [IsoXmlTag("NtwkMgmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardServiceType2Code NetworkManagementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardServiceType2Code NetworkManagementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardServiceType2Code NetworkManagementType { get; init; } 
    #else
    public CardServiceType2Code NetworkManagementType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_o2N8EHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Number Of Messages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfMsgs")]
    #endif
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfMessages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfMessages { get; init; } 
    #else
    public System.UInt64? NumberOfMessages { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_sZqNoHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Maximum Number Of Messages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNbOfMsgs")]
    #endif
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumberOfMessages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumberOfMessages { get; init; } 
    #else
    public System.UInt64? MaximumNumberOfMessages { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_yBYEEHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Initiator Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitrDtTm")]
    #endif
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InitiatorDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InitiatorDateTime { get; init; } 
    #else
    public System.DateTime? InitiatorDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the network management request.
    /// </summary>
    [IsoId("_m3xkEIO0EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseType2? TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType2? TransactionResponse { get; init; } 
    #else
    public ResponseType2? TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
