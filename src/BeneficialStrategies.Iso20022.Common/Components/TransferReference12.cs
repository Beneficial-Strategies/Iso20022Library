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
/// Reference of a transfer and of a transfer confirmation.
/// </summary>
[IsoId("_1LZXYYi0EeefvMoXmllHqg")]
[DisplayName("Transfer Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferReference12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferReference12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferReference12( System.String reqTransferReference )
    {
        TransferReference = reqTransferReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction for which the confirmation reversal is sent, as assigned by the instructing party.
    /// </summary>
    [IsoId("_1bXtFYi0EeefvMoXmllHqg")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_1bXtF4i0EeefvMoXmllHqg")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? ClientReference { get; init; } 
    #else
    public AdditionalReference8? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer execution for which the confirmation reversal is sent, as assigned by the confirming party.
    /// </summary>
    [IsoId("_1bXtGYi0EeefvMoXmllHqg")]
    [DisplayName("Transfer Confirmation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfConfRef")]
    #endif
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransferConfirmationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferConfirmationReference { get; init; } 
    #else
    public System.String? TransferConfirmationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_1bXtG4i0EeefvMoXmllHqg")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference8? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the reversal as assigned by the confirming party.
    /// </summary>
    [IsoId("_V76nIIi1EeefvMoXmllHqg")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the reversal of confirmation.
    /// </summary>
    [IsoId("_iPdggY5UEeeNN9vGwZc5aA")]
    [DisplayName("Reversal Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsn")]
    #endif
    [IsoXmlTag("RvslRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReversalReason { get; init; } 
    #else
    public System.String? ReversalReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
