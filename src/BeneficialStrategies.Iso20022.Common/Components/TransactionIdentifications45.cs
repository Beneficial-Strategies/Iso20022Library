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
/// Provides unambiguous instruction or transaction identification information.
/// </summary>
[IsoId("_HZc9IRIqEeyZaPkaPAzTvQ")]
[DisplayName("Transaction Identifications")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionIdentifications45
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionIdentifications45 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionIdentifications45( System.String reqClientCollateralInstructionIdentification )
    {
        ClientCollateralInstructionIdentification = reqClientCollateralInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference identifying the collateral management instruction from the client&apos;s point of view. Identifies the potential match.
    /// </summary>
    [IsoId("_Hv8xkRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Client Collateral Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCollInstrId")]
    #endif
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ClientCollateralInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClientCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClientCollateralInstructionIdentification { get; init; } 
    #else
    public System.String ClientCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the collateral management transaction from the client&apos;s point of view. Present in case of a decrease.
    /// </summary>
    [IsoId("_Hv8xkxIqEeyZaPkaPAzTvQ")]
    [DisplayName("Client Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCollTxId")]
    #endif
    [IsoXmlTag("ClntCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ClientCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_Hv8xlRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrCollInstrId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty-agent/service-provider collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_Hv8xlxIqEeyZaPkaPAzTvQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrCollTxId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_Hv8xmRIqEeyZaPkaPAzTvQ")]
    [DisplayName("Common Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonTxId")]
    #endif
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? CommonTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonTransactionIdentification { get; init; } 
    #else
    public System.String? CommonTransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
